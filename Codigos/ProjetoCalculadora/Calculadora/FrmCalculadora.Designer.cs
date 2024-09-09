using System.Runtime.InteropServices;
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

        [DllImport("user32.dll")]
        private static extern bool HideCaret(IntPtr hWnd);

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtExpressaoResultado = new System.Windows.Forms.TextBox();
            this.panelBotoes = new System.Windows.Forms.Panel();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnBackspace = new System.Windows.Forms.Button();
            this.btnDivisao = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btnFechaParenteses = new System.Windows.Forms.Button();
            this.btnAbreParenteses = new System.Windows.Forms.Button();
            this.btnMultiplicacao = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.btnElevadoQuadrado = new System.Windows.Forms.Button();
            this.btnSubtracao = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btnIgual = new System.Windows.Forms.Button();
            this.btnAdicao = new System.Windows.Forms.Button();
            this.btnPorcentagem = new System.Windows.Forms.Button();
            this.btnDecimal = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.txtHistorico = new System.Windows.Forms.RichTextBox();
            this.panelBotoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtExpressaoResultado
            // 
            this.txtExpressaoResultado.BackColor = System.Drawing.Color.White;
            this.txtExpressaoResultado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtExpressaoResultado.Font = new System.Drawing.Font("Consolas", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtExpressaoResultado.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtExpressaoResultado.Location = new System.Drawing.Point(6, 134);
            this.txtExpressaoResultado.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtExpressaoResultado.Multiline = true;
            this.txtExpressaoResultado.Name = "txtExpressaoResultado";
            this.txtExpressaoResultado.Size = new System.Drawing.Size(598, 90);
            this.txtExpressaoResultado.TabIndex = 1;
            this.txtExpressaoResultado.Text = "0";
            this.txtExpressaoResultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtExpressaoResultado.TextChanged += new System.EventHandler(this.txtExpressaoResultado_TextChanged);
            this.txtExpressaoResultado.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtExpressaoResultado_KeyDown);
            this.txtExpressaoResultado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtExpressaoResultado_KeyPress);
            // 
            // panelBotoes
            // 
            this.panelBotoes.Controls.Add(this.btnLimpar);
            this.panelBotoes.Controls.Add(this.btnBackspace);
            this.panelBotoes.Controls.Add(this.btnDivisao);
            this.panelBotoes.Controls.Add(this.btn9);
            this.panelBotoes.Controls.Add(this.btn8);
            this.panelBotoes.Controls.Add(this.btn7);
            this.panelBotoes.Controls.Add(this.btnFechaParenteses);
            this.panelBotoes.Controls.Add(this.btnAbreParenteses);
            this.panelBotoes.Controls.Add(this.btnMultiplicacao);
            this.panelBotoes.Controls.Add(this.btn6);
            this.panelBotoes.Controls.Add(this.btn5);
            this.panelBotoes.Controls.Add(this.button11);
            this.panelBotoes.Controls.Add(this.btnElevadoQuadrado);
            this.panelBotoes.Controls.Add(this.btnSubtracao);
            this.panelBotoes.Controls.Add(this.btn3);
            this.panelBotoes.Controls.Add(this.btn2);
            this.panelBotoes.Controls.Add(this.btnIgual);
            this.panelBotoes.Controls.Add(this.btnAdicao);
            this.panelBotoes.Controls.Add(this.btnPorcentagem);
            this.panelBotoes.Controls.Add(this.btnDecimal);
            this.panelBotoes.Controls.Add(this.btn4);
            this.panelBotoes.Controls.Add(this.btn1);
            this.panelBotoes.Controls.Add(this.btn0);
            this.panelBotoes.Location = new System.Drawing.Point(-5, 227);
            this.panelBotoes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panelBotoes.Name = "panelBotoes";
            this.panelBotoes.Size = new System.Drawing.Size(602, 356);
            this.panelBotoes.TabIndex = 2;
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.White;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLimpar.Location = new System.Drawing.Point(509, 13);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(93, 79);
            this.btnLimpar.TabIndex = 22;
            this.btnLimpar.Text = "C";
            this.btnLimpar.UseVisualStyleBackColor = false;
            // 
            // btnBackspace
            // 
            this.btnBackspace.BackColor = System.Drawing.Color.White;
            this.btnBackspace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackspace.Font = new System.Drawing.Font("Consolas", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBackspace.Location = new System.Drawing.Point(410, 13);
            this.btnBackspace.Name = "btnBackspace";
            this.btnBackspace.Size = new System.Drawing.Size(93, 79);
            this.btnBackspace.TabIndex = 21;
            this.btnBackspace.Text = "←";
            this.btnBackspace.UseVisualStyleBackColor = false;
            // 
            // btnDivisao
            // 
            this.btnDivisao.BackColor = System.Drawing.Color.White;
            this.btnDivisao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDivisao.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDivisao.Location = new System.Drawing.Point(311, 13);
            this.btnDivisao.Name = "btnDivisao";
            this.btnDivisao.Size = new System.Drawing.Size(93, 79);
            this.btnDivisao.TabIndex = 20;
            this.btnDivisao.Text = "/";
            this.btnDivisao.UseVisualStyleBackColor = false;
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.Color.White;
            this.btn9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn9.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn9.Location = new System.Drawing.Point(212, 13);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(93, 79);
            this.btn9.TabIndex = 19;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = false;
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.Color.White;
            this.btn8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn8.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn8.Location = new System.Drawing.Point(113, 13);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(93, 79);
            this.btn8.TabIndex = 18;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = false;
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.Color.White;
            this.btn7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn7.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn7.Location = new System.Drawing.Point(14, 13);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(93, 79);
            this.btn7.TabIndex = 17;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = false;
            // 
            // btnFechaParenteses
            // 
            this.btnFechaParenteses.BackColor = System.Drawing.Color.White;
            this.btnFechaParenteses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechaParenteses.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnFechaParenteses.Location = new System.Drawing.Point(509, 98);
            this.btnFechaParenteses.Name = "btnFechaParenteses";
            this.btnFechaParenteses.Size = new System.Drawing.Size(93, 79);
            this.btnFechaParenteses.TabIndex = 16;
            this.btnFechaParenteses.Text = ")";
            this.btnFechaParenteses.UseVisualStyleBackColor = false;
            // 
            // btnAbreParenteses
            // 
            this.btnAbreParenteses.BackColor = System.Drawing.Color.White;
            this.btnAbreParenteses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbreParenteses.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAbreParenteses.Location = new System.Drawing.Point(410, 98);
            this.btnAbreParenteses.Name = "btnAbreParenteses";
            this.btnAbreParenteses.Size = new System.Drawing.Size(93, 79);
            this.btnAbreParenteses.TabIndex = 15;
            this.btnAbreParenteses.Text = "(";
            this.btnAbreParenteses.UseVisualStyleBackColor = false;
            // 
            // btnMultiplicacao
            // 
            this.btnMultiplicacao.BackColor = System.Drawing.Color.White;
            this.btnMultiplicacao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMultiplicacao.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMultiplicacao.Location = new System.Drawing.Point(311, 98);
            this.btnMultiplicacao.Name = "btnMultiplicacao";
            this.btnMultiplicacao.Size = new System.Drawing.Size(93, 79);
            this.btnMultiplicacao.TabIndex = 14;
            this.btnMultiplicacao.Text = "x";
            this.btnMultiplicacao.UseVisualStyleBackColor = false;
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.Color.White;
            this.btn6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn6.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn6.Location = new System.Drawing.Point(212, 98);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(93, 79);
            this.btn6.TabIndex = 13;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = false;
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.Color.White;
            this.btn5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn5.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn5.Location = new System.Drawing.Point(113, 98);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(93, 79);
            this.btn5.TabIndex = 12;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = false;
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.White;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button11.Location = new System.Drawing.Point(509, 183);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(93, 79);
            this.button11.TabIndex = 11;
            this.button11.Text = "√";
            this.button11.UseVisualStyleBackColor = false;
            // 
            // btnElevadoQuadrado
            // 
            this.btnElevadoQuadrado.BackColor = System.Drawing.Color.White;
            this.btnElevadoQuadrado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnElevadoQuadrado.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnElevadoQuadrado.Location = new System.Drawing.Point(410, 183);
            this.btnElevadoQuadrado.Name = "btnElevadoQuadrado";
            this.btnElevadoQuadrado.Size = new System.Drawing.Size(93, 79);
            this.btnElevadoQuadrado.TabIndex = 10;
            this.btnElevadoQuadrado.Text = "x²";
            this.btnElevadoQuadrado.UseVisualStyleBackColor = false;
            // 
            // btnSubtracao
            // 
            this.btnSubtracao.BackColor = System.Drawing.Color.White;
            this.btnSubtracao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubtracao.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSubtracao.Location = new System.Drawing.Point(311, 183);
            this.btnSubtracao.Name = "btnSubtracao";
            this.btnSubtracao.Size = new System.Drawing.Size(93, 79);
            this.btnSubtracao.TabIndex = 9;
            this.btnSubtracao.Text = "-";
            this.btnSubtracao.UseVisualStyleBackColor = false;
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.White;
            this.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn3.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn3.Location = new System.Drawing.Point(212, 183);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(93, 79);
            this.btn3.TabIndex = 8;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = false;
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.White;
            this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn2.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn2.Location = new System.Drawing.Point(113, 183);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(93, 79);
            this.btn2.TabIndex = 7;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = false;
            // 
            // btnIgual
            // 
            this.btnIgual.BackColor = System.Drawing.Color.Green;
            this.btnIgual.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIgual.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnIgual.ForeColor = System.Drawing.Color.White;
            this.btnIgual.Location = new System.Drawing.Point(410, 268);
            this.btnIgual.Name = "btnIgual";
            this.btnIgual.Size = new System.Drawing.Size(192, 79);
            this.btnIgual.TabIndex = 6;
            this.btnIgual.Text = "=";
            this.btnIgual.UseVisualStyleBackColor = false;
            // 
            // btnAdicao
            // 
            this.btnAdicao.BackColor = System.Drawing.Color.White;
            this.btnAdicao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicao.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAdicao.Location = new System.Drawing.Point(311, 268);
            this.btnAdicao.Name = "btnAdicao";
            this.btnAdicao.Size = new System.Drawing.Size(93, 79);
            this.btnAdicao.TabIndex = 5;
            this.btnAdicao.Text = "+";
            this.btnAdicao.UseVisualStyleBackColor = false;
            // 
            // btnPorcentagem
            // 
            this.btnPorcentagem.BackColor = System.Drawing.Color.White;
            this.btnPorcentagem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPorcentagem.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPorcentagem.Location = new System.Drawing.Point(212, 268);
            this.btnPorcentagem.Name = "btnPorcentagem";
            this.btnPorcentagem.Size = new System.Drawing.Size(93, 79);
            this.btnPorcentagem.TabIndex = 4;
            this.btnPorcentagem.Text = "%";
            this.btnPorcentagem.UseVisualStyleBackColor = false;
            // 
            // btnDecimal
            // 
            this.btnDecimal.BackColor = System.Drawing.Color.White;
            this.btnDecimal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDecimal.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDecimal.Location = new System.Drawing.Point(113, 268);
            this.btnDecimal.Name = "btnDecimal";
            this.btnDecimal.Size = new System.Drawing.Size(93, 79);
            this.btnDecimal.TabIndex = 3;
            this.btnDecimal.Text = ",";
            this.btnDecimal.UseVisualStyleBackColor = false;
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.Color.White;
            this.btn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn4.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn4.Location = new System.Drawing.Point(14, 98);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(93, 79);
            this.btn4.TabIndex = 2;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = false;
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.White;
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn1.Location = new System.Drawing.Point(14, 183);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(93, 79);
            this.btn1.TabIndex = 1;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = false;
            // 
            // btn0
            // 
            this.btn0.BackColor = System.Drawing.Color.White;
            this.btn0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn0.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn0.Location = new System.Drawing.Point(14, 268);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(93, 79);
            this.btn0.TabIndex = 0;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = false;
            // 
            // txtHistorico
            // 
            this.txtHistorico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtHistorico.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtHistorico.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtHistorico.ForeColor = System.Drawing.SystemColors.Menu;
            this.txtHistorico.Location = new System.Drawing.Point(6, 2);
            this.txtHistorico.Name = "txtHistorico";
            this.txtHistorico.ReadOnly = true;
            this.txtHistorico.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtHistorico.Size = new System.Drawing.Size(591, 126);
            this.txtHistorico.TabIndex = 3;
            this.txtHistorico.Text = "";
            // 
            // FrmCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(605, 579);
            this.Controls.Add(this.txtHistorico);
            this.Controls.Add(this.panelBotoes);
            this.Controls.Add(this.txtExpressaoResultado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "FrmCalculadora";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora";
            this.Shown += new System.EventHandler(this.FrmCalculadora_Shown);
            this.panelBotoes.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        //private void CreateCalculatorNumericButtons()
        //{
        //    int numRows = 6; // Número de linhas.
        //    int numCols = 3; // Número de colunas.
        //    int padding = 2; // Espaço entre os botões.

        //    // Calcula a largura e a altura de cada botão.
        //    int buttonWidth = (panelBotoes.Width - (padding * (numCols - 1))) / numCols;
        //    int buttonHeight = (panelBotoes.Height - (padding * (numRows - 1))) / numRows;

        //    for (int i = 0; i <= 9; i++)
        //    {
        //        Button btn = new Button
        //        {
        //            TabIndex = 0,
        //            Text = i.ToString(),
        //            Name = $"btn{i.ToString()}",
        //            Width = buttonWidth,
        //            Height = buttonHeight,
        //            BackColor = System.Drawing.Color.Gray,
        //            BackgroundImageLayout = ImageLayout.None,
        //            FlatStyle = FlatStyle.Flat,
        //            Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0))),
        //            ForeColor = System.Drawing.Color.White,
        //            Location = new System.Drawing.Point((i % numCols) * (buttonWidth + padding), (i / numCols) * (buttonHeight + padding)),
        //            UseVisualStyleBackColor = false,
        //        };

        //        btn.FlatAppearance.BorderSize = 0;
                
        //        // Eventos.
        //        btn.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
        //        btn.MouseHover += new System.EventHandler(this.btn_MouseHover);
        //        btn.MouseClick += new MouseEventHandler(this.btn_MouseClick);
                
        //        // Adiciona o botão na tela.
        //        panelBotoes.Controls.Add(btn);
        //    }
        //}

        //private string NumericButtonInvoked(object sender)
        //{
        //    Button btn = sender as Button;
        //    return btn.Name[btn.Name.Length - 1].ToString();
        //}

        //private void btn_MouseClick(object sender, MouseEventArgs e)
        //{
        //    var numero = NumericButtonInvoked(sender);
        //    if (txtExpressaoResultado.Text == "0")
        //        txtExpressaoResultado.Text = numero;
        //    else
        //        txtExpressaoResultado.Text += numero.ToString();

        //}

        #endregion
        private Panel panelBotoes;
        private TextBox txtExpressaoResultado;
        private RichTextBox txtHistorico;
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
        private Button button11;
        private Button btnElevadoQuadrado;
        private Button btnSubtracao;
        private Button btn3;
        private Button btn2;
        private Button btnIgual;
        private Button btnAdicao;
        private Button btnPorcentagem;
        private Button btnDecimal;
        private Button btn4;
        private Button btn1;
        private Button btn0;
    }
}

