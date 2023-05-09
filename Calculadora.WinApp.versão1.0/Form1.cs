using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora.WinApp.versão1._0
{
    public partial class Form1 : Form
    {
        decimal valor1 = 0, valor2 = 0;
        string operacao = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            textResultado.Text = " ";
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(textResultado.Text, CultureInfo.InvariantCulture);
            textResultado.Text = "";
            operacao = "soma";
            lblOperacao.Text = "+";
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(textResultado.Text, CultureInfo.InvariantCulture);
            textResultado.Text = "";
            operacao = "sub";
            lblOperacao.Text = "-";
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(textResultado.Text, CultureInfo.InvariantCulture);
            textResultado.Text = "";
            operacao = "mult";
            lblOperacao.Text = "*";
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(textResultado.Text, CultureInfo.InvariantCulture);
            textResultado.Text = "";
            operacao = "div";
            lblOperacao.Text = "/";
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            valor2 = decimal.Parse(textResultado.Text, CultureInfo.InvariantCulture);

            if (operacao == "soma")
            {
                textResultado.Text = Convert.ToString(valor1 + valor2);
            }
            else if (operacao == "sub")
            {
                textResultado.Text = Convert.ToString(valor1 - valor2);

            }
            else if (operacao == "mult")
            {
                textResultado.Text = Convert.ToString(valor1 * valor2);
            }
            else
            {
                textResultado.Text = Convert.ToString(valor1 / valor2);
            }
        }

        private void lblOperacao_Click(object sender, EventArgs e)
        {

        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            textResultado.AppendText("1");
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            textResultado.AppendText("2");
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            textResultado.AppendText("3");
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            textResultado.AppendText("4");
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            textResultado.AppendText("5");
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            textResultado.AppendText("6");
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            textResultado.AppendText("7");
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            textResultado.AppendText("8");
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            textResultado.AppendText("9");
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            textResultado.AppendText("0");
        }
    }
}
