﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace subtracao
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1, num2;

            string read;

            bool repeat = true;

            while (repeat)
            {

                Console.WriteLine(".:Este programa faz a subtração de números:.");

                Console.WriteLine("Digite o primeiro número para calcular: ");
                read = Console.ReadLine();
                num1 = int.Parse(read);

                Console.WriteLine("Digite o segundo número para calcular: ");
                read = Console.ReadLine();
                num2 = int.Parse(read);

                double result;

                result = num1 - num2;

                Console.WriteLine("A subtração foi: {0} - {1} = {2}", num1, num2, result);

                Console.Write("Deseja somar outro valor? Y/N: ");
                string go = Console.ReadLine();
                if (go.ToUpper() != "Y")
                {
                    repeat = false;
                }
            }
        }
    }
}
