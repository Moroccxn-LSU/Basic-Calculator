using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Csharp_Calculator
{
    public partial class Calculator : Form
    {
        String operation = "";
        Double num1, num2;
        public Calculator()
        {
            InitializeComponent();
        }

        private void Numbers(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (Display.Text == "0")
            {
                Display.Text = "";
            }

            if (button.Text == ".")
            {
                if (!Display.Text.Contains("."))
                {
                    Display.Text = Display.Text + button.Text;
                }
            }
            else
            {
                Display.Text = Display.Text + button.Text;
            }
        }

        private void Click_C(object sender, EventArgs e)
        {
            Display.Text = "0";
        }

        private void Click_CE(object sender, EventArgs e)
        {
            Display.Text = "0";
            String first, second;

            first = Convert.ToString(num1);
            second = Convert.ToString(num2);

            first = "";
            second = "";
        }

        private void Math_Operations(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            num1 = Double.Parse(Display.Text);
            operation = button.Text;
            Display.Text = "";
        }

        private void Click_Bck(object sender, EventArgs e)
        {
            if (Display.Text.Length > 0)
            {
                Display.Text = Display.Text.Remove(Display.Text.Length - 1, 1);
            }

            if (Display.Text == "")
            {
                Display.Text = "0";
            }
        }

        private void Click_PlusMinus(object sender, EventArgs e)
        {
            if (Display.Text.Contains("-"))
            {
                Display.Text = Display.Text.Remove(0, 1);
            }
            else
            {
                Display.Text = "-" + Display.Text;
            }
        }

        private void Click_Eq(object sender, EventArgs e)
        {
            num2 = double.Parse(Display.Text);
            switch (operation)
            {
                case "+":
                    Display.Text = Convert.ToString(num1 + num2);
                    break;
                case "-":
                    Display.Text = Convert.ToString(num1 - num2);
                    break;
                case "*":
                    Display.Text = Convert.ToString(num1 * num2);
                    break;
                case "/":
                    Display.Text = Convert.ToString(num1 / num2);
                    break;
                default:
                    break;
            }
        }

        private void Calculator_Load(object sender, EventArgs e)
        {

        }
    }
}
