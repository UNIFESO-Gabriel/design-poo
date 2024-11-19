namespace Calculadora_V0
{
    partial class frmCalculadora
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        private void AssignEventHandlerToDigitButtons()
        {
            foreach (var control in this.Controls)
            {
                if (control.GetType() == typeof(Button) &&
                    char.IsDigit(((Button)control).Name.Last()))
                {
                    ((Button)control).Click += btn_CapturaDigito;
                }
            }
        }

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCalculadora));
            txtVisor = new RichTextBox();
            btnEnter = new Button();
            btnLimpar = new Button();
            btn9 = new Button();
            btn8 = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btn7 = new Button();
            btn3 = new Button();
            btn2 = new Button();
            btn1 = new Button();
            btn0 = new Button();
            grpBotoesRadio = new GroupBox();
            radioDivisao = new RadioButton();
            radioMultiplicacao = new RadioButton();
            radioSubtracao = new RadioButton();
            radioAdicao = new RadioButton();
            grpBotoesRadio.SuspendLayout();
            SuspendLayout();
            // 
            // txtVisor
            // 
            txtVisor.BackColor = Color.Black;
            txtVisor.BorderStyle = BorderStyle.FixedSingle;
            txtVisor.Font = new Font("Arial", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtVisor.ForeColor = Color.White;
            txtVisor.Location = new Point(-1, 1);
            txtVisor.Multiline = false;
            txtVisor.Name = "txtVisor";
            txtVisor.ReadOnly = true;
            txtVisor.RightToLeft = RightToLeft.Yes;
            txtVisor.Size = new Size(428, 48);
            txtVisor.TabIndex = 0;
            txtVisor.TabStop = false;
            txtVisor.Text = "0";
            // 
            // btnEnter
            // 
            btnEnter.BackColor = Color.Aquamarine;
            btnEnter.BackgroundImageLayout = ImageLayout.Center;
            btnEnter.FlatStyle = FlatStyle.Flat;
            btnEnter.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEnter.Location = new Point(322, 108);
            btnEnter.Name = "btnEnter";
            btnEnter.Size = new Size(100, 100);
            btnEnter.TabIndex = 1;
            btnEnter.Text = "Enter";
            btnEnter.UseVisualStyleBackColor = false;
            btnEnter.Click += btnEnter_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.BackColor = Color.LightCoral;
            btnLimpar.BackgroundImageLayout = ImageLayout.Center;
            btnLimpar.FlatStyle = FlatStyle.Flat;
            btnLimpar.Font = new Font("Arial", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpar.Location = new Point(216, 108);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(100, 100);
            btnLimpar.TabIndex = 2;
            btnLimpar.Text = "C";
            btnLimpar.UseVisualStyleBackColor = false;
            btnLimpar.Click += this.btnLimpar_Click;
            // 
            // btn9
            // 
            btn9.BackColor = Color.Silver;
            btn9.BackgroundImageLayout = ImageLayout.Center;
            btn9.FlatStyle = FlatStyle.Flat;
            btn9.Font = new Font("Arial", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn9.Location = new Point(110, 108);
            btn9.Name = "btn9";
            btn9.Size = new Size(100, 100);
            btn9.TabIndex = 3;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = false;
            // 
            // btn8
            // 
            btn8.BackColor = Color.Silver;
            btn8.BackgroundImageLayout = ImageLayout.Center;
            btn8.FlatStyle = FlatStyle.Flat;
            btn8.Font = new Font("Arial", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn8.Location = new Point(4, 108);
            btn8.Name = "btn8";
            btn8.Size = new Size(100, 100);
            btn8.TabIndex = 4;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = false;
            // 
            // btn4
            // 
            btn4.BackColor = Color.Silver;
            btn4.BackgroundImageLayout = ImageLayout.Center;
            btn4.FlatStyle = FlatStyle.Flat;
            btn4.Font = new Font("Arial", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn4.Location = new Point(4, 214);
            btn4.Name = "btn4";
            btn4.Size = new Size(100, 100);
            btn4.TabIndex = 5;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = false;
            // 
            // btn5
            // 
            btn5.BackColor = Color.Silver;
            btn5.BackgroundImageLayout = ImageLayout.Center;
            btn5.FlatStyle = FlatStyle.Flat;
            btn5.Font = new Font("Arial", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn5.Location = new Point(110, 214);
            btn5.Name = "btn5";
            btn5.Size = new Size(100, 100);
            btn5.TabIndex = 6;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = false;
            // 
            // btn6
            // 
            btn6.BackColor = Color.Silver;
            btn6.BackgroundImageLayout = ImageLayout.Center;
            btn6.FlatStyle = FlatStyle.Flat;
            btn6.Font = new Font("Arial", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn6.Location = new Point(216, 214);
            btn6.Name = "btn6";
            btn6.Size = new Size(100, 100);
            btn6.TabIndex = 7;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = false;
            // 
            // btn7
            // 
            btn7.BackColor = Color.Silver;
            btn7.BackgroundImageLayout = ImageLayout.Center;
            btn7.FlatStyle = FlatStyle.Flat;
            btn7.Font = new Font("Arial", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn7.Location = new Point(322, 214);
            btn7.Name = "btn7";
            btn7.Size = new Size(100, 100);
            btn7.TabIndex = 8;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = false;
            // 
            // btn3
            // 
            btn3.BackColor = Color.Silver;
            btn3.BackgroundImageLayout = ImageLayout.Center;
            btn3.FlatStyle = FlatStyle.Flat;
            btn3.Font = new Font("Arial", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn3.Location = new Point(322, 320);
            btn3.Name = "btn3";
            btn3.Size = new Size(100, 100);
            btn3.TabIndex = 12;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = false;
            // 
            // btn2
            // 
            btn2.BackColor = Color.Silver;
            btn2.BackgroundImageLayout = ImageLayout.Center;
            btn2.FlatStyle = FlatStyle.Flat;
            btn2.Font = new Font("Arial", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn2.Location = new Point(216, 320);
            btn2.Name = "btn2";
            btn2.Size = new Size(100, 100);
            btn2.TabIndex = 11;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = false;
            // 
            // btn1
            // 
            btn1.BackColor = Color.Silver;
            btn1.BackgroundImageLayout = ImageLayout.Center;
            btn1.FlatStyle = FlatStyle.Flat;
            btn1.Font = new Font("Arial", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn1.Location = new Point(110, 320);
            btn1.Name = "btn1";
            btn1.Size = new Size(100, 100);
            btn1.TabIndex = 10;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = false;
            // 
            // btn0
            // 
            btn0.BackColor = Color.Silver;
            btn0.BackgroundImageLayout = ImageLayout.Center;
            btn0.FlatStyle = FlatStyle.Flat;
            btn0.Font = new Font("Arial", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn0.Location = new Point(4, 320);
            btn0.Name = "btn0";
            btn0.Size = new Size(100, 100);
            btn0.TabIndex = 9;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = false;
            // 
            // grpBotoesRadio
            // 
            grpBotoesRadio.BackColor = Color.Transparent;
            grpBotoesRadio.BackgroundImageLayout = ImageLayout.None;
            grpBotoesRadio.Controls.Add(radioDivisao);
            grpBotoesRadio.Controls.Add(radioMultiplicacao);
            grpBotoesRadio.Controls.Add(radioSubtracao);
            grpBotoesRadio.Controls.Add(radioAdicao);
            grpBotoesRadio.ForeColor = SystemColors.ControlText;
            grpBotoesRadio.Location = new Point(-1, 40);
            grpBotoesRadio.Margin = new Padding(0);
            grpBotoesRadio.Name = "grpBotoesRadio";
            grpBotoesRadio.Padding = new Padding(10);
            grpBotoesRadio.Size = new Size(428, 65);
            grpBotoesRadio.TabIndex = 13;
            grpBotoesRadio.TabStop = false;
            // 
            // radioDivisao
            // 
            radioDivisao.AutoSize = true;
            radioDivisao.Font = new Font("Arial", 11.25F, FontStyle.Bold);
            radioDivisao.ForeColor = Color.White;
            radioDivisao.Location = new Point(342, 23);
            radioDivisao.Name = "radioDivisao";
            radioDivisao.Size = new Size(79, 22);
            radioDivisao.TabIndex = 3;
            radioDivisao.Text = "Divisão";
            radioDivisao.UseVisualStyleBackColor = true;
            // 
            // radioMultiplicacao
            // 
            radioMultiplicacao.AutoSize = true;
            radioMultiplicacao.Font = new Font("Arial", 11.25F, FontStyle.Bold);
            radioMultiplicacao.ForeColor = Color.White;
            radioMultiplicacao.Location = new Point(208, 23);
            radioMultiplicacao.Name = "radioMultiplicacao";
            radioMultiplicacao.Size = new Size(119, 22);
            radioMultiplicacao.TabIndex = 2;
            radioMultiplicacao.Text = "Multiplicação";
            radioMultiplicacao.UseVisualStyleBackColor = true;
            // 
            // radioSubtracao
            // 
            radioSubtracao.AutoSize = true;
            radioSubtracao.Font = new Font("Arial", 11.25F, FontStyle.Bold);
            radioSubtracao.ForeColor = Color.White;
            radioSubtracao.Location = new Point(95, 23);
            radioSubtracao.Name = "radioSubtracao";
            radioSubtracao.Size = new Size(98, 22);
            radioSubtracao.TabIndex = 1;
            radioSubtracao.Text = "Subtração";
            radioSubtracao.UseVisualStyleBackColor = true;
            // 
            // radioAdicao
            // 
            radioAdicao.AutoSize = true;
            radioAdicao.Checked = true;
            radioAdicao.Font = new Font("Arial", 11.25F, FontStyle.Bold);
            radioAdicao.ForeColor = Color.White;
            radioAdicao.Location = new Point(9, 23);
            radioAdicao.Name = "radioAdicao";
            radioAdicao.Size = new Size(73, 22);
            radioAdicao.TabIndex = 0;
            radioAdicao.TabStop = true;
            radioAdicao.Text = "Adição";
            radioAdicao.UseVisualStyleBackColor = true;
            // 
            // frmCalculadora
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(425, 428);
            Controls.Add(grpBotoesRadio);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(btn0);
            Controls.Add(btn7);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btn8);
            Controls.Add(btn9);
            Controls.Add(btnLimpar);
            Controls.Add(btnEnter);
            Controls.Add(txtVisor);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "frmCalculadora";
            Text = "Calculadora Básica";
            grpBotoesRadio.ResumeLayout(false);
            grpBotoesRadio.PerformLayout();
            ResumeLayout(false);
            AssignEventHandlerToDigitButtons();
        }

        #endregion

        private RichTextBox txtVisor;
        private Button btnEnter;
        private Button btnLimpar;
        private Button btn9;
        private Button btn8;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btn7;
        private Button btn3;
        private Button btn2;
        private Button btn1;
        private Button btn0;
        private GroupBox grpBotoesRadio;
        private RadioButton radioAdicao;
        private RadioButton radioSubtracao;
        private RadioButton radioDivisao;
        private RadioButton radioMultiplicacao;
    }
}
