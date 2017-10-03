using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Human
{
    class Program
    {
        static void Main(string[] args)
        {
            Human dean = new Human();
            Human sam = new Human("Dave");

            dean.Age = 12;
            sam.Age = 14;

            dean.DisplayAge();
            sam.DisplayAge();

            string deanName = dean.NameMashup("Crawford");
            string samName = sam.NameMashup("Lewis");

            Console.WriteLine(samName);
            Console.WriteLine(deanName + " is " + dean.Age + " years old.");


            Animal dog = new Animal("Pepper", "Dog", "Brown");

            Console.WriteLine($"My name is {dog.Name} I am a {dog.Species} and my color is {dog.Color}");




            //LINQ
            var list = new List<string> { "Aang", "Megaman", "Homer", "Rick", "Summer", "Bob", "Louise", "Archer", "Stan", "Rodger", "Sozin" };

            //var namesThatStartWithS = list.Where(n => n.StartsWith("S"));
            var namesThatStartWithS = list.Where(x => x.StartsWith("S"));
            foreach (var name in namesThatStartWithS)
            {
                Console.WriteLine(name);
            }

            var namesThatContainW = list.Where(x => x.Contains("w"));
            Console.WriteLine($"Names that contain 'w': {namesThatContainW.Count()} ");















            Console.ReadKey();

            







                









        }
    }
}
