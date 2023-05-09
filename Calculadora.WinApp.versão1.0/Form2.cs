using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        }

        private void btnsubtracao_Click(object sender, EventArgs e)
        {
            lblMostrarResultado.Text = (float.Parse(txt1.Text) - float.Parse(txt2.Text)).ToString();

        }

        private void btnmulti_Click(object sender, EventArgs e)
        {
            lblMostrarResultado.Text = (float.Parse(txt1.Text) * float.Parse(txt2.Text)).ToString();

        }

        private void btndivisao_Click(object sender, EventArgs e)
        {
            lblMostrarResultado.Text = (float.Parse(txt1.Text) / float.Parse(txt2.Text)).ToString();

        }
    }
}
