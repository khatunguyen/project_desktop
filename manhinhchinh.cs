// màn hình chính
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NGUYENLEKHATU_BAITAPVENHA02
{
    public partial class manhinhchinh : Form
    {
        public manhinhchinh()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form form = new Form1();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form form = new Bai2();
            form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form form = new Bai3();
            form.Show();
        }
    }
}

