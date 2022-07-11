using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        String operation = "";
        Double result = 0;
        bool Operation = false;
        public Form1()
        {
            InitializeComponent();
        }


        private void btn_click(object sender, EventArgs e)
        {
            if ( (textBox1.Text == "0") || (Operation))
                textBox1.Clear();
            Operation = false;
            Button button = (Button) sender;
            textBox1.Text = textBox1.Text + button.Text; 
        }


        private void clear(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            result = 0;
        }

        private void operate_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            operation = button.Text;
            result = Double.Parse(textBox1.Text);
            textBox2.Text = result + "" + operation;
            Operation = true;
        }

        private void button15_click(object sender, EventArgs e)
        {
            switch(operation){

                case "+":  textBox1.Text = (result + Double.Parse(textBox1.Text)).ToString();
                           break;
                case "-":
                           textBox1.Text = (result - Double.Parse(textBox1.Text)).ToString();
                           break;
                case "/":
                           textBox1.Text = (result / Double.Parse(textBox1.Text)).ToString();
                           break;
                case "x":
                           textBox1.Text = (result * Double.Parse(textBox1.Text)).ToString();
                           break;
                default:
                    break;
            }
            result = Double.Parse(textBox1.Text);
            textBox2.Text = "";

        }
    }
}
