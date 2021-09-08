using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using static 坎瑞亚钓鱼机.Win32Api;

namespace 坎瑞亚钓鱼机
{
    public partial class FishForm : Form
    {
        static Bitmap clipImage = new Bitmap(Info.w, Info.h);
        static Bitmap scaleImage = new Bitmap(Info.showImageWidth, Info.showImageHeigh);
        static Bitmap signImage = new Bitmap(Info.showImageWidth, Info.showImageHeigh);
        static Bitmap stepImage = new Bitmap(Info.showImageWidth, Info.showImageHeigh);
        static Bitmap rangeImage = new Bitmap(Info.showImageWidth, Info.showImageHeigh);
        static Bitmap cursorImage = new Bitmap(Info.showImageWidth, Info.showImageHeigh);
        public FishForm()
        {
            InitializeComponent();
            X.Value = Config.GetConfig(0);
            Y.Value = Config.GetConfig(1);
            W.Value = Config.GetConfig(2);
            H.Value = Config.GetConfig(3);
            colorStep.Value = Config.GetConfig(4);
            rangeMin.Value = Config.GetConfig(5);
            rangeMax.Value = Config.GetConfig(6);
            cursorMin.Value = Config.GetConfig(7);
            cursorMax.Value = Config.GetConfig(8);
            RefreshConfig();
            pict_light.Image = new Bitmap(1, 1);
            Info.isInitConfigOver = true;
            clipImage = new Bitmap((int)W.Value, (int)H.Value);
            this.Text = "坎瑞亚钓鱼机v1.0";
            Win32Api.SetProcessDPIAware();
            ////控制地图校准系数
            GetKeyBoardInput();
            _ = AnalysicsAsync();
        }

        private static void GetKeyBoardInput()
        {
            InputListenerr.GetKeyDownEvent(key =>
            {
                if (key == "CtrlO")
                {
                    if (Info.isStart)
                    {
                        Console.WriteLine("关闭");
                        Info.isStart = false;
                    }
                    else
                    {
                        Console.WriteLine("打开");
                        Info.isStart = true;
                    }
                    
                }
                if (key == "P")
                {
                    //如果在非暂停模式下，则截图并暂停
                    if (!Info.isPause)
                    {
                        var gameImage = ImageUnitility.GetScreenshot(Info.YuanshenProcess.MainWindowHandle);
                        gameImage.Save("game.png");
                        gameImage.Dispose();
                    }
                    Info.isPause = !Info.isPause;
                }
            });
        }

