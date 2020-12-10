using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CalculatorApp
{
    public partial class MainPage : ContentPage
    {
        string input = string.Empty;
        string operation = string.Empty;
        double operand1 = 0.0;
        double operand2 = 0.0;

        public MainPage()
        {
            InitializeComponent();
        }
        public void OneClick(object sender, EventArgs e)
        {
            this.resultText.Text += "1";
            input += "1";
        }
        public void TwoClick(object sender, EventArgs e)
        {
            this.resultText.Text += "2";
            input += "2";
        }
        public void ThreeClick(object sender, EventArgs e)
        {
            this.resultText.Text += "3";
            input += "3";
        }
        public void FourClick(object sender, EventArgs e)
        {
            this.resultText.Text += "4";
            input += "4";
        }
        public void FiveClick(object sender, EventArgs e)
        {
            this.resultText.Text += "5";
            input += "5";
        }
        public void SixClick(object sender, EventArgs e)
        {
            this.resultText.Text += "6";
            input += "6";
        }
        public void SevenClick(object sender, EventArgs e)
        {
            this.resultText.Text += "7";
            input += "7";
        }
        public void EightClick(object sender, EventArgs e)
        {
            this.resultText.Text += "8";
            input += "8";
        }
        public void NineClick(object sender, EventArgs e)
        {
            this.resultText.Text += "9";
            input += "9";
        }
        public void ZeroClick(object sender, EventArgs e)
        {
            this.resultText.Text += "0";
            input += "0";
        }
        public void PointClick(object sender, EventArgs e)
        {
            this.resultText.Text += ".";
            input += ".";
        }

        public void PlusClick(object sender, EventArgs e)
        {
            this.resultText.Text += "+";
            operation = "plus";
            operand1 = double.Parse(input);
            input = "";
        }
        public void MinusClick(object sender, EventArgs e)
        {
            this.resultText.Text += "-";
            operation = "minus";
            operand1 = double.Parse(input);
            input = "";
        }
        public void DivideClick(object sender, EventArgs e)
        {
            this.resultText.Text += "÷";
            operation = "divide";
            operand1 = double.Parse(input);
            input = "";
        }
        public void MultiplyClick(object sender, EventArgs e)
        {
            this.resultText.Text += "x";
            operation = "multiply";
            operand1 = double.Parse(input);
            input = "";
        }

        public void EqualsClick(object sender, EventArgs e)
        {
            operand2 = double.Parse(input);
            this.resultText.Text = CalculatorLogic.Calculate(operand1, operand2, operation).ToString();
        }
        public void ClearClick(object sender, EventArgs e)
        {
            this.resultText.Text = "";
            input = string.Empty;
        }

    }

 
}
