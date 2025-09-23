using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form6 : Form
    {
       
        private class Animal
        {
            public string Name { get; set; }
            public string Vrsta { get; set; }
            public int Dob { get; set; }
            public bool Udomljen { get; set; }
        }

       
        private List<Animal> animals = new List<Animal>
        {
            new Animal { Name = "Mau", Vrsta = "Pas", Dob = 3, Udomljen = false },
            new Animal { Name = "Maza", Vrsta = "Mačka", Dob = 2, Udomljen = true },
            new Animal { Name = "Bobi", Vrsta = "Pas", Dob = 5, Udomljen = false }
        };

        public Form6()
        {
            InitializeComponent();
            this.Load += Form6_Load;
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            int ukupno = animals.Count;
            int prisutni = animals.Count(a => !a.Udomljen);
            int udomljeni = animals.Count(a => a.Udomljen);
            double prosjecnaDob = animals.Any() ? animals.Average(a => a.Dob) : 0;
            var poVrstama = animals
                .GroupBy(a => a.Vrsta)
                .Select(g => $"{g.Key}: {g.Count()}")
                .ToArray();

            
          

           
            label6.Text = ukupno.ToString();
            label7.Text = prisutni.ToString();
            label8.Text = udomljeni.ToString();
            label9.Text = prosjecnaDob.ToString("0.0");
            label10.Text = string.Join(", ", poVrstama);
        }
    }
}
