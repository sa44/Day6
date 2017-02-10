using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{
    class Quiz
    {
        static int[] minIncomeArray = new int[]
            {20000, 30000, 40000, 80000,
            120000, 160000, 200000, 320000};
        static double[] taxRateArray = new double[]
            {0.02, 0.035, 0.07, 0.115,
            0.15, 0.17, 0.18, 0.20 };
        static int[] basePayableAmountArray = new int[]
            {0, 200,550, 3350,
            7950, 13950, 20750,42350};

        static void Main(string[] args)
        {
            int annualIncome = AskForIncome();
            int taxBracket = GetTaxBracket(annualIncome);
            double taxPayable =
                CalculateIncomeTax(annualIncome, taxBracket);
            PrintResult(annualIncome, taxPayable);
        }

        public static int AskForIncome()
        {
            Console.Write("Please enter your annual taxable income: ");
            string input = Console.ReadLine();
            return Convert.ToInt32(input);
        }

        public static int GetTaxBracket(int annualIncome)
        {
            //one of the way: go through the minIncomeArray from the end and 
            //return the index once the value in the array is smaller than the
            //annualIncome argument
            for (int i=minIncomeArray.Length - 1; i >= 0; i--)
            {
                if (minIncomeArray[i] < annualIncome)
                    return i;
            }
            return -1;
        }

        public static double CalculateIncomeTax(int annualIncome, int taxBracket)
        {
            if (taxBracket == -1) return 0;

            double payableTax = (annualIncome - minIncomeArray[taxBracket]) *
                taxRateArray[taxBracket] + basePayableAmountArray[taxBracket];

            return payableTax;
        }

        public static void PrintResult(int annualIncome, double taxPayable)
        {
            Console.WriteLine("For taxable annual income of ${0:#,##0.00}, the " +
                "tax payable amount is {1:C}", annualIncome, taxPayable);
        }
    }
}
