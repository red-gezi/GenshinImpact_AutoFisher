using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using static 坎瑞亚钓鱼机.InfoModel;

namespace 坎瑞亚钓鱼机
{
    public partial class Form1 : Form
    {
        static Bitmap clipImage;
        static Bitmap scaleImage;
        static Bitmap signImage;
        static Bitmap stepImage;
        static Bitmap rangeImage;
        static Bitmap currentPointImage;

        public Form1()
        {
            Info.x = int.Parse(File.ReadAllLines("config/bias.txt")[0]);
            Info.y = int.Parse(File.ReadAllLines("config/bias.txt")[1]);
            Info.w = int.Parse(File.ReadAllLines("config/bias.txt")[2]);
            Info.h = int.Parse(File.ReadAllLines("config/bias.txt")[3]);
            InitializeComponent();
            this.Text = "坎瑞亚钓鱼机v1.0";
            Win32Api.SetProcessDPIAware();
            ////控制地图校准系数
            string[] configs = File.ReadAllLines("config/bias.txt");
            U0.Text = configs[0];
            V0.Text = configs[1];
            U1.Text = configs[2];
            V1.Text = configs[3];

            clipImage = new Bitmap(Info.w, Info.h);
            scaleImage = new Bitmap(Info.showImageWidth, Info.showImageHeigh);
            signImage = new Bitmap(Info.showImageWidth, Info.showImageHeigh);
            stepImage = new Bitmap(Info.showImageWidth, Info.showImageHeigh);
            rangeImage = new Bitmap(Info.showImageWidth, Info.showImageHeigh);
            currentPointImage = new Bitmap(Info.showImageWidth, Info.showImageHeigh);
            _=AnalysicsAsync();
        }
        private void btn_github_Click(object sender, EventArgs e) => Process.Start("https://github.com/red-gezi/GenshinImpact_MonsterMap");
        private void button1_Click(object sender, EventArgs e) => Process.Start("https://wiki.biligame.com/ys/%E5%8E%9F%E7%A5%9E%E5%9C%B0%E5%9B%BE%E5%B7%A5%E5%85%B7_%E5%85%A8%E5%9C%B0%E6%A0%87%E4%BD%8D%E7%BD%AE%E7%82%B9");
        private void btn_SetRect_Click(object sender, EventArgs e)
        {
            Info.width = int.Parse(game_width.Text);
            Info.height = int.Parse(game_height.Text);
        }
        RECT rect = new RECT();
        private void timer1_Tick(object sender, EventArgs e)
        {

            if (Info.YuanshenProcess != null && cb_AutoLoadScreen.Checked)
            {
                Win32Api.GetClientRect(Info.YuanshenProcess.MainWindowHandle, out rect);
                Info.width = rect.Right;
                Info.height = rect.Bottom;
                game_width.Text = rect.Right + "";
                game_height.Text = rect.Bottom + "";
            }
        }

        private async Task AnalysicsAsync()
        {
            while (true)
            {
                Timer.Init();
                if (!Info.isPause)
                {
                    using (var gameImage = ImageUnitility.GetScreenshot(Info.YuanshenProcess.MainWindowHandle))
                    {
                        try
                        {
                            gameImage.Save("game.png");

                        }
                        catch (Exception)
                        {
                        }
                    }
                }
                Timer.Show("屏幕截图");
                if (new FileInfo("game.png").Exists)
                {
                    Bitmap ScreenShot = (Bitmap)Image.FromFile("game.png");

                    DrawClipImage(ScreenShot);
                    Timer.Show("提取钓鱼槽");
                    DrawSignImage();
                    Timer.Show("提取ui槽");
                    DrawStepImage();
                    Timer.Show("转换色阶槽");
                    DrawRangeImage();
                    Timer.Show("提取范围");
                    DrawCurrentPointImage();
                    Timer.Show("提取光标位置");
                }
                await Task.Delay(10);
            }
        }
        //从游戏中裁剪相应范围的图
        private void DrawClipImage(Bitmap gameImage)
        {
            if (Info.width > 0 && Info.height > 0)
            {
                //Bitmap clipImage = new Bitmap(Info.w, Info.h);
                using (Graphics g = Graphics.FromImage(clipImage))
                {
                    g.DrawImage(
                        gameImage,
                        new Rectangle(0, 0, Info.width, Info.height),
                        new Rectangle(Info.x, Info.y, Info.w, Info.h),
                        GraphicsUnit.Pixel);
                }
                clipImage.Save("clip.png");
                scaleImage = (Bitmap)clipImage.GetThumbnailImage(Info.showImageWidth, Info.showImageHeigh, null, IntPtr.Zero);
                scaleImage.Save("scale.png");
                gameImage.Dispose();
                pict_bar.Image = scaleImage;
                Console.WriteLine("修改成功");
            }
        }

