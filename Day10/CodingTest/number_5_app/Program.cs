using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace number_5_app
{
    internal class Program
    {
        interface IAnimal
        {
            void Eat();
            void Sleep();
            void Sound();
        }

        class Dog : IAnimal 
        {
            public string Name { get; set; }
            public int Age { get; set; }

            public void Eat()
            {
                Console.WriteLine($"{Name}이(가) 먹습니다.");
            }

            public void Sleep()
            {
                Console.WriteLine($"{Name}이(가) 잡니다.");
            }

            public void Sound()
            {
                Console.WriteLine($"{Name}이(가) 짖습니다.");
            }
        }

        class Cat : IAnimal
        {
            public string Name { get; set; }
            public int Age { get; set; }

            public void Eat()
            {
                Console.WriteLine($"{Name}이(가) 먹습니다.");
            }

            public void Sleep()
            {
                Console.WriteLine($"{Name}이(가) 잡니다.");
            }

            public void Sound()
            {
                Console.WriteLine($"{Name}이(가) 웁니다.");
            }
        }

        class Horse : IAnimal
        {
            public string Name { get; set; }
            public int Age { get; set; }

            public void Eat()
            {
                Console.WriteLine($"{Name}이(가) 먹습니다.");
            }

            public void Sleep()
            {
                Console.WriteLine($"{Name}이(가) 잡니다.");
            }

            public void Sound()
            {
                Console.WriteLine($"{Name}이(가) 웁니다.");
            }
        }

        static void Main(string[] args)
        {
            Dog dog = new Dog() {Name = "강아지", Age = 12};
            Console.WriteLine($"{dog.Name}은(는) {dog.Age}살 입니다.");
            dog.Eat();
            dog.Sleep();
            dog.Sound();
            Console.WriteLine("");

            Cat cat = new Cat() { Name = "고양이", Age = 10 };
            Console.WriteLine($"{cat.Name}은(는) {cat.Age}살 입니다.");
            cat.Eat();
            cat.Sleep();
            cat.Sound();
            Console.WriteLine("");

            Horse horse = new Horse() { Name = "망아지", Age = 8 };
            Console.WriteLine($"{horse.Name}은(는) {horse.Age}살 입니다.");
            horse.Eat();
            horse.Sleep();
            horse.Sound();
        }
    }
}
