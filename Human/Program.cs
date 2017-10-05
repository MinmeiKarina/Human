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
            Human sam = new Human("Sami");

            dean.Age = 18;
            sam.Age = 19;

            dean.DisplayAge();
            sam.DisplayAge();

            string deanName = dean.NameMashup("Romolino");
            string samName = sam.NameMashup("Cloutier");

            Console.WriteLine(samName + " is " + sam.Age + " years old.");
            Console.WriteLine(deanName + " is " + dean.Age + " years old.");


            Animal dog = new Animal("Pepper", "Dog", "Brown");

            Console.WriteLine($"My name is {dog.Name} I am a {dog.Species} and my color is {dog.Color}");




            //LINQ
            var list = new List<string> { "Aang", "Megaman", "Homer", "Rick", "Summer", "Bob", "Louise", "Archer", "Stan", "Rodger", "Sozin", "Grace", "Sami", "Maryn", "Bassam" };

            //var namesThatStartWithS = list.Where(n => n.StartsWith("S"));
            var namesThatStartWithS = list.Where(x => x.StartsWith("S"));
            foreach (var name in namesThatStartWithS)
            {
                Console.WriteLine(name);
            }

            var namesThatContainS = list.Where(x => x.Contains("s"));
            Console.WriteLine($"Names that contain 's': {namesThatContainS.Count()} ");

            var firstNameWithC = list.First(x => x.Contains("c"));
            Console.WriteLine($"First name that contains the letter 'c' is: {firstNameWithC}");

            var firstOrDefaultNameWith15Letters = list.FirstOrDefault(n => n.Length >= 15);
            Console.WriteLine($"Name with 15 letters or more: {firstOrDefaultNameWith15Letters}");

            var onlyNameWithZ = list.Single(n => n.Contains('z'));
            Console.WriteLine($"The only name with the letter z is: {onlyNameWithZ}");

            var onlyNameWithD = list.SingleOrDefault(n => n.Contains('d'));
            Console.WriteLine($"The only name that contains the letter 'd': {onlyNameWithD}");


            //Select and Select Many




















            //Collections
            //Arrays
            int[] odds = new int[5];
            

            int nextOddSlot = 0;
            for (int i = 0; i < 10; i++)
            {
                if (i % 2 != 0)
                {
                    odds[nextOddSlot] = i;
                    nextOddSlot += 1;
                }

            }

           

            int[] numbers = new int[] { 1, 3, 2, 4, 9, 20, 83, 88, 10, -2, -3 };

            for (int i = 0; i < numbers.Length; i++)
            {
                int largestNumberPosition = i;

                for (int j = 1; j < numbers.Length; j++)
                {
                    if (numbers[j] > numbers[largestNumberPosition])
                    {
                        largestNumberPosition = j;
                    }
                }

                int temp = numbers[i];
                numbers[i] = numbers[largestNumberPosition];
                numbers[largestNumberPosition] = temp;
            }

            foreach (var number in numbers)
            {
                Console.Write($"{number} ");
            }


            //Lists
            List<string> names = new List<string> { "Maryn", "Grace" };
            names.Add("Miranda");
            names.Add("Faith");

            List<string> myNames = new List<string> { "Sam", "Donn", "Micky", "Ramez" };
            names.AddRange(myNames);









            Console.ReadKey();

            







                









        }
    }
}
