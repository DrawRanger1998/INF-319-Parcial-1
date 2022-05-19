using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraWindows
{
    public partial class Form1 : Form
    {
        int pantalla, num1, num2;
        String operador = "";
        Calculadora calc;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pantalla = 0;
            textBox1.Text = pantalla.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int digito;
            digito = Convert.ToInt32(((Button)sender).Text);
            pantalla = pantalla * 10 + digito;
            textBox1.Text = pantalla.ToString();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (!operador.Equals(""))
            {
                num1 = Convert.ToInt32(textBox2.Text.Substring(0, textBox2.Text.Length - 1));
                num2 = Convert.ToInt32(textBox1.Text);
                calc = new Calculadora(num1, num2);
                operacion();
            }
            if(textBox1.Text.Equals("Error"))
            {
                textBox1.Text = "0";
            }
            textBox2.Text = textBox1.Text + ((Button)sender).Text;
            operador = ((Button)sender).Text;
            textBox1.Text = "";
            pantalla = 0;
            textBox1.Text = pantalla.ToString();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToInt32(textBox2.Text.Substring(0, textBox2.Text.Length - 1));
            num2 = Convert.ToInt32(textBox1.Text);
            calc = new Calculadora(num1, num2);
            textBox2.Text = textBox2.Text + textBox1.Text + "=";
            operacion();
            operador = "";
        }

        public void operacion()
        {
            switch (operador)
            {
                case "+":
                    textBox1.Text = Convert.ToString(calc.sumar());
                    break;
                case "-":
                    textBox1.Text = Convert.ToString(calc.restar());
                    break;
                case "*":
                    textBox1.Text = Convert.ToString(calc.multiplicar());
                    break;
                case "/":
                    if (calc.getNumero2() == 0)
                    {
                        textBox1.Text = "Error";
                    }
                    else
                    {
                        textBox1.Text = Convert.ToString(calc.dividir());

                    }
                    break;
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            textBox2.Text = "";
            operador = "";
        }

    }
}
