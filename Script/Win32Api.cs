using System;
using System.Runtime.InteropServices;
namespace 坎瑞亚钓鱼机
{
    public partial class Win32Api
    {
        [DllImport("user32")]
        public static extern bool GetClientRect(IntPtr hwnd, out RECT lpRect);
        [DllImport("user32 ")]
        public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);
        [DllImport("user32.dll")]
        public static extern bool SetProcessDPIAware();
        [DllImport("gdi32.dll")]
        public static extern IntPtr CreateCompatibleDC(IntPtr hdc);
        [DllImport("gdi32.dll")]
        public static extern IntPtr CreateCompatibleBitmap(IntPtr hdc, int nWidth, int nHeight);
        [DllImport("gdi32.dll")]
        public static extern IntPtr SelectObject(IntPtr hdc, IntPtr hgdiobj);
        [DllImport("gdi32.dll")]
        public static extern int DeleteDC(IntPtr hdc);
        [DllImport("user32.dll")]
        public static extern bool PrintWindow(IntPtr hwnd, IntPtr hdcBlt, int nFlags);
        [DllImport("user32.dll")]
        public static extern IntPtr GetWindowDC(IntPtr hwnd);
        [DllImport("user32")]
        public static extern int mouse_event(int dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);
        [DllImport("User32.dll", SetLastError = true)]
        public extern static IntPtr SetWindowsHookEx(WindowsHookType hookType, WindowsHookCallBack lpfn, IntPtr hmod, int dwThreadId);
        [DllImport("User32.dll", SetLastError = true)]
        public extern static IntPtr CallNextHookEx(int hhk, int nCode, int wParam, IntPtr lParam);
        //所有钩子函数的参数都一样，问题在于如何解释参数
        public delegate IntPtr WindowsHookCallBack(int nCode, int wParam, IntPtr lParam);
        public struct RECT
        {
            public int Left;                             //最左坐标
            public int Top;                             //最上坐标
            public int Right;                           //最右坐标
            public int Bottom;                        //最下坐标
        }
        public enum WindowsHookType
        {
            //全局键盘钩子
            WH_KEYBOARD_LL = 13,

            //全局鼠标钩子
            WH_MOUSE_LL = 14,
        }
        ///该类作用在于放在后台也能检测到键盘输入
        public static WindowsHookCallBack k_callback;
        ///该类作用在于放在后台也能检测到鼠标输入
        public static WindowsHookCallBack m_callback;
        //模拟鼠标左键按下 
        public const int MOUSEEVENTF_LEFTDOWN = 0x0002;
        //模拟鼠标左键抬起 
        public const int MOUSEEVENTF_LEFTUP = 0x0004;
        public enum KeyBoredHookStatus
        {
            WM_KEYDOWN = 0x0100,
            WM_KEYUP = 0x0101,
            WM_SYSKEYDOWN = 0x0104,
            WM_SYSKEYUP = 0x0105
        }
        [StructLayout(LayoutKind.Sequential)]
        public sealed class KeyBoredHookData
        {
            //虚拟码
            public int vkCode;
            //扫描码
            public int scanCode;
            public int flags;
            public int time;
            public IntPtr dwExtraInfo;
        }
    }
}