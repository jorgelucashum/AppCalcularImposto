using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCalcularImposto.Entities
{
    // Conta de pessoa jurídica.
    class CompanyAccount : Account
    {
        public int EmployeeNumbers { get; set; }

        public CompanyAccount()
        {
        }

        public CompanyAccount(string name, double annualIncome, int employeeNumbers) : base(name, annualIncome)
        {
            EmployeeNumbers = employeeNumbers;
        }

        public override double Tax() // Método para retornar o valor do imposto pago anualmente de uma pessoa jurídica (override da classe abstrata 'Account').
        {
            double taxPercent = 0;

            if (EmployeeNumbers > 10) // Alterando o valor do imposto para 14% em empresas com mais de 10 funcionários.
            {
                taxPercent = 0.14;
            }
            else // Alterando o valor do imposto para 16% em empresas com menos de 10 funcionários.
            {
                taxPercent = 0.16;
            }

            return AnnualIncome * taxPercent;

        }

    }
}
