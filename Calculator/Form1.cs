using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string sign, field;
        string fieldForNumbers;
        string number1AsString, number2AsString;
        int number1, number2;
        int lengthOfField;
        int counter = 0;
        int space = 1;
        int result;
        int[] numbers = new int[2];

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        

        // there is number buttons behavior
        private void button0_Click(object sender, EventArgs e)
        {
            textBox1.Text += 0;
            counter++;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += 1;
            counter++;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += 2;

            counter++;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += 3;

            counter++;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += 4;

            counter++;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += 5;

            counter++;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += 6;

            counter++;

        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += 7;

            counter++;

        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += 8;

            counter++;

        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += 9;

            counter++;

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            textBox1.Text += " + ";
            sign = "+";
        }

        private void buttonSubtract_Click(object sender, EventArgs e)
        {
            textBox1.Text += " - ";
            sign = "-";
        }

        private void buttonMultiple_Click(object sender, EventArgs e)
        {
            textBox1.Text += " * ";
            sign = "*";
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            textBox1.Text += " / ";
            sign = "/";
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            field = textBox1.Text;
            lengthOfField = field.Length;
            textBox1.Text = field.Substring(0, lengthOfField - 1);
        }

        //public void 

        public void findNumbers()
        {
            string fieldForNumbers = textBox1.Text;
            for (int i = 0; i < fieldForNumbers.Length; i++)
            {
                if (fieldForNumbers[i] == '+')
                {
                    space = i;
                    number1AsString = fieldForNumbers.Substring(0, space);
                    number2AsString = fieldForNumbers.Substring(space + 1);

                    number1 = Convert.ToInt32(number1AsString);
                    number2 = Convert.ToInt32(number2AsString);
                    break;
                }

                else if (fieldForNumbers[i] == '-')
                {
                    space = i;
                    number1AsString = fieldForNumbers.Substring(0, space);
                    number2AsString = fieldForNumbers.Substring(space + 1);

                    number1 = Convert.ToInt32(number1AsString);
                    number2 = Convert.ToInt32(number2AsString);
                    break;
                }

                else if (fieldForNumbers[i] == '*')
                {
                    space = i;
                    number1AsString = fieldForNumbers.Substring(0, space);
                    number2AsString = fieldForNumbers.Substring(space + 1);

                    number1 = Convert.ToInt32(number1AsString);
                    number2 = Convert.ToInt32(number2AsString);
                    break;
                }

                else if (fieldForNumbers[i] == '/')
                {
                    space = i;
                    number1AsString = fieldForNumbers.Substring(0, space);
                    number2AsString = fieldForNumbers.Substring(space + 1);

                    number1 = Convert.ToInt32(number1AsString);
                    number2 = Convert.ToInt32(number2AsString);
                    break;
                }
                
                
                
            }
        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            findNumbers();
            switch (sign)
            {
                case "+":
                    result = number1 + number2;
                    break;
                case "-":
                    result = number1 - number2;
                    break;
                case "*":
                    result = number1 * number2;
                    break;
                case "/":
                    result = number1 / number2;
                    break;

            }


            textBox1.Text = Convert.ToString(result);
        }
    }
}
