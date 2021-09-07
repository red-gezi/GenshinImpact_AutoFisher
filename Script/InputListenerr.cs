using System;
using System.Runtime.InteropServices;
using static 坎瑞亚钓鱼机.Win32Api;
/// <summary>
/// 全局检测类
/// </summary>
namespace 坎瑞亚钓鱼机
{

    class InputListenerr
    {
        static bool isCtrlDown = false;
        ///////////////////////////////////////////下面是看不懂的win API区域///////////////////////////////////////////////////
       
      
        public static void GetKeyDownEvent(Action<string> response)
        {
            k_callback = CreateCallBack((status, data) =>
            {
                if (data.vkCode == 162)//判断按下的是否是ctrl
            {
                    isCtrlDown = status == KeyBoredHookStatus.WM_KEYDOWN;
                }
                else if (status == KeyBoredHookStatus.WM_KEYDOWN)
                {
                //代码
                if (data.vkCode == 27)
                    {
                        response("esc");

                    }
                    else
                    {
                        string key = (isCtrlDown ? "Ctrl" : "") + (((char)data.vkCode).ToString().ToUpper());
                        response(key);
                    }

                }
            });
            IntPtr intPtr = SetWindowsHookEx(WindowsHookType.WH_KEYBOARD_LL, k_callback, IntPtr.Zero, 0);
        }
        public static void GetMouseEvent(Action<string> response)
        {
            m_callback = CreateCallBack((status, data) =>
            {
                if ((int)status != 512)
                {
                    response(status.ToString());
                }

            });
            IntPtr intPtr = SetWindowsHookEx(WindowsHookType.WH_MOUSE_LL, m_callback, IntPtr.Zero, 0);
        }
        public static void SetMouseDown(bool isMouseDown)
        {
            Win32Api.mouse_event(isMouseDown ? MOUSEEVENTF_LEFTDOWN : MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
        }
        static WindowsHookCallBack CreateCallBack(Action<KeyBoredHookStatus, KeyBoredHookData> action)
        {
            return (int nCode, int wParam, IntPtr lParam) =>
            {
                if (nCode < 0)
                {
                    return CallNextHookEx(default, nCode, wParam, lParam);
                }
                else
                {
                    KeyBoredHookData data = Marshal.PtrToStructure<KeyBoredHookData>(lParam);
                    action((KeyBoredHookStatus)wParam, data);
                    return CallNextHookEx(default, nCode, wParam, lParam);
                }
            };
        }
    }
}