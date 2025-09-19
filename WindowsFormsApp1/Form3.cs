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
            public string Name { get; set; }
            public string ImagePath { get; set; }
            public override string ToString() => Name;
        }

        private List<Animal> animals = new List<Animal>
        {
            new Animal { Name = "Mau,", ImagePath = "C:\\slike\\rex.jpg" },
            new Animal { Name = "Maza", ImagePath = "C:\\slike\\maza.jpg" }
           
        };

        public Form3()
        {
            InitializeComponent();
            listBox1.SelectedIndexChanged += ListBox1_SelectedIndexChanged;
            LoadAnimals();
        }

        private void LoadAnimals()
        {
            listBox1.Items.Clear();
            foreach (var animal in animals)
            {
                listBox1.Items.Add(animal);
            }
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem is Animal selectedAnimal)
            {
                pictureBox1.ImageLocation = selectedAnimal.ImagePath;
            }
            else
            {
                pictureBox1.Image = null;
            }
        }
    }
}
