//ST10085103
//PROG-POE-PART1
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poePartOne
{
    internal class HomeLoan : Expenses
    {
        double[] expenseArray;
        double purchasePrice;
        double totalDeposit;
        double interestRate;
        int numMonths;

        //Constructor
        public HomeLoan(double[] expenseArray, double purchasePrice, double totalDeposit, double interestRate, int numMonths)
            : base (expenseArray) {

            this.expenseArray = expenseArray;
            this.purchasePrice = purchasePrice;
            this.totalDeposit = totalDeposit;
            this.interestRate = interestRate;
            this.numMonths = numMonths;
        }

        //Calculates Homeloan Monthly Repayment
        public Double HomeLoanRepayment() {
            double calc1 = purchasePrice - totalDeposit;
            double calc2 = interestRate / (double)100;
            double calc3 = (1 + calc2 * ((double)numMonths/(double)12));
            double calc4 = calc1 * calc2;

            return calc4;
        }
    }
}
