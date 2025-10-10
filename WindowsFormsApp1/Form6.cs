using System;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
            this.Load += Form6_Load;
            
            AnimalRepository.AnimalAdded += OnAnimalAdded;
        }

        private void OnAnimalAdded(Animal a)
        {
            
            if (InvokeRequired) Invoke((Action)RefreshStats);
            else RefreshStats();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            RefreshStats();
        }

        private void RefreshStats()
        {
            var animals = AnimalRepository.Animals;
            int ukupno = animals.Count;
            int udomljeni = animals.Count(a => string.Equals(a.Status, "Udomljen", StringComparison.OrdinalIgnoreCase));
            int prisutni = ukupno - udomljeni;

          
            string prosjecnaDob = "N/A";

            var poVrstama = animals
                .GroupBy(a => a.Vrsta)
                .Select(g => $"{g.Key}: {g.Count()}")
                .ToArray();

            label6.Text = ukupno.ToString();
            label7.Text = prisutni.ToString();
            label8.Text = udomljeni.ToString();
            label9.Text = prosjecnaDob;
            label10.Text = string.Join(", ", poVrstama);
        }
    }
}
