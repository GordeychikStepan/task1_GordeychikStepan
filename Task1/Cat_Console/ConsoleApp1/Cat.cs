using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	class Cat
	{
        private string name;
        private double weight;

        public string Name
        {
            get { return name; }
            set { SetCatName(value); }
        }
        public double Weight
        {
            get { return weight; }
            set { SetCatWeight(value); }
        }

        public Cat(string CatName, double CatWeight)
        {
            Name = CatName;
            Weight = CatWeight;
        }

		public void Meow ()
        {
			Console.WriteLine($"{name}: МЯЯЯЯУ!!!!");
		}

        public void GetCatWeight ()
        {
            Console.WriteLine($"У кота {name} - вес {weight}");
        }

        public void SetCatName (string CatName)
        {
            bool OnlyLetters = true;

            foreach (var ch in CatName)
            {
                if (!char.IsLetter(ch)) { OnlyLetters = false; }
            }

            if (OnlyLetters) name = CatName;
            else Console.WriteLine($"{CatName} - неправильное имя!!!");
        }

        private void SetCatWeight (double catWeight)
        {
            if (catWeight > 0) { weight = catWeight; } 
            else Console.WriteLine($"{catWeight} - неправильный вес!!!");
        }

    }
}
