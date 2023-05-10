
namespace Calculadora.WinApp.versão1._0
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnsoma_Click(object sender, EventArgs e)
        {
            lblMostrarResultado.Text = (float.Parse(txt1.Text) + float.Parse(txt2.Text)).ToString();
            lbloperacao.Text = "+";
        }

        private void btnsubtracao_Click(object sender, EventArgs e)
        {
            lblMostrarResultado.Text = (float.Parse(txt1.Text) - float.Parse(txt2.Text)).ToString();
            lbloperacao.Text = "-";
        }

        private void btnmulti_Click(object sender, EventArgs e)
        {
            lblMostrarResultado.Text = (float.Parse(txt1.Text) * float.Parse(txt2.Text)).ToString();
            lbloperacao.Text = "*";
        }

        private void btndivisao_Click(object sender, EventArgs e)
        {
            lblMostrarResultado.Text = (float.Parse(txt1.Text) / float.Parse(txt2.Text)).ToString();
            lbloperacao.Text = "/";
        }

        private void btnF1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Visible = false;
            form1.ShowDialog();
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            txt1.Text = " ";
            txt2.Text = " ";
            lbloperacao.Text = " ";
        }
    }
}
