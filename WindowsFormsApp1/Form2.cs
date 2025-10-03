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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            button1.Click += Button1_Click;
            pictureBox1.Click += PictureBox1_Click;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
         
            string ime = textBox3.Text;
            string vrsta = textBox2.Text;
            string pasmina = textBox1.Text;
            string spol = radioButton1.Checked ? "M" : (radioButton2.Checked ? "Ž" : "");
            int dob = (int)numericUpDown1.Value;
            DateTime datumDolaska = dateTimePicker1.Value;
            bool cjepljen = checkBox1.Checked;
            bool kastriran = checkBox2.Checked;
            string napomena = textBox4.Text;

            

            MessageBox.Show(
                $"Ime: {ime}\nVrsta: {vrsta}\nPasmina: {pasmina}\nSpol: {spol}\nDob: {dob}\nDatum dolaska: {datumDolaska.ToShortDateString()}\nCjepljen: {cjepljen}\nKastriran: {kastriran}\nNapomena: {napomena}",
                "Podaci o životinji",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = openFileDialog1.FileName;
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
