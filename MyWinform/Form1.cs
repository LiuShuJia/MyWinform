using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyWinform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("您按了一下按钮");
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            MessageBox.Show("您好！");
        }

        private void btnyyf_Click(object sender, EventArgs e)
        {
            MessageBox.Show("叶贻峰！");
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            MessageBox.Show("I am likongqiang");
        }
    }
}
