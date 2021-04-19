using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCalcularImposto.Entities
{
    // Conta de pessoa física.
    class IndividualAccount : Account
    {
        public double HealthExpenditures { get; set; }

        public IndividualAccount()
        {
        }
        public IndividualAccount(string name, double annualIncome, double healthExpenditures) : base(name, annualIncome)
        {
            HealthExpenditures = healthExpenditures;
        }

        public override double Tax() // Método para retornar o valor do imposto pago anualmente de um pessoa física (override da classe abstrata 'Account').
        {
            double taxPercent = 0;
            double healthDiscount = HealthExpenditures * 0.5;

            if (AnnualIncome < 20000.00 ) // Imposto recebendo 15% para ganhos anuais menor do que 20.000,00.
            {
                taxPercent = 0.15;
            }
            else // Imposto recebendo 25% para ganhos anuais maior do que 20.000,00.
            {
                taxPercent = 0.25;
            }

            double tax = AnnualIncome * taxPercent;

            if (HealthExpenditures > 0) // Implementando desconto caso tenha gastos com saúde.
            {
                return tax - healthDiscount; 
            } 
            else
            {
                return tax;
            }

        }
    }
}
