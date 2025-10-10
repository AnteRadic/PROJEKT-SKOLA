using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace WindowsFormsApp1
{
    public static class AnimalRepository
    {
        // BindingList notifies bound controls when items are added/removed
        public static BindingList<Animal> Animals { get; } = new BindingList<Animal>();

        // Optional event if forms want an explicit notification
        public static event Action<Animal> AnimalAdded;

        public static void Add(Animal a)
        {
            Animals.Add(a);
            AnimalAdded?.Invoke(a);
        }

        static AnimalRepository()
        {
            Add(new Animal { Name = "Mau", Vrsta = "Pas", Status = "Dostupan" });
            Add(new Animal { Name = "Maza", Vrsta = "Maèka", Status = "Udomljen" });
            Add(new Animal { Name = "Bobi", Vrsta = "Pas", Status = "Dostupan" });
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