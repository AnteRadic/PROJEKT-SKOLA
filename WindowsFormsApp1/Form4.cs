using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            comboBox1.SelectedIndexChanged += ComboBox1_SelectedIndexChanged;
            button1.Click += Button1_Click;
            LoadComboBox();
            
            AnimalRepository.Animals.Add(new Animal { Name = "Novi", Vrsta = "Pas", Status = "Dostupan" });
        }

        private void LoadComboBox()
        {
            var filters = AnimalRepository.Animals.Select(a => a.Vrsta).Distinct()
                .Concat(AnimalRepository.Animals.Select(a => a.Status).Distinct())
                .Distinct()
                .ToList();
            filters.Insert(0, "Svi");
            comboBox1.DataSource = filters;
        }

        private void LoadListBox(IEnumerable<Animal> list)
        {
            listBox1.Items.Clear();
            foreach (var animal in list)
                listBox1.Items.Add(animal);
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected = comboBox1.SelectedItem.ToString();
            if (selected == "Svi")
            {
                LoadListBox(AnimalRepository.Animals);
            }
            else
            {
                var filtered = AnimalRepository.Animals.Where(a => a.Vrsta == selected || a.Status == selected);
                LoadListBox(filtered);
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0; 
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        public void RefreshAnimals()
        {
            LoadComboBox();
            LoadListBox(AnimalRepository.Animals);
        }

        public static void RefreshAllForm4Instances()
        {
            foreach (Form f in Application.OpenForms)
            {
                if (f is Form4 form4)
                    form4.RefreshAnimals();
            }
        }
    }
}
