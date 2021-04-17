using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CalculatorWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        bool b = false;
        string operand = "";
        double result = 0;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void ClickOnNumbers(object sender, RoutedEventArgs e)
        {
            if (ResultTxtb.Text == "0" || b) ResultTxtb.Clear();
            Button button = (Button)sender;
            ResultTxtb.Text += button.Content;
            ResultTxtblck.Text += button.Content;
            b = false;
        }

        private void ClickOnOperations(object sender, RoutedEventArgs e)
        {
            b = true;
            Button button = (Button)sender;
            string newOperand = button.Content.ToString();
            ResultTxtblck.Text = ResultTxtblck.Text + " " + newOperand + " ";
            switch (operand)
            {
                case "+":
                    ResultTxtb.Text = (result + Double.Parse(ResultTxtb.Text)).ToString();
                    break;
                case "-":
                    ResultTxtb.Text = (result - Double.Parse(ResultTxtb.Text)).ToString();
                    break;
                case "*":
                    ResultTxtb.Text = (result * Double.Parse(ResultTxtb.Text)).ToString();
                    break;
                case "/":
                    ResultTxtb.Text = (result / Double.Parse(ResultTxtb.Text)).ToString();
                    break;
                default:
                    break;
            }
            result = Double.Parse(ResultTxtb.Text);
            operand = newOperand;
        }

        private void ClickOnEqualBtn(object sender, EventArgs e)
        {
            ResultTxtblck.Text = "";
            b = true;
            switch (operand)
            {
                case "+":
                    ResultTxtb.Text = (result + Double.Parse(ResultTxtb.Text)).ToString();
                    break;
                case "-":
                    ResultTxtb.Text = (result - Double.Parse(ResultTxtb.Text)).ToString();
                    break;
                case "*":
                    ResultTxtb.Text = (result * Double.Parse(ResultTxtb.Text)).ToString();
                    break;
                case "/":
                    ResultTxtb.Text = (result / Double.Parse(ResultTxtb.Text)).ToString();
                    break;
                default:
                    break;
            }
            result = Double.Parse(ResultTxtb.Text);
            ResultTxtb.Text = result.ToString();
            result = 0;
            operand = "";
        }

        private void ClickOnClearBtn(object sender, RoutedEventArgs e)
        {
            ResultTxtb.Clear();
            ResultTxtblck.Text = "";
            result = 0;
            operand = "";
        }

        private void ClickOnDeleteBtn(object sender, RoutedEventArgs e)
        {
            string sTxtb = ResultTxtb.Text;
            string sTxtblck = ResultTxtblck.Text;

            if (sTxtb.Length > 1 && sTxtblck.Length > 1)
            {
                sTxtb = sTxtb.Substring(0, sTxtb.Length - 1);
                sTxtblck = sTxtblck.Substring(0, sTxtblck.Length - 1);

            }
            else
            {
                sTxtb = "0";
                sTxtblck = "0";
            }
            ResultTxtb.Text = sTxtb;
            ResultTxtblck.Text = sTxtblck;
        }

    }
}
