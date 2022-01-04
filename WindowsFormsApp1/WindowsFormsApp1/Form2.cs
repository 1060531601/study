using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public static Form2 form2 = null;
        private Form2()
        {
            InitializeComponent();
            form2 = this;
        }

        public static Form2 GetForm()
        {
            if (form2 == null)
            {
                return new Form2();
            }
            return form2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            form2.Close();
        }
    }
}
