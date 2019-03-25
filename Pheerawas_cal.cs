using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter equation:");
            string input = Console.ReadLine();
            string[] splitInput = input.Split(' ');
            int index = char.IsLetter(splitInput[0].Replace(" ", "")[0]) ? 1 : 0;
            string sideWithEquation = splitInput[index];
            
            string[] equation = sideWithEquation.Split(' ');

            for (int i = 1; i < equation.Length - 1; i++)
            {
                string item = equation[i];
                int num = 0;
                switch (item)
                {
                    case "*":
                        num = Convert.ToInt32(equation[i - 1]) * Convert.ToInt32(equation[i + 1]);
                        break;
                    case "/":
                        num = Convert.ToInt32(equation[i - 1]) / Convert.ToInt32(equation[i + 1]);
                        break;
                }
                if (num > 0)
                {
                    equation[i - 1] = "";
                    equation[i] = "";
                    equation[i + 1] = num.ToString();
                }
            }

            equation = string.Join(" ", equation).Split(' ');
            for (int i = 1; i < equation.Length - 1; i++)
            {
                string item = equation[i];
                int num = 0;
                switch (item)
                {
                    case "+":
                        num = Convert.ToInt32(equation[i - 1]) + Convert.ToInt32(equation[i + 1]);
                        break;
                    case "-":
                        num = Convert.ToInt32(equation[i - 1]) - Convert.ToInt32(equation[i + 1]);
                        break;
                }
                if (num > 0)
                {
                    equation[i - 1] = "";
                    equation[i] = "";
                    equation[i + 1] = num.ToString();
                }
            }

            string total = string.Join("", equation);

            Console.WriteLine($"x = {int.Parse(total)}");

            Console.ReadKey();
        }


    }
}
