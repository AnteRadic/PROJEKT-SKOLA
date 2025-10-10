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
            public string Status { get; set; }
            public override string ToString() => Name;
        }

        private static class AnimalRepository
        {
            public static List<Animal> Animals { get; } = new List<Animal>
            {
                new Animal { Name = "Mau", Vrsta = "Pas", Status = "Dostupan" },
                new Animal { Name = "Maza", Vrsta = "Mačka", Status = "Dostupan" }
            };
        }

        public Form5()
        {
            InitializeComponent();
            listBox1.SelectedIndexChanged += ListBox1_SelectedIndexChanged;
            button1.Click += Button1_Click;

           
            listBox1.DataSource = AnimalRepository.Animals;
            listBox1.DisplayMember = "Name";
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem is Animal selectedAnimal)
            {
                textBox1.Text = selectedAnimal.Name;
                textBox3.Text = selectedAnimal.Vrsta;
                
                textBox2.Text = "";
                textBox4.Text = "";
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
            
            if (listBox1.SelectedItem is Animal selectedAnimal)
            {
                string imeUdomitelja = textBox7.Text;
                string prezimeUdomitelja = textBox6.Text;
                string kontakt = textBox5.Text;
                DateTime datumUdomljavanja = dateTimePicker1.Value;

                selectedAnimal.Status = "Udomljen";

              
                Form4.RefreshAllForm4Instances();

                MessageBox.Show(
                    $"Životinja: {selectedAnimal.Name} ({selectedAnimal.Vrsta})\n" +
                    $"Udomitelj: {imeUdomitelja} {prezimeUdomitelja}\n" +
                    $"Kontakt: {kontakt}\n" +
                    $"Datum udomljavanja: {datumUdomljavanja.ToShortDateString()}",
                    "Potvrda udomljavanja",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            else
            {
                MessageBox.Show("Nije odabrana životinja.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Form5_Load(object sender, EventArgs e)
        {

            }
    }
}
