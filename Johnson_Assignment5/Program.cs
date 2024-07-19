using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountInterestRates_Assignment
{
    /*This program calculates interest rates on accounts
     * with different percentage interest*/
    public class SavingsAccount
    {
        //declaring variables
        static double annualInterestRate;
        private double savingsBalance;
        private string savingsAccountName;


        public void SetSavingsAccountName(string n) //mutator method assigns new value to savingsAccountName
        {
            this.savingsAccountName = n;
        }

        public string GetSavingsAccountName() //accessor method retrieves name of savingsAccountName
        {
            return this.savingsAccountName;
        }

        public void SetSavingsBalance(double b)
        {
            this.savingsBalance = b;
        }

        public double GetSavingsBalance()
        {
            return this.savingsBalance;
        }


        public SavingsAccount() //constructor 1 sets savingsBalance = 0 and savingsAccountName to an empty string
        {
            this.savingsBalance = 0;
            this.savingsAccountName = "";
        }

        public SavingsAccount(double b, string n) //constructor 2 and sets each to their respected variables
        {
            SetSavingsBalance(b);
            SetSavingsAccountName(n);
        }
    
        public void CalculateMonthlyInterest()
        {
            savingsBalance += savingsBalance * (annualInterestRate / 12); //calculation for monthly interest
        }

        public static void SetAnnualInterestRate(double annualRate) //method returns annualInterestRate void
        {
            annualInterestRate = annualRate;
        }
 
        public double GetAnnualInterestRate() //allows for print to retrieve annualInterestReate
        {
            return annualInterestRate;
        }


        public void PrintSavingsAccount()
        {
            Console.WriteLine("{0,-20}{1,4}{2,17}", GetSavingsAccountName(), 
                GetSavingsBalance(), GetAnnualInterestRate()); //structures information gathered into rows and columns
        }
            

    
    }

    public class SavingAccountsTest
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("This program was made by Brandon Johnson for CSIS 209-D01");
            SavingsAccount saver1 = new SavingsAccount(2000.0, "Saver_One"); //saver 1 and 2 assigned amounts, saver 3 is empty string
            SavingsAccount saver2 = new SavingsAccount(3000.0, "Saver_Two");
            SavingsAccount saver3 = new SavingsAccount();

            SavingsAccount.SetAnnualInterestRate(0.04); //Sets rate to 4% (0.04)/
            saver3.SetSavingsAccountName("Saver_Three");//Calls setSavingsAccountName and makes sarver3 "Sarver_Three"
            saver3.SetSavingsBalance(50000.0); //Assigns sarver 3 an amount

            Console.WriteLine("Initial Savings account balances: "); //First group of information
            saver1.PrintSavingsAccount();
            saver2.PrintSavingsAccount();
            saver3.PrintSavingsAccount();

            saver1.CalculateMonthlyInterest();
            saver2.CalculateMonthlyInterest();
            saver3.CalculateMonthlyInterest();

            Console.WriteLine("Saving account balance after calculating monthly interest at 4%: "); //Second group of information with 4% interest
            saver1.PrintSavingsAccount();
            saver2.PrintSavingsAccount();
            saver3.PrintSavingsAccount();

            SavingsAccount.SetAnnualInterestRate(0.05);

            Console.WriteLine("Saving account balance after calculating monthly interest at 5%: "); //Third group of information with 5% interest
            saver1.PrintSavingsAccount();
            saver2.PrintSavingsAccount();
            saver3.PrintSavingsAccount();

            Console.Write("Press the [enter] key to quit...");
            Console.ReadLine();
        }
    }

}
