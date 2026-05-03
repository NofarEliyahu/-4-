using System;

namespace ConsoleApp63
{
    // מחלקת אב - Animal
    public class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }

        // בנאי
        public Animal(string name, int age)
        {
            Name = name;
            Age = age;
        }

        // דריסה של ToString
        public override string ToString()
        {
            return $"Name: {Name}, Age: {Age}";
        }
    }

    // מחלקת Dog יורשת מ-Animal
    public class Dog : Animal
    {
        public Dog(string name, int age) : base(name, age)
        {
        }

        // פעולה של כלב
        public void Bark()
        {
            Console.WriteLine($"{Name} says: Woof woof!");
        }
    }

    // sealed = אי אפשר לרשת ממחלקת Cat
    public sealed class Cat : Animal
    {
        public Cat(string name, int age) : base(name, age)
        {
        }

        // פעולה של חתול
        public void Purr()
        {
            Console.WriteLine($"{Name} says: Purr...");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Animal[] animals =
            {
                new Dog("Rex", 3),
                new Cat("Mitsi", 2),
                new Dog("Lucky", 5),
                new Cat("Luna", 1)
            };

            PrintAnimals(animals);
        }

        // פונקציה סטטית שמקבלת מערך של חיות
        public static void PrintAnimals(Animal[] animals)
        {
            foreach (Animal animal in animals)
            {
                // הדפסת פרטי החיה באמצעות ToString
                Console.WriteLine(animal.ToString());

                // שימוש ב-as כדי לבדוק אם זו חיה מסוג Dog
                Dog dog = animal as Dog;

                if (dog != null)
                {
                    dog.Bark();
                }
                // שימוש ב-is כדי לבדוק אם זו חיה מסוג Cat
                else if (animal is Cat cat)
                {
                    cat.Purr();
                }

                Console.WriteLine();
            }
        }
    }
}