        private void btn_SetRect_Click(object sender, EventArgs e)
        {
            Info.width = int.Parse(game_width.Text);
            Info.height = int.Parse(game_height.Text);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Info.YuanshenProcess != null && cb_AutoLoadScreen.Checked)
            {
                RECT rect;
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
                Timer.Show("屏幕截图");
                if (new FileInfo("game.png").Exists)
                {
                    Bitmap ScreenShot = Info.isPause ? (Bitmap)Image.FromFile("game.png") : ImageUnitility.GetScreenshot(Info.YuanshenProcess.MainWindowHandle);
                    DrawClipImage(ScreenShot);
                    Timer.Show("提取钓鱼槽");
                    DrawSignImage();
                    Timer.Show("提取ui槽");
                    DrawStepImage();
                    Timer.Show("转换色阶槽");
                    DrawRangeImage();
                    Timer.Show("提取范围");
                    DrawCursorImage();
                    Timer.Show("提取光标位置");
                }
               
                if (Info.isMouseShouldDown)
                {
                    Bitmap bitmap = ((Bitmap)pict_light.Image);
                    bitmap.SetPixel(0, 0, Color.Red);
                    pict_light.Image = bitmap;
                    InputListenerr.SetMouseDown(true);
                }
                else
                {
                    Bitmap bitmap = ((Bitmap)pict_light.Image);
                    bitmap.SetPixel(0, 0, Color.Gray);
                    pict_light.Image = bitmap;
                    InputListenerr.SetMouseDown(false);
                }
                // Console.WriteLine(Info.isMouseShouldDown+"-" +Info.isLastMouseShouldDown);
                //if (Info.isMouseShouldDown&&!Info.isLastMouseShouldDown)
                //{
                //    InputListenerr.SetMouseDown(true);
                //}
                //if (!Info.isMouseShouldDown && Info.isLastMouseShouldDown)
                //{
                //    InputListenerr.SetMouseDown(false);
                //}
                ////Info.isLastMouseShouldDown = Info.isMouseShouldDown;
                //if (Info.isMouseShouldDown&&!Info.isPause)
                //{
                //    InputListenerr.SetMouseDown(true);
                //}
                await Task.Delay(1);
            }
        }
        //从游戏中裁剪相应范围的图
        private void DrawClipImage(Bitmap gameImage)
        {
            if (Info.width > 0 && Info.height > 0)
            {
                using (Graphics g = Graphics.FromImage(clipImage))
                {
                    g.DrawImage(
                        gameImage,
                        new Rectangle(0, 0, Info.width, Info.height),
                        new Rectangle(Info.x, Info.y, Info.w, Info.h),
                        GraphicsUnit.Pixel);
                }
                //clipImage.Save("clip.png");
                scaleImage = (Bitmap)clipImage.GetThumbnailImage(Info.showImageWidth, Info.showImageHeigh, null, IntPtr.Zero);
                //scaleImage.Save("scale.png");
                gameImage.Dispose();
                pict_bar.Image = scaleImage;
            }
        }
        //绘制UI指示物提取图
        private void DrawSignImage()
        {
            for (int i = 0; i < Info.showImageWidth; i++)
            {
                for (int j = 0; j < Info.showImageHeigh; j++)
                {
                    var color = scaleImage.GetPixel(i, j);
                    int sign = Math.Abs(color.R - 255) + Math.Abs(color.G - 255) + Math.Abs(color.B - 192) < colorStep.Value ? 255 : 0;
                    signImage.SetPixel(i, j, Color.FromArgb(255, sign, sign, sign));
                }
            }
            pict_sign.Image = signImage;
            //signImage.Save("sign.png");
        }
        //绘制色阶图
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
        //提取范围槽并绘制绘制
        private void DrawRangeImage()
        {
            for (int i = 0; i < Info.showImageWidth; i++)
            {
                for (int j = 0; j < Info.showImageHeigh; j++)
                {
                    var color = stepImage.GetPixel(i, j);
                    int gray = (color.R + color.G + color.B) / 3;
                    int value = ((rangeMin.Value < gray) && (gray < rangeMax.Value)) ? 255 : 0;
                    rangeImage.SetPixel(i, j, Color.FromArgb(255, value, value, value));
                }
            }
            Info.rangeMin = 0;
            Info.isDetectionRange = false;
            for (int i = 0; i < Info.showImageWidth; i++)
            {
                if (rangeImage.GetPixel(i, 0).R == 255)
                {
                    Info.rangeMin = i;
                    Info.isDetectionRange = true;
                    break;
                }
            }
            Info.rangeMax = 10;
            for (int i = Info.showImageWidth - 1; i >= 0; i--)
            {
                if (rangeImage.GetPixel(i, 0).R == 255)
                {
                    Info.rangeMax = i;
                    break;
                }
            }
            label_range.Text = $"范围刻度：{Info.rangeMin}-{Info.rangeMax}";
            pict_range.Image = rangeImage;
            //rangeImage.Save("rangeImage.png");
        }
        //提取游标槽并绘制绘制
        private void DrawCursorImage()
        {
            for (int i = 0; i < Info.showImageWidth; i++)
            {
                for (int j = 0; j < Info.showImageHeigh; j++)
                {
                    var color = stepImage.GetPixel(i, j);
                    int gray = (color.R + color.G + color.B) / 3;
                    int value = ((cursorMin.Value < gray) && (gray < cursorMax.Value)) ? 255 : 0;
                    cursorImage.SetPixel(i, j, Color.FromArgb(255, value, value, value));
                }
            }
            Info.cursorValue = 0;
            Info.isDetectionCursor = false;

            for (int i = 0; i < Info.showImageWidth; i++)
            {
                if (cursorImage.GetPixel(i, 0).R == 255)
                {
                    Info.cursorValue = i;
                    Info.isDetectionCursor = true;
                    break;
                }
            }
            label_cursor.Text = $"游标刻度：{ Info.cursorValue}";
            pict_current.Image = cursorImage;
            //currentPointImage.Save("outImage.png");
        }
        private void ValueChange(object sender, EventArgs e)
        {
            if (Info.isInitConfigOver)
            {
                Console.WriteLine("刷新值");
                RefreshConfig();
                clipImage = new Bitmap(Info.w, Info.h);
            }
        }

        private void RefreshConfig()
        {
            Config.SetConfig(0, (int)X.Value);
            Config.SetConfig(1, (int)Y.Value);
            Config.SetConfig(2, (int)W.Value);
            Config.SetConfig(3, (int)H.Value);

            Config.SetConfig(4, (int)colorStep.Value);
            Config.SetConfig(5, (int)rangeMin.Value);
            Config.SetConfig(6, (int)rangeMax.Value);
            Config.SetConfig(7, (int)cursorMin.Value);
            Config.SetConfig(8, (int)cursorMax.Value);
            Info.x = Config.GetConfig(0);
            Info.y = Config.GetConfig(1);
            Info.w = Config.GetConfig(2);
            Info.h = Config.GetConfig(3);
        }

        private void btn_Pause_Click(object sender, EventArgs e) => Info.isPause = !Info.isPause;
        private void btn_github_Click(object sender, EventArgs e) => Process.Start("https://github.com/red-gezi/GenshinImpact_AutoFisher");
        private void btn_Wili_Click(object sender, EventArgs e) => Process.Start("https://wiki.biligame.com/ys/%E5%8E%9F%E7%A5%9E%E5%9C%B0%E5%9B%BE%E5%B7%A5%E5%85%B7_%E5%85%A8%E5%9C%B0%E6%A0%87%E4%BD%8D%E7%BD%AE%E7%82%B9");

        private void btn_open_Click(object sender, EventArgs e) => Info.isStart = true;

        private void btn_down_Click(object sender, EventArgs e) => Info.isStart = false;
    }
}
