using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1 form1;

        public Form1()
        {
            InitializeComponent();
            form1 = this;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            var task = Task.Factory.StartNew(
                () =>
                {
                    using (var form3 = new Form3())
                    {
                        form3.ShowDialog();
                    }
                    
                });
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var task = Task.Factory.StartNew(
                () =>
                {
                    new Form3().ShowDialog();
                    

                });
        }

        private void button3_Click(object sender, EventArgs e)
        {
            List<string> strs = null;

            strs.Add("111");
            using (var form3 = new Form3()) {
                form3.ShowDialog();
            }
        }
    }
}
