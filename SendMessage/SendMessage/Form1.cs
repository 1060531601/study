using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace SendMessage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var text = "3      44445555555555     7777700000";
            var num = text.Substring(0, 1);
            var kanjyanum = text.Substring(1, 10);
            var otsukari = text.Substring(11, 10);
            var otsuru = text.Substring(21, 10);
            var title = text.Substring(31, text.Length - 31);


            if (1 == 104)
            { 
            
            }

            //var pwnd = Until.FindWindow(null, "Form1");

            //var chail = Until.GetWindow(pwnd, 5);

            //var textboxhandle = textBox1.Handle;
            //var checkedListBox1 = this.checkedListBox1.Handle;


            //var button1 = this.button1.Handle;

            //var re1 = Until.SendDlgItemMessage(pwnd,Until.GetDlgCtrlID(button1), Until.WM_SETTEXT, new IntPtr(16), Marshal.StringToHGlobalUni("4     0   0    0    0"));


            //var result =  Until.SendMessage(textboxhandle, Until.WM_SETTEXT, new IntPtr(0), Marshal.StringToHGlobalUni("君"));
        }
    }

}
