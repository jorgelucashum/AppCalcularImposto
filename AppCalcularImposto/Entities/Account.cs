using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCalcularImposto.Entities
{
    abstract class Account // Classe abstrata.
    {
        public string Name { get; set; }
        public double AnnualIncome { get; set; }

        public Account()
        {
        }
        public Account(string name, double annualIncome)
        {
            Name = name;
            AnnualIncome = annualIncome;
        }


        public abstract double Tax(); // Método abstrato.




    }
}
