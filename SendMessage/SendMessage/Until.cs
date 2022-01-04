using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace SendMessage
{
   public static class Until
    {
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
       public static extern IntPtr SendMessage(IntPtr hWnd, int Msg, IntPtr wParam, IntPtr lParam);

        [DllImport("user32.dll")]
        public static extern IntPtr SendDlgItemMessage(IntPtr hWnd, int nIDDlgItem, int Msg, IntPtr wParam, IntPtr lParam);


        [DllImport("user32.dll")]
        public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        [DllImport("user32.dll")]
        public static extern IntPtr GetWindow(IntPtr hWnd,int uCmd);


        [DllImport("user32.dll",CharSet= CharSet.Auto)]
        public static extern int GetDlgCtrlID(IntPtr hWnd);

        public static readonly int WM_GETTEXT = 0x000D;

        public static readonly int WM_SETTEXT = 0x000C;
    }
}
