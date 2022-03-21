using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalTask3
{
    internal class Program
    {
        public class Animal
        {
            protected string nameOfAnimal;
            protected string habitat_area;
            public string sound;
            protected int weight;
            protected int height;
            public Animal()
            {
                this.nameOfAnimal = "deafult name";
                this.habitat_area = "default area";
                this.sound = "default sound";
                this.weight = 100;
                this.height = 100;
            }
            public string name
            {
                get { return nameOfAnimal; }
                set { nameOfAnimal = value; }
            }
            public string area
            {
                get { return habitat_area; }
                set { habitat_area = value; }
            }
            public string Sound
            {
                get { return sound; }
                set { sound = value; }
            }
            public int Weight
            {
                get { return weight; }
                set { weight = value; }
            }
            public int Height
            {
                get { return height; }
                set { height = value; }
            }
            public string getInformation()
            {
                string temp = this.nameOfAnimal + this.habitat_area + this.sound;
                return temp;
            }
            public void vocalize()
            {
                Console.WriteLine(this.sound);
            }

        }

        public class Cow:Animal
        {
           this.sound="moo";
        }
        public class Chicken:Animal
        {
            this.sound="buck buck";
        }
        public class Cat:Animal
        {
            this.sound = "meow";
        }

        static void Main(string[] args)
        {
        }
    }
}
