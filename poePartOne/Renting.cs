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
        double[] expenseArray;
        double monthlyRental;

        //Constructor
        public Renting(double[] expenseArray, double monthlyRental)
            : base(expenseArray)
        {
            this.expenseArray = expenseArray;
            this.monthlyRental = monthlyRental;
        }

        //Method Returns Monthly Rent Cost
        public Double getMonthlyRental() {
            return monthlyRental;
        }
    }
}
