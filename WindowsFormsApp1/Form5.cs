using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form5 : Form
    {
        private class Animal
        {
            public string Name { get; set; }
            public string Vrsta { get; set; }
            public string Pasmina { get; set; }
            public int Dob { get; set; }
            public override string ToString() => Name;
        }

        private List<Animal> animals = new List<Animal>
        {
            new Animal { Name = "Mau", Vrsta = "Pas", Pasmina = "Mješanac", Dob = 3 },
            new Animal { Name = "Maza", Vrsta = "Mačka", Pasmina = "Perzijska", Dob = 2 }
        };

        public Form5()
        {
            InitializeComponent();
            listBox1.SelectedIndexChanged += ListBox1_SelectedIndexChanged;
            button1.Click += Button1_Click;
            LoadAnimals();
        }

        private void LoadAnimals()
        {
            listBox1.Items.Clear();
            foreach (var animal in animals)
                listBox1.Items.Add(animal);
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem is Animal selectedAnimal)
            {
                textBox1.Text = selectedAnimal.Name;
                textBox2.Text = selectedAnimal.Dob.ToString();
                textBox3.Text = selectedAnimal.Vrsta;
                textBox4.Text = selectedAnimal.Pasmina;
            }
            else
            {
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string ime = textBox1.Text;
            string dob = textBox2.Text;
            string vrsta = textBox3.Text;
            string pasmina = textBox4.Text;
            string imeUdomitelja = textBox7.Text;
            string prezimeUdomitelja = textBox6.Text;
            string kontakt = textBox5.Text;
            DateTime datumUdomljavanja = dateTimePicker1.Value;

            MessageBox.Show(
                $"Životinja: {ime} ({vrsta}, {pasmina}, {dob} god.)\n" +
                $"Udomitelj: {imeUdomitelja} {prezimeUdomitelja}\n" +
                $"Kontakt: {kontakt}\n" +
                $"Datum udomljavanja: {datumUdomljavanja.ToShortDateString()}",
                "Potvrda udomljavanja",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }
    }
}
