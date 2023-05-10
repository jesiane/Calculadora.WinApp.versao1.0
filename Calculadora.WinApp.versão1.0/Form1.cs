using System.Globalization;


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
            lblOperacao.Text = " ";
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            if (textResultado.Text != "")
            {
                valor1 = decimal.Parse(textResultado.Text, CultureInfo.InvariantCulture);
                textResultado.Text = "";
                operacao = "soma";
                lblOperacao.Text = "+";
            }
            else
            {
                MessageBox.Show(" Informe um valor para efetuar a Soma.");
            }
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            if (textResultado.Text != "")
            {
                valor1 = decimal.Parse(textResultado.Text, CultureInfo.InvariantCulture);
                textResultado.Text = "";
                operacao = "sub";
                lblOperacao.Text = "-";

            }
            else
            {
                MessageBox.Show(" Informe um valor para efetuar a Subtração.");
            }
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            if (textResultado.Text != "")
            {

                valor1 = decimal.Parse(textResultado.Text, CultureInfo.InvariantCulture);
                textResultado.Text = "";
                operacao = "mult";
                lblOperacao.Text = "*";

            }
            else
            {
                MessageBox.Show(" Informe um valor para efetuar a Multiplicação.");
            }
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            if (textResultado.Text != "")
            {

                valor1 = decimal.Parse(textResultado.Text, CultureInfo.InvariantCulture);
                textResultado.Text = "";
                operacao = "div";
                lblOperacao.Text = "/";

            }
            else
            {
                MessageBox.Show(" Informe um valor para efetuar a Divisão.");
            }
        }


        private void btnIgual_Click(object sender, EventArgs e)
        {
            if (textResultado.Text != "")
            {
                valor2 = decimal.Parse(textResultado.Text, CultureInfo.InvariantCulture);

                if (operacao == "soma")
                {
                    textResultado.Text = Convert.ToString(valor1 + valor2);
                    ForeColor = Color.Red;
                }
                else if (operacao == "sub")
                {
                    textResultado.Text = Convert.ToString(valor1 - valor2);
                    ForeColor = Color.Blue;

                }
                else if (operacao == "mult")
                {
                    textResultado.Text = Convert.ToString(valor1 * valor2);
                    ForeColor = Color.DeepPink;
                }
                else
                {
                    textResultado.Text = Convert.ToString(valor1 / valor2);
                    ForeColor = Color.Green;
                }
            }
            else
            {
                MessageBox.Show(" Informe o valor para concluir o calculo.");
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

        private void btnF2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            this.Visible = false;
            form2.ShowDialog();
        }
    }
}
