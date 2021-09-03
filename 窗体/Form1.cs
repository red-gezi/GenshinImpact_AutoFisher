using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using static 坎瑞亚钓鱼机.InfoModel;

namespace 坎瑞亚钓鱼机
{
    public partial class Form1 : Form
    {
        static bool isMapFormOpen;
        MapForm mapForm;
        public Form1()
        {
            using Bitmap bitmap = (Bitmap)Bitmap.FromFile("bar.png");
            {
                Bitmap r = new Bitmap(bitmap);
                Bitmap g = new Bitmap(bitmap);
                Bitmap b = new Bitmap(bitmap);
                Bitmap s = new Bitmap(bitmap);
                Bitmap avb = new Bitmap(bitmap);
                for (int i = 0; i < bitmap.Width; i++)
                {
                    for (int j = 0; j < bitmap.Height; j++)
                    {
                        var color = bitmap.GetPixel(i, j);
                        int d = (color.R + color.G + color.B) / 3;
                        //只要能量条
                        int sv = Math.Sign(Math.Max(0, (color.G - color.R)) - 123) < 0 ? 0 : 255;
                        //只要标志物
                        int av = Math.Sign(color.R - 123) < 0 ? 0 : 255;
                        s.SetPixel(i, j, Color.FromArgb(255, av, av, av));
                    }
                }
                Bitmap outImage = new Bitmap(bitmap);
                int pixel = 1;
                for (int i = 0; i < bitmap.Width; i += pixel)
                {
                    List<Color> colors = new List<Color>();
                    for (int x = i; x < i + pixel && x < bitmap.Width; x++)
                    {
                        for (int j = 0; j < bitmap.Height; j++)
                        {
                            colors.Add(s.GetPixel(x, j));
                        }
                    }
                    Color regionColor = Color.FromArgb(
                              255,
                              (int)colors.Select(c => (int)c.R).Average(),
                              (int)colors.Select(c => (int)c.G).Average(),
                              (int)colors.Select(c => (int)c.B).Average()
                              );
                    for (int x = i; x < i + pixel && x < bitmap.Width; x++)
                    {
                        for (int j = 0; j < bitmap.Height; j++)
                        {
                            outImage.SetPixel(x, j, regionColor);
                        }
                    }

                }
                r.Save("r.png");
                g.Save("g.png");
                b.Save("b.png");
                s.Save("s.png");
                outImage.Save("outImage.png");
            }
            InitializeComponent();
            this.Text = "坎瑞亚钓鱼机v1.0";
            Win32Api.SetProcessDPIAware();
            DataInfo.LoadData();
            InputListenerr.GetMouseEvent((key) =>
            {
                Console.WriteLine(key);
                if (key=="513")
                {
                    DataInfo.isPauseShowIcon = true;
                }
                if (key == "514")
                {
                    DataInfo.isPauseShowIcon = false;
                }
                DataInfo.isDetection = true;
            });
            InputListenerr.GetKeyDownEvent((key) =>
            {
                if (key == "M")
                {
                    if (isMapFormOpen)
                    {
                        btn_Close_Click(null, null);
                    }
                    else
                    {
                        btn_Open_Click(null, null);
                    }
                }
                if (key == "esc") btn_Close_Click(null, null);
                DataInfo.isDetection = true;
            });
            var items = DataInfo.GetAllPos.Select(icon => icon.name).Distinct().ToArray();
            //控制地图校准系数
            string[] configs = File.ReadAllLines("config/bias.txt");
            U0.Text = configs[0];
            V0.Text = configs[1];
            U1.Text = configs[2];
            V1.Text = configs[3];
            DataInfo.PixelPerIng = float.Parse(File.ReadAllLines("config/bias.txt")[0]);
            DataInfo.PixelPerLat = float.Parse(File.ReadAllLines("config/bias.txt")[1]);
            DataInfo.IngBias = float.Parse(File.ReadAllLines("config/bias.txt")[2]);
            DataInfo.LatBias = float.Parse(File.ReadAllLines("config/bias.txt")[3]);
        }
        private void btn_Open_Click(object sender, EventArgs e)
        {
            if (DataInfo.YuanshenProcess != null || DataInfo.isUseFakePicture)
            {
                isMapFormOpen = true;
                mapForm = new MapForm();
                mapForm.Show();
            }
            else
            {
                MessageBox.Show("请先打开游戏");
            }
        }
        private void btn_Close_Click(object sender, EventArgs e)
        {
            if (mapForm != null)
            {
                mapForm.isJumpOutOfTask = true;
                mapForm.Close();
                mapForm.Dispose();
                isMapFormOpen = false;
            }
        }
       
        private void btn_github_Click(object sender, EventArgs e) => Process.Start("https://github.com/red-gezi/GenshinImpact_MonsterMap");
        private void button1_Click(object sender, EventArgs e) => Process.Start("https://wiki.biligame.com/ys/%E5%8E%9F%E7%A5%9E%E5%9C%B0%E5%9B%BE%E5%B7%A5%E5%85%B7_%E5%85%A8%E5%9C%B0%E6%A0%87%E4%BD%8D%E7%BD%AE%E7%82%B9");
        private void btn_SetRect_Click(object sender, EventArgs e)
        {
            DataInfo.width = int.Parse(game_width.Text);
            DataInfo.height = int.Parse(game_height.Text);
        }

        RECT rect = new RECT();
        private void timer1_Tick(object sender, EventArgs e)
        {
            DataInfo.isShowLine = cb_ShowLine.Checked;
            DataInfo.selectTags.Clear();
            
            if (DataInfo.YuanshenProcess != null && cb_AutoLoadScreen.Checked)
            {

                Win32Api.GetClientRect(DataInfo.YuanshenProcess.MainWindowHandle, out rect);
                DataInfo.width = rect.Right;
                DataInfo.height = rect.Bottom;
                game_width.Text = rect.Right + "";
                game_height.Text = rect.Bottom + "";
            }
        }

        private void ValueChange(object sender, EventArgs e)
        {
            if (U0.Value + V0.Value + U1.Value + V1.Value != 0)
            {
                Console.WriteLine("修正映射参数");
                DataInfo.PixelPerIng = (float)U0.Value;
                DataInfo.PixelPerLat = (float)V0.Value;
                DataInfo.IngBias = (float)U1.Value;
                DataInfo.LatBias = (float)V1.Value;
                File.WriteAllLines("config/bias.txt", new string[] {
                DataInfo.PixelPerIng.ToString(),
                DataInfo.PixelPerLat.ToString(),
                DataInfo.IngBias.ToString(),
                DataInfo.LatBias.ToString(),
            });
            }

        }

        private void V0_ValueChanged(object sender, EventArgs e) => File.WriteAllLines("config/bias.txt", new string[] { U0.Text, ((NumericUpDown)sender).Value.ToString(), U1.Text, V1.Text, });

        private void U0_ValueChanged(object sender, EventArgs e) => File.WriteAllLines("config/bias.txt", new string[] { ((NumericUpDown)sender).Value.ToString(), V0.Text, U1.Text, V1.Text, });
        private void U1_ValueChanged(object sender, EventArgs e) => File.WriteAllLines("config/bias.txt", new string[] { U0.Text, V0.Text, ((NumericUpDown)sender).Value.ToString(), V1.Text, });
        private void V1_ValueChanged(object sender, EventArgs e) => File.WriteAllLines("config/bias.txt", new string[] { U0.Text, V0.Text, U1.Text, ((NumericUpDown)sender).Value.ToString(), });

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
