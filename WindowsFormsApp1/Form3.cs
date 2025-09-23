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
    public partial class Form3 : Form
    {
        // Example data structure for animals
        private class Animal
        {
            public string Ime { get; set; }
            public Image Slika { get; set; }
            public override string ToString() => Ime;
        }

        private List<Animal> animals = new List<Animal>();

        public Form3()
        {
            InitializeComponent();

            // Example data - replace with your actual data source
            animals.Add(new Animal { Ime = "Maza", Slika = Properties.Resources.maza }); 
            animals.Add(new Animal { Ime = "Mau", Slika = Properties.Resources.mau });   

            listBox1.DataSource = animals;
            listBox1.SelectedIndexChanged += ListBox1_SelectedIndexChanged;
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem is Animal selectedAnimal)
            {
                pictureBox1.Image = selectedAnimal.Slika;
            }
            else
            {
                pictureBox1.Image = null;
            }
        }
    }
}
