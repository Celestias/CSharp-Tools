using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MortgageCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CalculateBtn_Click(object sender, EventArgs e)
        {
            LAmountTb.Focus();
            double remaining_balance, preCalculated_Balance, loan_term, total_PaymentAmount = 0.00;
            double APR_rate, APR_monthly_rate, monthly_payment, monthly_Interest_Amount, monthly_AmortizationAmount_PerMonth;
            double APR_rate_Converted_ToPercent, monthly_PaymentTowardsInterest, monthly_PaymentTowardsPrinciple, current_balance;

            // Clear any existing data to begin a new calculation and commit all initial values entered by the user on the form to memory
            try
            {
                // Clear the mortgage schedule on each calculate click
                MortageSchedLb.Items.Clear();

                // Store the pre-calculated amount in a variable
                preCalculated_Balance = Convert.ToDouble(LAmountTb.Text);
                APR_rate = Convert.ToDouble(InterestRateTb.Text);

                // *IMPORTANT* Extract the monthly interest % rate -- Since all calculations will be based on a MONTHLY payment schedules interest percentage -- 
                // Source: http://www.myamortizationchart.com/articles/how-is-an-amortization-schedule-calculated/
                APR_monthly_rate = APR_rate / 12;

                // Convert the monthly interest rate into its percent interpretation to be used in the calculation
                APR_rate_Converted_ToPercent = APR_monthly_rate * .01;

                // Store the number of months of the loan term to be used in the calculation 
                loan_term = Convert.ToDouble(MonthlyTermCb.Text);

                // Extract the monthly payment amount based on the loan term without the interest:
                monthly_payment = preCalculated_Balance / loan_term;

                // Get the monthly payment amount with the interest added
                monthly_Interest_Amount = monthly_payment * APR_monthly_rate;

                // Set up initial and remaining loan values in memory to keep track of the balance during and throughout the loop
                current_balance = preCalculated_Balance;
                remaining_balance = preCalculated_Balance;                
                

                // Loop through the calculation until the payments made is equal to the loan term and the remaining balance has been paid off
                for (int payments_made = 0; payments_made <= loan_term - 1 && remaining_balance >= 0.00; payments_made++)                    
                    {
                        // Calculate the total monthly payment based on the amortization formula with interest -- Source: http://www.myamortizationchart.com/articles/how-is-an-amortization-schedule-calculated/
                        monthly_AmortizationAmount_PerMonth = (APR_rate_Converted_ToPercent * current_balance * Math.Pow(1 + APR_rate_Converted_ToPercent, loan_term)) / (Math.Pow(1 + APR_rate_Converted_ToPercent, loan_term) - 1);

                        // Calculate the total amount that goes to the interest
                        monthly_PaymentTowardsInterest = remaining_balance * APR_rate_Converted_ToPercent;

                        // Calculate the total amount that goes towards the principle for each payment
                        monthly_PaymentTowardsPrinciple = monthly_AmortizationAmount_PerMonth - monthly_PaymentTowardsInterest;

                        // Keep track of the total amount paid so far 
                        total_PaymentAmount += monthly_AmortizationAmount_PerMonth;
                        
                        // Deduct the principle paid, each time from the remaining balance and reassign as the new remaining balance
                        remaining_balance = remaining_balance - monthly_PaymentTowardsPrinciple;

                        // Keep track of the total amount paid so far                        

                        // Format and print out the schedule in the listbox
                        MortageSchedLb.Items.Add(payments_made + 1 + " Payment: " + (monthly_AmortizationAmount_PerMonth).ToString("C") + " Towards Interest: " +
                        monthly_PaymentTowardsInterest.ToString("C") + " Toward Principle: " + (monthly_PaymentTowardsPrinciple).ToString("C") + " Remaining Balance: " + (remaining_balance).ToString("C"));                        
                    }
                        // Assign the total amount that was paid back on the mortgage
                        TotalPaymentTb.Text = total_PaymentAmount.ToString("C");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ensure all fields contain whole numbers or decimal values:" + "\r" + "\n" + "\r" + "\n"
                                + "The following error occurred: " + "\r" + "\n" + ex);
            }
        }
    }
}
