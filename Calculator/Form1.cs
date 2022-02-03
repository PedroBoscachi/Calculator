using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace Calculator
{
    public partial class Form1 : Form
    {
        double value = 0;
        string operation = "";
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonClick(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            result.Text += b.Text.ToString();
        }

        private void opClick(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            value = Double.Parse(result.Text, CultureInfo.InvariantCulture);
            operation = b.Text;

            lblResult.Text = b.Text + result.Text;

            result.Clear();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            switch (operation)
            {
                case "+":
                    result.Text = (value + double.Parse(result.Text, CultureInfo.InvariantCulture)).ToString();
                    break;
                case "/":
                    result.Text = (value / double.Parse(result.Text, CultureInfo.InvariantCulture)).ToString();
                    break;
                case "-":
                    result.Text = (value - double.Parse(result.Text, CultureInfo.InvariantCulture)).ToString();
                    break;
                case "X":
                    result.Text = (value * double.Parse(result.Text, CultureInfo.InvariantCulture)).ToString();
                    break;
                case "%":
                    result.Text = (value * (double.Parse(result.Text, CultureInfo.InvariantCulture)) / 100).ToString();
                    break;
            }


            value = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            result.Clear();
            value = 0;
        }
    }
}
