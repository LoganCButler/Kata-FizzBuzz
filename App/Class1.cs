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
            bool isFizz = FizzChecker(input);
            bool isBuzz = BuzzChecker(input);

            if (isFizz)
            {
                output =  "Fizz";
            }
            
            if (isBuzz)
            {
                output = "Buzz";
            }

            if(isFizz && isBuzz)
            {
                output = "FizzBuzz";
            }

           
            return output;

        }
    }
}
