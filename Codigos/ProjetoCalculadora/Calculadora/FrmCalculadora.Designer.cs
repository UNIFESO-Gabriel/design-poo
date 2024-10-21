using System.Windows.Forms;

namespace Calculadora
{
    partial class FrmCalculadora
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
            txtVisor = new TextBox();
            panelBotoes = new Panel();
            btnLimpar = new Button();
            btnBackspace = new Button();
            btnDivisao = new Button();
            btn9 = new Button();
            btn8 = new Button();
            btn7 = new Button();
            btnFechaParenteses = new Button();
            btnAbreParenteses = new Button();
            btnMultiplicacao = new Button();
            btn6 = new Button();
            btn5 = new Button();
            btnSqrt = new Button();
            btnElevadoQuadrado = new Button();
            btnSubtracao = new Button();
            btn3 = new Button();
            btn2 = new Button();
            btnIgual = new Button();
            btnAdicao = new Button();
            btnModulo = new Button();
            btnDecimal = new Button();
            btn4 = new Button();
            btn1 = new Button();
            btn0 = new Button();
            txtHistorico = new RichTextBox();
            panelBotoes.SuspendLayout();
            SuspendLayout();
            // 
            // txtVisor
            // 
            txtVisor.BackColor = Color.White;
            txtVisor.BorderStyle = BorderStyle.FixedSingle;
            txtVisor.Font = new Font("Arial", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtVisor.ForeColor = SystemColors.InfoText;
            txtVisor.Location = new Point(6, 170);
            txtVisor.Margin = new Padding(4, 3, 4, 3);
            txtVisor.Name = "txtVisor";
            txtVisor.Size = new Size(591, 50);
            txtVisor.TabIndex = 1;
            txtVisor.Text = "0";
            txtVisor.TextAlign = HorizontalAlignment.Right;
            txtVisor.TextChanged += txtVisor_TextChanged;
            // 
            // panelBotoes
            // 
            panelBotoes.Controls.Add(btnLimpar);
            panelBotoes.Controls.Add(btnBackspace);
            panelBotoes.Controls.Add(btnDivisao);
            panelBotoes.Controls.Add(btn9);
            panelBotoes.Controls.Add(btn8);
            panelBotoes.Controls.Add(btn7);
            panelBotoes.Controls.Add(btnFechaParenteses);
            panelBotoes.Controls.Add(btnAbreParenteses);
            panelBotoes.Controls.Add(btnMultiplicacao);
            panelBotoes.Controls.Add(btn6);
            panelBotoes.Controls.Add(btn5);
            panelBotoes.Controls.Add(btnSqrt);
            panelBotoes.Controls.Add(btnElevadoQuadrado);
            panelBotoes.Controls.Add(btnSubtracao);
            panelBotoes.Controls.Add(btn3);
            panelBotoes.Controls.Add(btn2);
            panelBotoes.Controls.Add(btnIgual);
            panelBotoes.Controls.Add(btnAdicao);
            panelBotoes.Controls.Add(btnModulo);
            panelBotoes.Controls.Add(btnDecimal);
            panelBotoes.Controls.Add(btn4);
            panelBotoes.Controls.Add(btn1);
            panelBotoes.Controls.Add(btn0);
            panelBotoes.Location = new Point(-5, 227);
            panelBotoes.Margin = new Padding(4, 3, 4, 3);
            panelBotoes.Name = "panelBotoes";
            panelBotoes.Size = new Size(602, 356);
            panelBotoes.TabIndex = 2;
            // 
            // btnLimpar
            // 
            btnLimpar.BackColor = Color.FromArgb(255, 128, 128);
            btnLimpar.FlatStyle = FlatStyle.Flat;
            btnLimpar.Font = new Font("Consolas", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnLimpar.Location = new Point(509, 13);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(93, 79);
            btnLimpar.TabIndex = 22;
            btnLimpar.Text = "C";
            btnLimpar.UseVisualStyleBackColor = false;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // btnBackspace
            // 
            btnBackspace.BackColor = Color.White;
            btnBackspace.FlatStyle = FlatStyle.Flat;
            btnBackspace.Font = new Font("Consolas", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnBackspace.Location = new Point(410, 13);
            btnBackspace.Name = "btnBackspace";
            btnBackspace.Size = new Size(93, 79);
            btnBackspace.TabIndex = 21;
            btnBackspace.Text = "←";
            btnBackspace.UseVisualStyleBackColor = false;
            btnBackspace.Click += btnBackspace_Click;
            // 
            // btnDivisao
            // 
            btnDivisao.BackColor = Color.White;
            btnDivisao.FlatStyle = FlatStyle.Flat;
            btnDivisao.Font = new Font("Consolas", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnDivisao.Location = new Point(311, 13);
            btnDivisao.Name = "btnDivisao";
            btnDivisao.Size = new Size(93, 79);
            btnDivisao.TabIndex = 20;
            btnDivisao.Text = "/";
            btnDivisao.UseVisualStyleBackColor = false;
            btnDivisao.Click += btnDivisao_Click;
            // 
            // btn9
            // 
            btn9.BackColor = Color.White;
            btn9.FlatStyle = FlatStyle.Flat;
            btn9.Font = new Font("Consolas", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn9.Location = new Point(212, 13);
            btn9.Name = "btn9";
            btn9.Size = new Size(93, 79);
            btn9.TabIndex = 19;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = false;
            btn9.Click += btn9_Click;
            // 
            // btn8
            // 
            btn8.BackColor = Color.White;
            btn8.FlatStyle = FlatStyle.Flat;
            btn8.Font = new Font("Consolas", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn8.Location = new Point(113, 13);
            btn8.Name = "btn8";
            btn8.Size = new Size(93, 79);
            btn8.TabIndex = 18;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = false;
            btn8.Click += btn8_Click;
            // 
            // btn7
            // 
            btn7.BackColor = Color.White;
            btn7.FlatStyle = FlatStyle.Flat;
            btn7.Font = new Font("Consolas", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn7.Location = new Point(14, 13);
            btn7.Name = "btn7";
            btn7.Size = new Size(93, 79);
            btn7.TabIndex = 17;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = false;
            btn7.Click += btn7_Click;
            // 
            // btnFechaParenteses
            // 
            btnFechaParenteses.BackColor = Color.White;
            btnFechaParenteses.FlatStyle = FlatStyle.Flat;
            btnFechaParenteses.Font = new Font("Consolas", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnFechaParenteses.Location = new Point(509, 98);
            btnFechaParenteses.Name = "btnFechaParenteses";
            btnFechaParenteses.Size = new Size(93, 79);
            btnFechaParenteses.TabIndex = 16;
            btnFechaParenteses.Text = ")";
            btnFechaParenteses.UseVisualStyleBackColor = false;
            btnFechaParenteses.Click += btnFechaParenteses_Click;
            // 
            // btnAbreParenteses
            // 
            btnAbreParenteses.BackColor = Color.White;
            btnAbreParenteses.FlatStyle = FlatStyle.Flat;
            btnAbreParenteses.Font = new Font("Consolas", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnAbreParenteses.Location = new Point(410, 98);
            btnAbreParenteses.Name = "btnAbreParenteses";
            btnAbreParenteses.Size = new Size(93, 79);
            btnAbreParenteses.TabIndex = 15;
            btnAbreParenteses.Text = "(";
            btnAbreParenteses.UseVisualStyleBackColor = false;
            btnAbreParenteses.Click += btnAbreParenteses_Click;
            // 
            // btnMultiplicacao
            // 
            btnMultiplicacao.BackColor = Color.White;
            btnMultiplicacao.FlatStyle = FlatStyle.Flat;
            btnMultiplicacao.Font = new Font("Consolas", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnMultiplicacao.Location = new Point(311, 98);
            btnMultiplicacao.Name = "btnMultiplicacao";
            btnMultiplicacao.Size = new Size(93, 79);
            btnMultiplicacao.TabIndex = 14;
            btnMultiplicacao.Text = "x";
            btnMultiplicacao.UseVisualStyleBackColor = false;
            btnMultiplicacao.Click += btnMultiplicacao_Click;
            // 
            // btn6
            // 
            btn6.BackColor = Color.White;
            btn6.FlatStyle = FlatStyle.Flat;
            btn6.Font = new Font("Consolas", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn6.Location = new Point(212, 98);
            btn6.Name = "btn6";
            btn6.Size = new Size(93, 79);
            btn6.TabIndex = 13;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = false;
            btn6.Click += btn6_Click;
            // 
            // btn5
            // 
            btn5.BackColor = Color.White;
            btn5.FlatStyle = FlatStyle.Flat;
            btn5.Font = new Font("Consolas", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn5.Location = new Point(113, 98);
            btn5.Name = "btn5";
            btn5.Size = new Size(93, 79);
            btn5.TabIndex = 12;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = false;
            btn5.Click += btn5_Click;
            // 
            // btnSqrt
            // 
            btnSqrt.BackColor = Color.White;
            btnSqrt.FlatStyle = FlatStyle.Flat;
            btnSqrt.Font = new Font("Consolas", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnSqrt.Location = new Point(509, 183);
            btnSqrt.Name = "btnSqrt";
            btnSqrt.Size = new Size(93, 79);
            btnSqrt.TabIndex = 11;
            btnSqrt.Text = "√";
            btnSqrt.UseVisualStyleBackColor = false;
            btnSqrt.Click += btnSqrt_Click;
            // 
            // btnElevadoQuadrado
            // 
            btnElevadoQuadrado.BackColor = Color.White;
            btnElevadoQuadrado.FlatStyle = FlatStyle.Flat;
            btnElevadoQuadrado.Font = new Font("Consolas", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnElevadoQuadrado.Location = new Point(410, 183);
            btnElevadoQuadrado.Name = "btnElevadoQuadrado";
            btnElevadoQuadrado.Size = new Size(93, 79);
            btnElevadoQuadrado.TabIndex = 10;
            btnElevadoQuadrado.Text = "x²";
            btnElevadoQuadrado.UseVisualStyleBackColor = false;
            btnElevadoQuadrado.Click += btnElevadoQuadrado_Click;
            // 
            // btnSubtracao
            // 
            btnSubtracao.BackColor = Color.White;
            btnSubtracao.FlatStyle = FlatStyle.Flat;
            btnSubtracao.Font = new Font("Consolas", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnSubtracao.Location = new Point(311, 183);
            btnSubtracao.Name = "btnSubtracao";
            btnSubtracao.Size = new Size(93, 79);
            btnSubtracao.TabIndex = 9;
            btnSubtracao.Text = "-";
            btnSubtracao.UseVisualStyleBackColor = false;
            btnSubtracao.Click += btnSubtracao_Click;
            // 
            // btn3
            // 
            btn3.BackColor = Color.White;
            btn3.FlatStyle = FlatStyle.Flat;
            btn3.Font = new Font("Consolas", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn3.Location = new Point(212, 183);
            btn3.Name = "btn3";
            btn3.Size = new Size(93, 79);
            btn3.TabIndex = 8;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = false;
            btn3.Click += btn3_Click;
            // 
            // btn2
            // 
            btn2.BackColor = Color.White;
            btn2.FlatStyle = FlatStyle.Flat;
            btn2.Font = new Font("Consolas", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn2.Location = new Point(113, 183);
            btn2.Name = "btn2";
            btn2.Size = new Size(93, 79);
            btn2.TabIndex = 7;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = false;
            btn2.Click += btn2_Click;
            // 
            // btnIgual
            // 
            btnIgual.BackColor = Color.Green;
            btnIgual.FlatStyle = FlatStyle.Popup;
            btnIgual.Font = new Font("Consolas", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnIgual.ForeColor = Color.White;
            btnIgual.Location = new Point(410, 268);
            btnIgual.Name = "btnIgual";
            btnIgual.Size = new Size(192, 79);
            btnIgual.TabIndex = 6;
            btnIgual.Text = "=";
            btnIgual.UseVisualStyleBackColor = false;
            btnIgual.Click += btnIgual_Click;
            // 
            // btnAdicao
            // 
            btnAdicao.BackColor = Color.White;
            btnAdicao.FlatStyle = FlatStyle.Flat;
            btnAdicao.Font = new Font("Consolas", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdicao.Location = new Point(311, 268);
            btnAdicao.Name = "btnAdicao";
            btnAdicao.Size = new Size(93, 79);
            btnAdicao.TabIndex = 5;
            btnAdicao.Text = "+";
            btnAdicao.UseVisualStyleBackColor = false;
            btnAdicao.Click += btnAdicao_Click;
            // 
            // btnModulo
            // 
            btnModulo.BackColor = Color.White;
            btnModulo.FlatStyle = FlatStyle.Flat;
            btnModulo.Font = new Font("Consolas", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnModulo.Location = new Point(212, 268);
            btnModulo.Name = "btnModulo";
            btnModulo.RightToLeft = RightToLeft.Yes;
            btnModulo.Size = new Size(93, 79);
            btnModulo.TabIndex = 4;
            btnModulo.Text = "Mod";
            btnModulo.UseVisualStyleBackColor = false;
            btnModulo.Click += btnModulo_Click;
            // 
            // btnDecimal
            // 
            btnDecimal.BackColor = Color.White;
            btnDecimal.FlatStyle = FlatStyle.Flat;
            btnDecimal.Font = new Font("Consolas", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnDecimal.Location = new Point(113, 268);
            btnDecimal.Name = "btnDecimal";
            btnDecimal.Size = new Size(93, 79);
            btnDecimal.TabIndex = 3;
            btnDecimal.Text = ",";
            btnDecimal.UseVisualStyleBackColor = false;
            // 
            // btn4
            // 
            btn4.BackColor = Color.White;
            btn4.FlatStyle = FlatStyle.Flat;
            btn4.Font = new Font("Consolas", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn4.Location = new Point(14, 98);
            btn4.Name = "btn4";
            btn4.Size = new Size(93, 79);
            btn4.TabIndex = 2;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = false;
            btn4.Click += btn4_Click;
            // 
            // btn1
            // 
            btn1.BackColor = Color.White;
            btn1.FlatStyle = FlatStyle.Flat;
            btn1.Font = new Font("Consolas", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn1.Location = new Point(14, 183);
            btn1.Name = "btn1";
            btn1.Size = new Size(93, 79);
            btn1.TabIndex = 1;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = false;
            btn1.Click += btn1_Click;
            // 
            // btn0
            // 
            btn0.BackColor = Color.White;
            btn0.FlatStyle = FlatStyle.Flat;
            btn0.Font = new Font("Consolas", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn0.Location = new Point(14, 268);
            btn0.Name = "btn0";
            btn0.Size = new Size(93, 79);
            btn0.TabIndex = 0;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = false;
            btn0.Click += btn0_Click;
            // 
            // txtHistorico
            // 
            txtHistorico.BackColor = Color.FromArgb(64, 64, 64);
            txtHistorico.BorderStyle = BorderStyle.None;
            txtHistorico.Font = new Font("Consolas", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtHistorico.ForeColor = SystemColors.Menu;
            txtHistorico.Location = new Point(9, 2);
            txtHistorico.Name = "txtHistorico";
            txtHistorico.ReadOnly = true;
            txtHistorico.RightToLeft = RightToLeft.Yes;
            txtHistorico.Size = new Size(588, 162);
            txtHistorico.TabIndex = 3;
            txtHistorico.Text = "";
            // 
            // FrmCalculadora
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(605, 586);
            Controls.Add(txtHistorico);
            Controls.Add(panelBotoes);
            Controls.Add(txtVisor);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "FrmCalculadora";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculadora";
            Shown += FrmCalculadora_Shown;
            KeyDown += FrmCalculadora_KeyDown;
            KeyPress += FrmCalculadora_KeyPress;
            panelBotoes.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panelBotoes;
        private TextBox txtVisor;
        private Button btnLimpar;
        private Button btnBackspace;
        private Button btnDivisao;
        private Button btn9;
        private Button btn8;
        private Button btn7;
        private Button btnFechaParenteses;
        private Button btnAbreParenteses;
        private Button btnMultiplicacao;
        private Button btn6;
        private Button btn5;
        private Button btnSqrt;
        private Button btnElevadoQuadrado;
        private Button btnSubtracao;
        private Button btn3;
        private Button btn2;
        private Button btnIgual;
        private Button btnAdicao;
        private Button btnModulo;
        private Button btnDecimal;
        private Button btn4;
        private Button btn1;
        private Button btn0;
        private RichTextBox txtHistorico;
    }
}

