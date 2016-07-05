using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    public class FizzBuzzLogic
    {
        int fizzBase = 3;
        int buzzBase = 5;
        

        internal bool FizzChecker(int check)
        {
            return 0 == check % fizzBase;
        }

        internal bool BuzzChecker(int check)
        {
            return 0 == check % buzzBase;
        }


        public string   FizzBuzzer(int input)
        {
            string output = input.ToString();

            if (FizzChecker(input))
            {
                output =  "Fizz";
            }
            
            if (BuzzChecker(input))
            {
                output = "Buzz";
            }

            if(FizzChecker(input) && BuzzChecker(input))
            {
                output = "FizzBuzz";
            }

           
            return output;

        }
    }
}
