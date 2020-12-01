using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_2_Challenges
{
    class GreeterUI
    {
        static void Main(string[] args)
        {
            string name;
            Greeter _greeterWindow = new Greeter();
            Console.WriteLine("Please tell me your name");       
            name = Console.ReadLine();
            _greeterWindow.Hello(name);
            _greeterWindow.Goodbye(name);
            _greeterWindow.Time();
            Console.ReadLine();
        }
    }
}
