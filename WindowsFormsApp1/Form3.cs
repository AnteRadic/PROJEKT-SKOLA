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

            
            listBoxAnimals.DataSource = AnimalRepository.Animals;
            listBoxAnimals.DisplayMember = "Name";
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxAnimals.SelectedItem is Animal selectedAnimal)
            {
                pictureBox1.Image = selectedAnimal.Slika;
            }
            else
            {
                pictureBox1.Image = null;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
