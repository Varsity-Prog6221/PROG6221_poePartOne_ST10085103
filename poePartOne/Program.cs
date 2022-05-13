//ST10085103
//PROG-POE-PART1
using System;

namespace poePartOne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //INPUT FOR GROSS INCOME & TAX-DETUCTABLE
            Console.WriteLine("Enter Gross monthly income (before deductions)");
            double grossIncome = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Estimated monthly tax deducted");
            double taxDeducted = Convert.ToDouble(Console.ReadLine());
            
            //INPUTS FOR EACH EXPENSE
            double[] expenseArray = new double[5];
            Console.WriteLine("Enter Estimated monthly expenditures for the following categories: ");
            Console.WriteLine("Groceries: ");
            expenseArray[0] = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Water and lights: ");
            expenseArray[1] = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Travel costs (including petrol): ");
            expenseArray[2] = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Cell phone and telephone: ");
            expenseArray[3] = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Other expenses: ");
            expenseArray[4] = Convert.ToDouble(Console.ReadLine());


            //DECISION: Rent or Buy?
            Console.WriteLine("Do you want to rent accomodation or buy property? Press 'r' to rent, any key to buy.");
            String rentOrBuy = Console.ReadLine();
            //if RENTING PROPERTY
            if (rentOrBuy == "r")
            {
                Console.WriteLine("Enter monthly rental amount: ");
                double monthlyRental = Convert.ToDouble(Console.ReadLine());

                //CREATE RENTING CLASS INSTANCE
                Renting obj = new Renting(expenseArray, monthlyRental);
                obj.getInitialExpense();
                obj.getMonthlyRental();

                //CALCULATES THEN DISPLAYS AVAILABLE MONEY
                double availableMoney = grossIncome - (obj.getInitialExpense() + obj.getMonthlyRental() + taxDeducted);
                Console.WriteLine("\nThe available monthly money is: R" + availableMoney);
            }
            //if BUYING PROPERTY (HOMELOANS)
            else
            {
                Console.WriteLine("Enter enter the following values for a home loan: ");
                Console.WriteLine("Enter Purchase price of the property: ");
                double purchasePrice = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter Total deposit: ");
                double totalDeposit = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter Interest rate (percentage): ");
                double interestRate = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter Number of months to repay (between 240 and 360): ");
                int numMonths = Convert.ToInt32(Console.ReadLine());

                //CREATE HOMELOANS CLASS INSTANCE
                HomeLoan obj2 = new HomeLoan(expenseArray, purchasePrice, totalDeposit, interestRate, numMonths);
                double HomeLoanRepayment = obj2.HomeLoanRepayment();


                //ASSESS CHANCE OF HOMELOAN APPROVAL
                if (HomeLoanRepayment > (grossIncome*0.33)) {
                    Console.WriteLine("\nApproval of the Home Loan is unlikely.");
                }


                //CALCULATES THEN DISPLAYS AVAILABLE MONEY
                double availableMoney2 = grossIncome - (obj2.getInitialExpense() + HomeLoanRepayment + taxDeducted);
                Console.WriteLine("\nThe available monthly money is: R" +availableMoney2);
            }
        }
    }
}
