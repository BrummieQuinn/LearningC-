using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningC_
{
   public class Exercise2
    {
      public void Run()
        {
            int number1 = 12;
            int number2 = 150;
            int remainder = number2 % number1;

            Console.WriteLine(remainder);

            //reassign number1 with 30

            number1 = 30;
            remainder = number2 % number1;

            Console.WriteLine(remainder);
            // when int number1 = 12; remainder = 6
            //when int number1 = 30; remainder = 0
            Console.ReadLine(); 
        }
    }
}
