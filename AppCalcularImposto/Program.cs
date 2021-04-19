using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AppCalcularImposto.Entities;

namespace AppCalcularImposto
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Account> accounts = new List<Account>();

            Console.WriteLine("Digite a quantidade de pessoas que deseja saber o valor que foi pago em impostos no ano: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++) // Criando uma lista de tamanho 'n'.
            {
                Console.WriteLine("Pessoa #" + i);
                Console.Write("Pessoa física ou jurídica (f/j): ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string name = Console.ReadLine();
                Console.Write("Gasto anual: ");
                double annualIncome = double.Parse(Console.ReadLine());

                if (ch == 'f') // Adicionanado uma lista do tipo 'IndividualAccount'.
                {
                    Console.Write("Gasto com saúde: ");
                    double healthExpenditures = double.Parse(Console.ReadLine());
                    accounts.Add(new IndividualAccount(name, annualIncome, healthExpenditures));
                }
                else if (ch == 'j') // Adicionanado uma lista do tipo 'CompanyAccount'.
                {
                    Console.Write("Quantidade de funcionários: ");
                    int employeeNumber = int.Parse(Console.ReadLine());
                    accounts.Add(new CompanyAccount(name, annualIncome, employeeNumber));
                }
            }

            double sum = 0; // Variável acumulativa.

            Console.WriteLine("\nImpostos pago no ano: ");
            foreach (Account account in accounts)
            {
                sum += account.Tax(); // Somando todos os impostos.
                Console.WriteLine(account.Name + ": R$ " + account.Tax().ToString("F2"));
            }

            Console.Write("\nTotal de impostos: R$ " + sum.ToString());


            Console.ReadLine(); // Fim.
        }
    }
}
