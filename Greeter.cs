using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_2_Challenges
{
    class Greeter
    {
        public void Hello(string name)
        {
            Console.WriteLine("Hello " + name);
        }
        public void Goodbye(string name)
        {
            Console.WriteLine("Goodbye " + name);
        }

        public void Time()
        {

            int hour = DateTime.Now.Hour;


            if (hour >= 1 && hour <= 12)
            {
                Console.WriteLine("Good morning");
            }
            if (hour >= 13 && hour <= 18)
            {
                Console.WriteLine("Good afternoon");
            }
            if (hour >= 19 && hour <= 20)
            {
                Console.WriteLine("Good evening");
            }
            if (hour >= 21)
            {
                Console.WriteLine("Good night");
            }





        }
    }
    

}


    