using System.Diagnostics.Metrics;

namespace _20221101_Assesment_Level4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //define variables
            int number1, divisor, quotient, remainder, ntotal;
            double result; 
            //convert text to integer from form variables
            number1 = Convert.ToInt32(n1.Text);
            divisor = Convert.ToInt32(n2.Text); 
            
            // assign variables to reduce loop iterations by 1
            ntotal = divisor;
            quotient = 0;
            // begin loop comparing number vs total calculated in loop 
            while (number1 > ntotal)
            {
                //calculate total through addition of divisor in every iteration 
                ntotal = ntotal + divisor;
                // calculate quotient through number of iterations
                quotient = quotient + 1;

            }
            // calculate remainder by subtracting the divisor from the total calculaed in the loop and then from the first number
            remainder = number1 - (ntotal - divisor);
            // output quotient + remainder
            lblOutput2.Text = remainder.ToString();
            lblOutput.Text = quotient.ToString();
        }
    }
}