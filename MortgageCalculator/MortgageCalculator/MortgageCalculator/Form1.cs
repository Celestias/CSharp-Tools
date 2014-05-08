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
            double starting_balance, calculated_balance, loan_term;
            double interest_paid, APR_rate, APR_percent, principle_paid, monthly_payment;
            int payments_made; //Set up the payment counter variable to keep track of how many payments have been made.

            try
            {
                MortageSchedLb.Items.Clear();
                calculated_balance = Convert.ToDouble(LAmountTb.Text);
                APR_rate = Convert.ToDouble(InterestRateTb.Text);
                // Convert the user interest percentage into a format suitable for the calculation 
                APR_percent = APR_rate * .01;
                loan_term = Convert.ToDouble(MonthlyTermCb.Text);
                //total_payment_count = (int)LTermUd.Value;

                // assign the payment counter a default value
                payments_made = 1;

                // Gets the monthly payment amount based on the loan term:
                monthly_payment = (calculated_balance / loan_term);

                while (calculated_balance > 0.0 && payments_made <= loan_term)
                {                    
                    starting_balance = calculated_balance;

                    // Calculate the interest amount by multiplying the starting balance by .10 divided by the monthly plan that is chosen
                    interest_paid = starting_balance * (APR_percent / loan_term);

                    // Subtract the interest from the payment to get the principle amount
                    principle_paid = monthly_payment - interest_paid;

                    // Subtract the last payment from the balance, less the principle that has been paid
                    calculated_balance = starting_balance - principle_paid;

                    // If the remaining balance plus its interest is less than the payment amount
                    // Update the remaining balance tb to display zero.
                    // The interest paid and that balance minus the interest will tell us how much
                    // principle was paid to get to zero.

                    if ((starting_balance + interest_paid) < monthly_payment)
                    {
                        MortageSchedLb.Items.Add(payments_made + ". Payment: " + (starting_balance + interest_paid).ToString("C") + " Interest: " +
                            interest_paid.ToString("C") + " Principle: " + (starting_balance - interest_paid).ToString("C") + " Loan Balance: $0.00");

                        FinalPaymentTb.Text = (starting_balance - interest_paid).ToString("C"); 
                    }
                    else
                        // Show the amortization schedule containing the payment, interest, principle, and balance based on a month to month schedule.
                    {
                        MortageSchedLb.Items.Add(payments_made + ". Payment: " + monthly_payment.ToString("C") + " Interest: " +
                            interest_paid.ToString("C") + " Principle: " + principle_paid.ToString("C") + " Loan Balance: " + calculated_balance.ToString("C"));

                        FinalPaymentTb.Text = calculated_balance.ToString("C");
                    }

                    payments_made++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ensure all fields contain whole numbers or decimal values:" + "\r" + "\n" + "\r" + "\n"
                                + "The following error occurred: " + "\r" + "\n" + ex);
            }
        }
    }
}
