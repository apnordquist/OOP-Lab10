using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab10
{
    internal class RecursiveMath
    {
        //attributes
        //constructor
        //methods
        public int AdditionBetween(int num1, int num2) 
        {
            if (num1 < num2)
            {
                int result = 0; //create variable for result
                for (int i = num1; i <= num2; i++) //start at num1, end at num2
                {
                    result += i; //add each interation of for loop to the result
                }
                return result; //return the sum of all numbers between num1 and num2 (inclusive)
            }
            else 
            {
                int result = 0; //create variable for result
                for (int i = num2; i <= num1; i++) //start at num2, end at num1
                {
                    result += i; //add each interation of for loop to the result
                }
                return result; //return the sum of all numbers between num2 and num1 (inclusive)
            }
        }
        public int EvenDivision(int num) 
        { 
            int counter = 0; //create variable to count iterations
            while (num % 2 == 0) //check to see if even
            {
                num /= 2;
                counter++;
            }
            return counter; //return the number of times it can be evenly divided
        }
    }
}
