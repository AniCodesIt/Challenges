using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1
{
    class Program
    {
        static void Main(string[] args)
        {
            string fName = "Ani";
            string lName = "Kulka";
            int age = 105;

            string[] movies = { "Valhalla Rising", "Us", "Syriana", "The Birdcage" };

            List<DateTime> dates = new List<DateTime>();
            dates.Add(DateTime.Today);
            dates.Add(DateTime.Parse("Jan 1, 2009"));


            Console.WriteLine("my age is " + age.ToString());
            int temp = age + 7;
            Console.WriteLine("my age plus 7 is " + temp.ToString());
            temp = age - 7;
            Console.WriteLine("my age minus 7 is " + temp.ToString());
            temp = age * 7;
            Console.WriteLine("my age times 7 is " + temp.ToString());
            temp = age / 7;
            Console.WriteLine("my age divided by 7 is " + temp.ToString());
            temp = age % 7;
            Console.WriteLine("my age modulo 7 is " + temp.ToString());

            string range = null;
            switch (range)
            {
                case ":(":
                    {
                        Console.WriteLine("Man, that sucks!");
                        break;
                    }
                case "Bad":
                    {
                        Console.WriteLine("Ouch, sorry to hear that");
                        break;
                    }
                case "Okay":
                    {
                        Console.WriteLine("Meh, alright");
                        break;
                    }
                case "Good":
                    {
                        Console.WriteLine("Cool!");
                        break;
                    }
                case "Great":
                    {
                        Console.WriteLine("Hurray!");
                        break;
                    }

                default:
                    {
                        Console.WriteLine("Well, how was it?");
                        break;
                    }
            }

            Dictionary<int, string> myDictionary = new Dictionary<int, string>();


            myDictionary.Add(10, "Wow, thats a lot of sleep!");
            myDictionary.Add(8, "You should be pretty rested");
            myDictionary.Add(4, "Bummer");
            myDictionary.Add(0, "Oh man, get some sleep!");            
            

            int theirNumber = 3;

            foreach (KeyValuePair<int, string> sleep in myDictionary)
            {
                if (theirNumber >= sleep.Key)
                {
                    Console.WriteLine(sleep.Value);
                    break;
                }

            }

            Console.ReadLine();
        }
    }
}
