using System.Collections.Generic;

namespace WindowsFormsApp1
{
    public static class AnimalRepository
    {
        public static List<Animal> Animals { get; } = new List<Animal>();

        
        static AnimalRepository()
        {
            Animals.Add(new Animal { Name = "Mau", Vrsta = "Pas", Status = "Dostupan" });
            Animals.Add(new Animal { Name = "Maza", Vrsta = "Maèka", Status = "Udomljen" });
            Animals.Add(new Animal { Name = "Bobi", Vrsta = "Pas", Status = "Dostupan" });
        }
    }

    public class Animal
    {
        public string Name { get; set; }
        public string Vrsta { get; set; }
        public string Status { get; set; }
        public override string ToString() => $"{Name} ({Vrsta}, {Status})";
    }
}