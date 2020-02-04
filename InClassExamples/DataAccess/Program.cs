﻿//Clinton Carter
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1, num2, num3, num4;
            num1 = 51;
            num2 = 785;
            num3 = 83;
            num4 = 98;

            double result = Add(num1, num2);
            Console.WriteLine($"{num1} + {num2} = {result}");

            result = Subtract(num3, num4);
            Console.WriteLine($"{num3} - {num4} = {result}");

            double[] allTheNumbers = new double[5];
            allTheNumbers[0] = 1;
            allTheNumbers[1] = 4;
            allTheNumbers[2] = 5;
            allTheNumbers[3] = 10;
            allTheNumbers[4] = 20;

            result = Add(allTheNumbers);
            Console.WriteLine(result);

            Console.ReadKey();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="val1">Left hand operand</param>
        /// <param name="val2">right hand operand</param>
        /// <returns>summation of the first value and second value</returns>
        static public double Add(double val1, double val2)
        {
            return val1 + val2;
        }

        static double Add(double[] values)
        {
            double sum = 0;
            int counter = 0;
            //while
            while (counter < values.Length)
            {
                sum += values[counter];
                counter++;
            }

            //for
            sum = 0;
            for (counter = 0; counter < values.Length; counter++)
            {
                sum += values[counter];
            }

            //foreach
            sum = 0;
            foreach (var item in values)
            {
                sum += item;
            }

            return sum;
        }
        static double Subtract(double val1, double val2)
        {
            return val1 - val2;
        }

        static void DatabaseStuff()
        {
        }
    }   
}