        //创建UI指示物提取图
        private void DrawSignImage()
        {
            //var fast_clipImage = new FastBitmap(clipImage);
            //var fast_scaleImage = new FastBitmap(scaleImage);
            //fast_clipImage.LockBits();
            //fast_scaleImage.LockBits();
            //for (int i = 0; i < Info.showImageWidth; i++)
            //{
            //    for (int j = 0; j < Info.showImageHeigh; j++)
            //    {
            //        var color = fast_clipImage.GetPixel(i, j);
            //        int sign = Math.Abs(color.R - 255) + Math.Abs(color.G - 255) + Math.Abs(color.B - 192) < 100 ? 255 : 0;
            //        fast_scaleImage.SetPixel(i, j, Color.FromArgb(255, sign, sign, sign));
            //    }
            //}
            //fast_clipImage.UnlockBits();
            //fast_scaleImage.UnlockBits();
            //pict_sign.Image = signImage;
            for (int i = 0; i < Info.showImageWidth; i++)
            {
                for (int j = 0; j < Info.showImageHeigh; j++)
                {
                    var color = scaleImage.GetPixel(i, j);
                    int sign = Math.Abs(color.R - 255) + Math.Abs(color.G - 255) + Math.Abs(color.B - 192) < 100 ? 255 : 0;
                    signImage.SetPixel(i, j, Color.FromArgb(255, sign, sign, sign));
                }
            }
            pict_sign.Image = signImage;
            signImage.Save("sign.png");
        }

        //创建色阶图
        private void DrawStepImage()
        {
            const int pixel = 1;
            for (int i = 0; i < Info.showImageWidth; i += pixel)
            {
                List<Color> colors = new List<Color>();
                for (int x = i; x < i + pixel && x < Info.showImageWidth; x++)
                {
                    for (int j = 0; j < Info.showImageHeigh; j++)
                    {
                        colors.Add(signImage.GetPixel(x, j));
                    }
                }
                Color regionColor = Color.FromArgb(
                          255,
                          (int)colors.Select(c => (int)c.R).Average(),
                          (int)colors.Select(c => (int)c.G).Average(),
                          (int)colors.Select(c => (int)c.B).Average()
                          );
                for (int x = i; x < i + pixel && x < Info.showImageWidth; x++)
                {
                    for (int j = 0; j < Info.showImageHeigh; j++)
                    {
                        stepImage.SetPixel(x, j, regionColor);
                    }
                }
            }
            pict_step.Image = stepImage;
            //outImage.Save("outImage.png");
        }
        private void DrawRangeImage()
        {
            for (int i = 0; i < Info.showImageWidth; i++)
            {
                for (int j = 0; j < Info.showImageHeigh; j++)
                {
                    var color = stepImage.GetPixel(i, j);
                    int gray = (color.R + color.G + color.B) / 3;
                    int value = ((50 < gray) && (gray < 150)) ? 255 : 0;
                    rangeImage.SetPixel(i, j, Color.FromArgb(255, value, value, value));
                }
            }
            pict_range.Image = rangeImage;
            //rangeImage.Save("rangeImage.png");
        }
        private void DrawCurrentPointImage()
        {
            for (int i = 0; i < Info.showImageWidth; i++)
            {
                for (int j = 0; j < Info.showImageHeigh; j++)
                {
                    var color = stepImage.GetPixel(i, j);
                    int gray = (color.R + color.G + color.B) / 3;
                    int value = ((150 < gray) && (gray < 255)) ? 255 : 0;
                    currentPointImage.SetPixel(i, j, Color.FromArgb(255, value, value, value));
                }
            }
            pict_current.Image = currentPointImage;
            //currentPointImage.Save("outImage.png");
        }
        private void ValueChange(object sender, EventArgs e)
        {
            if (U0.Value + V0.Value + U1.Value + V1.Value != 0)
            {
                Console.WriteLine("修正映射参数");
                Info.x = (int)U0.Value;
                Info.y = (int)V0.Value;
                Info.w = (int)U1.Value;
                Info.h = (int)V1.Value;
                File.WriteAllLines("config/bias.txt", new string[] {
                Info.x.ToString(),
                Info.y.ToString(),
                Info.w.ToString(),
                Info.h.ToString(),
                });
                if (Info.w != 0 && Info.h != 0)
                {
                    clipImage = new Bitmap(Info.w, Info.h);
                    //signImage = new Bitmap(Info.w, Info.h);
                    //stepImage = new Bitmap(Info.w, Info.h);
                    //rangeImage = new Bitmap(Info.w, Info.h);
                    //currentPointImage = new Bitmap(Info.w, Info.h);
                }

            }
        }
        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btn_Pause_Click(object sender, EventArgs e) => Info.isPause = !Info.isPause;
    }
}
