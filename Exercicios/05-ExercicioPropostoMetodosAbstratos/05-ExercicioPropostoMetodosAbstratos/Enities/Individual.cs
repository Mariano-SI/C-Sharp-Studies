using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_ExercicioPropostoMetodosAbstratos.Enities
{
    internal class Individual : TaxPayer
    {
        public double HealthExpenditures { get; set; }


        public Individual(string name, double anualIncome, double healthExpenditures): base(name, anualIncome)
        {
            HealthExpenditures = healthExpenditures;
        }

        public override double Tax()
        {
            double tax = (AnualIncome < 20000) ? AnualIncome * 0.15 : AnualIncome * 0.25;

            if (HealthExpenditures > 0)
            {
                tax -= HealthExpenditures / 2;
            }

            return tax;
        }
    }
}
