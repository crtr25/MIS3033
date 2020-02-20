using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> Results = new List<string>();
            //double L = 0;
            //double R = 0;
            int power = 0;
            string another = string.Empty;

            do
            {
                Equation EQ1 = new Equation();
                Console.WriteLine("Please enter your first number");
                EQ1.Left = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Please enter your second number");
                EQ1.Right = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Would you like to raise one of your numbers to a power? Y/N");
                string answer = Console.ReadLine().ToUpper();
                if (answer == "Y")
                {
                    Console.WriteLine("Which number do you want to raise a power to? First/Second");
                    string numberSelection = Console.ReadLine().ToLower();
                    if (numberSelection == "first")
                    {
                        Console.WriteLine($"What power do you want to raise {EQ1.Left.ToString("N2")} to?");
                        power = Convert.ToInt32(Console.ReadLine());
                        double LPower = EQ1.LeftToThePower(power);
                        string sentence = ($"{EQ1.Left.ToString("N2")} raised to the power of {power} = {LPower.ToString("N3")}");

                        Results.Add(sentence);
                      
                    }
                    else if (numberSelection == "second")
                    {
                        Console.WriteLine($"What power do you want to raise {EQ1.Right.ToString("N2")} to?");
                        power = Convert.ToInt32(Console.ReadLine());
                        double RPower = EQ1.RightToThePower(power);
                        string sentence = ($"{EQ1.Right.ToString("N2")} raised to the power of {power} = {RPower.ToString("N3")}");
                        Results.Add(sentence);
                    }
                }
                else
                {
                    Console.WriteLine("Would you like to add, subtract or multiply? +,-,*");
                    string methodChoice = Console.ReadLine();
                    if (methodChoice == "+")
                    {
                        double methodAnswer = EQ1.Add();
                        string sentence = ($"{EQ1.Left.ToString("N2")} {methodChoice} {EQ1.Right.ToString("N2")} = {methodAnswer.ToString("N2")}");
                        Results.Add(sentence);
                    }
                    else if (methodChoice == "-")
                    {
                        double methodAnswer = EQ1.Subtract();
                        string sentence = ($"{EQ1.Left.ToString("N2")} {methodChoice} {EQ1.Right.ToString("N2")} = {methodAnswer.ToString("N2")}");
                        Results.Add(sentence);
                    }
                    else if (methodChoice == "*")
                    {
                        double methodAnswer = EQ1.Multiply();
                        string sentence = ($"{EQ1.Left.ToString("N2")} {methodChoice} {EQ1.Right.ToString("N2")} = {methodAnswer.ToString("N2")}");
                        Results.Add(sentence);
                    }
                }

                Console.WriteLine("Do you wish to input another equation? Y/N");
                another = Console.ReadLine().ToUpper();
            } while (another == "Y");

            //for UI purposes
            Console.WriteLine("");
            Console.WriteLine("===================================================================");
            Console.WriteLine("");


            foreach (var item in Results)
            {
                Console.WriteLine(item);
            }







            Console.ReadKey();
        }
    }
}
