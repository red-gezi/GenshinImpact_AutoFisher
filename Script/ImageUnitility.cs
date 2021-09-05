
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 坎瑞亚钓鱼机
{
    /// <summary>
    /// 图片的匹配和截取工具类
    /// </summary>
    class ImageUnitility
    {
        public static Bitmap GetScreenshot(IntPtr hWnd)
        {
            IntPtr hscrdc = Win32Api.GetWindowDC(hWnd);
            //IntPtr hbitmap = Win32Api.CreateCompatibleBitmap(hscrdc, DataInfo.width + x, DataInfo.height + y);
            IntPtr hbitmap = Win32Api.CreateCompatibleBitmap(hscrdc, Info.width , Info.height);
            IntPtr hmemdc = Win32Api.CreateCompatibleDC(hscrdc);
            Win32Api.SelectObject(hmemdc, hbitmap);
            Win32Api.PrintWindow(hWnd, hmemdc, 0);
            Bitmap gameImage = Image.FromHbitmap(hbitmap);
            Win32Api.DeleteDC(hscrdc);
            Win32Api.DeleteDC(hmemdc);
            return gameImage;
        }
    }
}
