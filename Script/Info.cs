using System;
using System.Diagnostics;
using System.Linq;

namespace 坎瑞亚钓鱼机
{
    /// <summary>
    /// 全局信息类
    /// </summary>
    class Info
    {
       
        //校准
        public static int x = 0;
        public static int y = 0;
        public static int w = 1;
        public static int h = 1;
        public static int showImageWidth = 100;
        public static int showImageHeigh = 20;

        public static int rangeMin=1;
        public static int rangeMax=10;
        public static int cursorValue=1;
        public static bool isLastMouseShouldDown = false;
        public static bool isDetectionRange;
        public static bool isDetectionCursor;
        public static bool isDetectionSuccess=> rangeMax - rangeMin > 5&& isDetectionRange;
        public static bool isMouseShouldDown=>cursorValue<(rangeMin+ rangeMax)/2&& isDetectionSuccess;

        static Process[] gameProcess => Process.GetProcessesByName( "YuanShen");
        public static Process YuanshenProcess => gameProcess.Any() ? gameProcess[0] : null;
        public static IntPtr mainHandle => YuanshenProcess.MainWindowHandle;
        public static IntPtr hDeskTop = Win32Api.FindWindow("Progman ", "Program   Manager ");

        public static int width = 1920;
        public static int height = 1080;
        public static bool isInitConfigOver = false;
        public static bool isPause = true;
        public static bool isStart = true;
        //public static bool isAutoMouseDown = false;
    }
}