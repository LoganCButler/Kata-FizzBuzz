using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application;

namespace Kata_FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            for (var t = 0; t < 100; t++)
            {
              FizzBuzzLogic F = new FizzBuzzLogic();

               Console.WriteLine( F.FizzBuzzer(t+1));
            
            }
            Console.ReadLine();
        }
    }
}
