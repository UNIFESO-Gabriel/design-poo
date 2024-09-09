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
            this.txtHistorico = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // txtExpressaoResultado
            // 
            this.txtExpressaoResultado.BackColor = System.Drawing.Color.DarkGray;
            this.txtExpressaoResultado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtExpressaoResultado.Font = new System.Drawing.Font("Consolas", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtExpressaoResultado.ForeColor = System.Drawing.SystemColors.Window;
            this.txtExpressaoResultado.Location = new System.Drawing.Point(-5, 153);
            this.txtExpressaoResultado.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtExpressaoResultado.Multiline = true;
            this.txtExpressaoResultado.Name = "txtExpressaoResultado";
            this.txtExpressaoResultado.Size = new System.Drawing.Size(658, 93);
            this.txtExpressaoResultado.TabIndex = 1;
            this.txtExpressaoResultado.Text = "0";
            this.txtExpressaoResultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtExpressaoResultado.TextChanged += new System.EventHandler(this.txtExpressaoResultado_TextChanged);
            this.txtExpressaoResultado.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtExpressaoResultado_KeyDown);
            this.txtExpressaoResultado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtExpressaoResultado_KeyPress);
            // 
            // panelBotoes
            // 
            this.panelBotoes.Location = new System.Drawing.Point(-5, 241);
            this.panelBotoes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panelBotoes.Name = "panelBotoes";
            this.panelBotoes.Size = new System.Drawing.Size(658, 339);
            this.panelBotoes.TabIndex = 2;
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
            this.txtHistorico.Size = new System.Drawing.Size(641, 154);
            this.txtHistorico.TabIndex = 3;
            this.txtHistorico.Text = "";
            // 
            // FrmCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(650, 579);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void CreateCalculatorNumericButtons()
        {
            int numRows = 6; // Número de linhas.
            int numCols = 3; // Número de colunas.
            int padding = 2; // Espaço entre os botões.

            // Calcula a largura e a altura de cada botão.
            int buttonWidth = (panelBotoes.Width - (padding * (numCols - 1))) / numCols;
            int buttonHeight = (panelBotoes.Height - (padding * (numRows - 1))) / numRows;

            for (int i = 0; i <= 9; i++)
            {
                Button btn = new Button
                {
                    TabIndex = 0,
                    Text = i.ToString(),
                    Name = $"btn{i.ToString()}",
                    Width = buttonWidth,
                    Height = buttonHeight,
                    BackColor = System.Drawing.Color.Gray,
                    BackgroundImageLayout = ImageLayout.None,
                    FlatStyle = FlatStyle.Flat,
                    Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0))),
                    ForeColor = System.Drawing.Color.White,
                    Location = new System.Drawing.Point((i % numCols) * (buttonWidth + padding), (i / numCols) * (buttonHeight + padding)),
                    UseVisualStyleBackColor = false,
                };

                btn.FlatAppearance.BorderSize = 0;
                
                // Eventos.
                btn.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
                btn.MouseHover += new System.EventHandler(this.btn_MouseHover);
                btn.MouseClick += new MouseEventHandler(this.btn_MouseClick);
                
                // Adiciona o botão na tela.
                panelBotoes.Controls.Add(btn);
            }
        }

        private string NumericButtonInvoked(object sender)
        {
            Button btn = sender as Button;
            return btn.Name[btn.Name.Length - 1].ToString();
        }

        private void btn_MouseClick(object sender, MouseEventArgs e)
        {
            var numero = NumericButtonInvoked(sender);
            if (txtExpressaoResultado.Text == "0")
                txtExpressaoResultado.Text = numero;
            else
                txtExpressaoResultado.Text += numero.ToString();

        }

        #endregion
        private Panel panelBotoes;
        private TextBox txtExpressaoResultado;
        private RichTextBox txtHistorico;
    }
}

