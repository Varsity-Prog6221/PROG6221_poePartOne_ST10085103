//ST10085103
//PROG-POE-PART1
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace poePartOne
{
    internal class Renting : Expenses
    {
        //CLASS FIELDS
        private double[] expenseArray;
        private double monthlyRental;

        //CONSTRUCTOR
        public Renting(double[] expenseArray, double monthlyRental)
            : base(expenseArray)
        {
            this.expenseArray = expenseArray;
            this.monthlyRental = monthlyRental;
        }

        //METHOD RETURNS MONTHLY RENT COST
        public Double getMonthlyRental() {
            return monthlyRental;
        }
    }
}
