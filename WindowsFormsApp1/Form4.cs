using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form4 : Form
    {
        private class Animal
        {
            public string Name { get; set; }
            public string Vrsta { get; set; }
            public string Status { get; set; }
            public override string ToString() => $"{Name} ({Vrsta}, {Status})";
        }

        private List<Animal> animals = new List<Animal>
        {
            new Animal { Name = "Mau", Vrsta = "Pas", Status = "Dostupan" },
            new Animal { Name = "Maza", Vrsta = "Mačka", Status = "Udomljen" },
            new Animal { Name = "Bobi", Vrsta = "Pas", Status = "Dostupan" }
        };

        public Form4()
        {
            InitializeComponent();
            comboBox1.SelectedIndexChanged += ComboBox1_SelectedIndexChanged;
            button1.Click += Button1_Click;
            LoadComboBox();
            LoadListBox(animals);
        }

        private void LoadComboBox()
        {
     
            var filters = animals.Select(a => a.Vrsta).Distinct()
                .Concat(animals.Select(a => a.Status).Distinct())
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
                LoadListBox(animals);
            }
            else
            {
                var filtered = animals.Where(a => a.Vrsta == selected || a.Status == selected);
                LoadListBox(filtered);
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0; 
        }
    }
}
