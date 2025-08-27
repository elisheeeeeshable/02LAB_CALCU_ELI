using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02LAB_CALCU_ELI
{
    public partial class Form1 : Form
    {
        CalculatorClass cal;
        double num1, num2;
        public Form1()
        {
            InitializeComponent();
            cal = new CalculatorClass();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(textBox1.Text);
            num2 = Convert.ToDouble(textBox2.Text);

            string op = comboBox1.Text;

            switch (op)
            {
                case "+":
                    cal.CalculateEvent += new Formula<double>(cal.GetSum);
                    lblTotal.Text = cal.GetSum(num1, num2).ToString();
                    cal.CalculateEvent -= new Formula<double>(cal.GetSum);
                    break;

                case "-":
                    cal.CalculateEvent += new Formula<double>(cal.GetDifference);
                    lblTotal.Text = cal.GetDifference(num1, num2).ToString();
                    cal.CalculateEvent -= new Formula<double>(cal.GetDifference);
                    break;

                case "*":
                    cal.CalculateEvent += new Formula<double>(cal.GetProduct);
                    lblTotal.Text = cal.GetProduct(num1, num2).ToString();
                    cal.CalculateEvent -= new Formula<double>(cal.GetProduct);
                    break;

                case "/":
                    cal.CalculateEvent += new Formula<double>(cal.GetQuotient);
                    lblTotal.Text = cal.GetQuotient(num1, num2).ToString();
                    cal.CalculateEvent -= new Formula<double>(cal.GetQuotient);
                    break;
            }
        }
    }
}
