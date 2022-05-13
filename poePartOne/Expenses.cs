//ST10085103
//PROG-POE-PART1
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace poePartOne
{
    internal abstract class Expenses
    {
        //EXPENSE ARRAY FIELD
        private double[] expenseArray;

        //CONSTRUCTOR SETUP
        public Expenses(double[] expenseArray) {
            this.expenseArray = expenseArray;
        }


        //METHOD CALCULATES AND RETURNS INITIAL EXPENSES
        public Double getInitialExpense()
        {
            double addedExpenses = 0;
            for (int i = 0; i<expenseArray.Length; i++) {
                addedExpenses = addedExpenses + expenseArray[i];
            }
            double initialExpense = addedExpenses;

            return initialExpense;
        }
    }
}
