namespace Calculadora.WinApp.versão1._0
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            lblMostrarResultado = new Label();
            lblResultado = new Label();
            txt2 = new TextBox();
            lblSegundo = new Label();
            txt1 = new TextBox();
            lblPrimeiro = new Label();
            lblTitulo = new Label();
            btnsubtracao = new Button();
            btndivisao = new Button();
            btnmulti = new Button();
            btnsoma = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblMostrarResultado);
            groupBox1.Controls.Add(lblResultado);
            groupBox1.Controls.Add(txt2);
            groupBox1.Controls.Add(lblSegundo);
            groupBox1.Controls.Add(txt1);
            groupBox1.Controls.Add(lblPrimeiro);
            groupBox1.Controls.Add(lblTitulo);
            groupBox1.Controls.Add(btnsubtracao);
            groupBox1.Controls.Add(btndivisao);
            groupBox1.Controls.Add(btnmulti);
            groupBox1.Controls.Add(btnsoma);
            groupBox1.Location = new Point(27, 25);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(341, 413);
            groupBox1.TabIndex = 19;
            groupBox1.TabStop = false;
            groupBox1.Text = "Calculadora";
            // 
            // lblMostrarResultado
            // 
            lblMostrarResultado.AutoSize = true;
            lblMostrarResultado.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblMostrarResultado.Location = new Point(229, 126);
            lblMostrarResultado.Name = "lblMostrarResultado";
            lblMostrarResultado.Size = new Size(18, 20);
            lblMostrarResultado.TabIndex = 41;
            lblMostrarResultado.Text = "0";
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(155, 130);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(65, 15);
            lblResultado.TabIndex = 40;
            lblResultado.Text = "Resultado: ";
            // 
            // txt2
            // 
            txt2.Location = new Point(30, 122);
            txt2.Name = "txt2";
            txt2.Size = new Size(100, 23);
            txt2.TabIndex = 42;
            // 
            // lblSegundo
            // 
            lblSegundo.AutoSize = true;
            lblSegundo.Location = new Point(31, 104);
            lblSegundo.Name = "lblSegundo";
            lblSegundo.Size = new Size(101, 15);
            lblSegundo.TabIndex = 38;
            lblSegundo.Text = "Segundo Numero";
            // 
            // txt1
            // 
            txt1.Location = new Point(32, 78);
            txt1.Name = "txt1";
            txt1.Size = new Size(100, 23);
            txt1.TabIndex = 37;
            // 
            // lblPrimeiro
            // 
            lblPrimeiro.AutoSize = true;
            lblPrimeiro.Location = new Point(30, 60);
            lblPrimeiro.Name = "lblPrimeiro";
            lblPrimeiro.Size = new Size(99, 15);
            lblPrimeiro.TabIndex = 36;
            lblPrimeiro.Text = "Primeiro Numero";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = SystemColors.ActiveBorder;
            lblTitulo.Location = new Point(90, 28);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(171, 15);
            lblTitulo.TabIndex = 34;
            lblTitulo.Text = "Calculadora WinApp versão 1.0";
            lblTitulo.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnsubtracao
            // 
            btnsubtracao.Location = new Point(183, 78);
            btnsubtracao.Name = "btnsubtracao";
            btnsubtracao.Size = new Size(31, 23);
            btnsubtracao.TabIndex = 30;
            btnsubtracao.Text = "-";
            btnsubtracao.UseVisualStyleBackColor = true;
            btnsubtracao.Click += btnsubtracao_Click;
            // 
            // btndivisao
            // 
            btndivisao.Location = new Point(257, 78);
            btndivisao.Name = "btndivisao";
            btndivisao.Size = new Size(31, 23);
            btndivisao.TabIndex = 32;
            btndivisao.Text = "/";
            btndivisao.UseVisualStyleBackColor = true;
            btndivisao.Click += btndivisao_Click;
            // 
            // btnmulti
            // 
            btnmulti.Location = new Point(220, 78);
            btnmulti.Name = "btnmulti";
            btnmulti.Size = new Size(31, 23);
            btnmulti.TabIndex = 31;
            btnmulti.Text = "*";
            btnmulti.UseVisualStyleBackColor = true;
            btnmulti.Click += btnmulti_Click;
            // 
            // btnsoma
            // 
            btnsoma.Location = new Point(146, 78);
            btnsoma.Name = "btnsoma";
            btnsoma.Size = new Size(31, 23);
            btnsoma.TabIndex = 29;
            btnsoma.Text = "+";
            btnsoma.UseVisualStyleBackColor = true;
            btnsoma.Click += btnsoma_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(415, 450);
            Controls.Add(groupBox1);
            Name = "Form2";
            Text = "Form2";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label lblMostrarResultado;
        private Label lblResultado;
        private Label lblSegundo;
        private TextBox txt1;
        private Label lblPrimeiro;
        private Label lblTitulo;
        private Button btnsubtracao;
        private Button btndivisao;
        private Button btnmulti;
        private Button btnsoma;
        private TextBox txt2;
    }
}