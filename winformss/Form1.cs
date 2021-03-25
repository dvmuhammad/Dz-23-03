using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winformss
{
    public partial class CalculatorForm : Form
    {
        double firstNumber, secondNumber, result, memory;
        char sign;
        public CalculatorForm()
        {
            InitializeComponent();
        }

        void NumberCommaButtonClick(object sender, EventArgs e)
        {
            char[] comma = { ',' };
            if (CalcScreen.Text.IndexOfAny(comma) == -1)
                CalcScreen.Text += (sender as Button).Text;
            if ((CalcScreen.Text.IndexOfAny(comma) != -1) && (sender as Button).Text[0] != ',')
                CalcScreen.Text += (sender as Button).Text;
            if (CalcScreen.Text.Length > 17)
                CalcScreen.Text = CalcScreen.Text.Remove(17);
            if (CalcScreen.Text.Length > 1 && CalcScreen.Text[0] == '0' && CalcScreen.Text[1] != ',')
                CalcScreen.Text = CalcScreen.Text.Remove(0, 1);

        }

        void ButtonSignClick(object sender, EventArgs e)
        {
            if (firstNumber == 0.0)
            {
                firstNumber = Convert.ToDouble(CalcScreen.Text);
                sign = (sender as Button).Text[0];
            }
            if (firstNumber != 0.0)
                sign = (sender as Button).Text[0];

            if (CalcScreen.Text.Length != 0)
                CalcScreen.Text = CalcScreen.Text.Remove(0);

        }
        void ButtonTotalClick(object sender, EventArgs e)
        {
            secondNumber = Convert.ToDouble(CalcScreen.Text);
            switch (sign)
            {
                case '+':
                    result = firstNumber + secondNumber;
                    break;
                case '-':
                    result = firstNumber - secondNumber;
                    break;
                case '*':
                    result = firstNumber * secondNumber;
                    break;
                case '/':
                    result = firstNumber / secondNumber;
                    break;
            }
            CalcScreen.Text = Convert.ToString(result);
            if (CalcScreen.Text.Length > 17)
                CalcScreen.Text = CalcScreen.Text.Remove(17);

        }
        void ButtonReverseDivideClick(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(CalcScreen.Text);
            result = 1 / firstNumber;
            CalcScreen.Text = Convert.ToString(result);
        }

        void BackSpaceButtonClick(object sender, EventArgs e)
        {
            if (CalcScreen.Text.Length > 0)
                CalcScreen.Text = CalcScreen.Text.Remove(CalcScreen.Text.Length - 1, 1);

        }

        private void SqrtButtonClick(object sender, EventArgs e)
        {
            if (result == 0)
            {
                firstNumber = Convert.ToDouble(CalcScreen.Text);
                CalcScreen.Text = Convert.ToString(Math.Sqrt(firstNumber));
            }
            else CalcScreen.Text = Convert.ToString(Math.Sqrt(result));
        }

        private void CancelButtonClick(object sender, EventArgs e)
        {
            firstNumber = secondNumber = result = memory = 0.0;
            CalcScreen.Text = Convert.ToString(firstNumber);
        }


        void ChangeSignButtonClick(object sender, EventArgs e)
        {
            if (CalcScreen.Text != "" && CalcScreen.Text != "0")
            {
                if (CalcScreen.Text[0] == '-')
                    CalcScreen.Text = CalcScreen.Text.Remove(0, 1);
                else CalcScreen.Text = '-' + CalcScreen.Text;
            }
        }


        void CEButtonClick(object sender, EventArgs e)
        {
            if (firstNumber == 0.0 && secondNumber == 0.0)
            {
                CalcScreen.Text = Convert.ToString(firstNumber);
            }
            if (firstNumber != 0.0 && secondNumber == 0.0)
            {
                CalcScreen.Text = Convert.ToString(secondNumber);
            }


        }

        void ButtonMSClick(object sender, EventArgs e)
        {
            memory = Convert.ToDouble(CalcScreen.Text);
        }

        void ButtonMRClick(object sender, EventArgs e)
        {
            CalcScreen.Text = Convert.ToString(memory);

        }

        void ButtonMCClick(object sender, EventArgs e)
        {
            memory = 0.0;
        }

        void ButtonMPlusClick(object sender, EventArgs e)
        {
            memory = memory + Convert.ToDouble(CalcScreen.Text);
        }

        void ButtonMMinusClick(object sender, EventArgs e)
        {
            memory = memory - Convert.ToDouble(CalcScreen.Text);
        }

        void ButtonPercentClick(object sender, EventArgs e)
        {
            secondNumber = Convert.ToDouble(CalcScreen.Text);
            switch (sign)
            {
                case '+':
                    result = firstNumber + (firstNumber * secondNumber / 100);
                    break;
                case '-':
                    result = firstNumber - (firstNumber * secondNumber / 100);
                    break;
                case '*':
                    result = firstNumber * (firstNumber * secondNumber / 100);
                    break;
                case '/':
                    result = firstNumber / (firstNumber * secondNumber / 100);
                    break;

            }
            CalcScreen.Text = Convert.ToString(result);
        }

    }
}