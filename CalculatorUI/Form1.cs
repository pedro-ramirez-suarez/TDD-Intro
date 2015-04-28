using Calculator.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorUI
{
    public partial class Form1 : Form
    {

        decimal firstNumber;
        decimal secondNumber;
        string currentNumber;
        string operation;
        ISimpleCalculator calc;

        public Form1()
        {
            InitializeComponent();
            currentNumber = string.Empty;
            calc = new SimpleCalculator();
        }

        /// <summary>
        /// Numbers and decimal point
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            currentNumber += (sender as Button).Text.Trim();
            textBox1.Text = currentNumber;
        }

        /// <summary>
        /// Operators
        /// </summary>
        private void button15_Click(object sender, EventArgs e)
        {
            this.firstNumber = decimal.Parse(currentNumber);
            this.operation = (sender as Button).Text.Trim();
            currentNumber = string.Empty;
            (sender as Button).FlatStyle = FlatStyle.Flat;
            textBox1.Text = currentNumber;
        }

        /// <summary>
        /// REsult
        /// </summary>
        private void button16_Click(object sender, EventArgs e)
        {
            this.secondNumber = decimal.Parse(currentNumber);
            decimal result =0; 
            switch (operation)
            {
                case "+":
                    result = calc.Suma(firstNumber, secondNumber);
                    break;
                case "-":
                    result = calc.Resta(firstNumber, secondNumber);
                    break;
                case "/":
                    result = calc.Division(firstNumber, secondNumber);
                    break;
                case "*":
                    result = calc.Multiplicacion(firstNumber, secondNumber);
                    break;
            }
            this.firstNumber = 0;
            this.secondNumber = 0;
            textBox1.Text = result.ToString();
            (sender as Button).FlatStyle = FlatStyle.Standard;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            currentNumber = string.Empty;
            textBox1.Text = currentNumber;
        }
    }
}
