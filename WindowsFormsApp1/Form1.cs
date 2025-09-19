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
        public Form1()
        {
            InitializeComponent();

            button1.Click += Button1_Click;
            button2.Click += Button2_Click;
            button3.Click += Button3_Click;
            button4.Click += Button4_Click;
            button5.Click += Button5_Click;
            button6.Click += Button6_Click;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            var form2 = new Form2();
            form2.ShowDialog();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            var form3 = new Form3();
            form3.ShowDialog();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            var form4 = new Form4();
            form4.ShowDialog();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            var form5 = new Form5();
            form5.ShowDialog();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            var form6 = new Form6();
            form6.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
