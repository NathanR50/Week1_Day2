using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1_Day2
{
    class Program
    {
        static void Main(string[] args)
        {

            //What data types have we talked about so far?
            //int and strings
            //an int is a whole number
            //character

            char firstInitial = 'D';

            //declaring the names of the bools
            //default value is true

            bool isTired = true;

            //other number date types

            float number = 2.16242537293404673920377f;

            //float goes up to 7 numbers

            decimal partialNum = 2.16242537293404673920377m;

            double someNumber = 2.16242537293404673920377d;

            // double don't need the d


            Console.WriteLine(number);
            Console.WriteLine(partialNum);
            Console.WriteLine(someNumber);

            //operators

            // + adds two operands
            // - subtracts second operand first
            // * multiplies operands
            // / divides one operand by the other

            // % Modulus checks the remainder devides and checks remainder
            //++ increments operator by one and is used for ints 
            //-- decrements value by one
            // == checks if the values of gtwo operands are equal and if they are returns bool true
            //!= does the opposite of == checking if two operands are equal or not equal and if not returns bool true

            int jeryydAge = 29;
            int danielAge = 32;
            Console.WriteLine(jeryydAge == danielAge);






        }
    }
}
