using Aula_HerancaPolimorfismo_Encapsulamento.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace Aula_HerancaPolimorfismo_Encapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {
            List<TaxPayer> list = new List<TaxPayer>();

            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Tax payer #{i} data:");
                Console.Write("Individual or company (i/c)? ");
                char ch = char.Parse(Console.ReadLine());

                if (ch == 'i')
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Anual income: ");
                    double annualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Health expenditures: ");
                    double healthExpenditures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    list.Add(new TaxPayerIndividual(name, annualIncome, healthExpenditures));
                }
                else
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Anual income: ");
                    double annualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Number of employees: ");
                    int numberEmployees = int.Parse(Console.ReadLine());

                    list.Add(new TaxPayerCompany(name, annualIncome, numberEmployees));
                }
            }

            Console.WriteLine();
            Console.WriteLine("TAXES PAID:");

            double TotalPax = 0.0;

            foreach(TaxPayer taxPayer in list)
            {
                Console.WriteLine($"{taxPayer.Name}: $ {taxPayer.TaxCalculate().ToString("F2", CultureInfo.InvariantCulture)}");
                TotalPax += taxPayer.TaxCalculate();
            }

            Console.WriteLine();
            Console.WriteLine("TOTAL TAXES: $ " + TotalPax.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
