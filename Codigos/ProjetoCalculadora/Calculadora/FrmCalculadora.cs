using NCalc;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;

namespace Calculadora
{
    public partial class FrmCalculadora : Form
    {
        private bool calculouExpressao = false;
        private readonly List<char> listaCaracteresPermitidos = new() { ',', '(', ')', '*', '/', '+', '-', '%', '^' };

        [DllImport("user32.dll")]
        private static extern bool HideCaret(IntPtr hWnd);

        private void EsconderCursorTxtVisor()
        {
            txtVisor.GotFocus += (s, e) => HideCaret(txtVisor.Handle);
            txtVisor.MouseDown += (s, e) => HideCaret(txtVisor.Handle);
            txtVisor.KeyUp += (s, e) => HideCaret(txtVisor.Handle);
        }

        private string ParseExpression(string input)
        {
            input = input.Replace(',', '.').Replace(" Mod ", "%");

            var powerPattern = @"((?:\-?\d+\.?\d*|\-?\((?:[^()]+|\((?:[^()]+|\([^()]*\))*\))*\)|[a-zA-Z]+\((?:[^()]+|\((?:[^()]+|\([^()]*\))*\))*\)))\s*\^\s*((?:\-?\d+\.?\d*|\-?\((?:[^()]+|\((?:[^()]+|\([^()]*\))*\))*\)|[a-zA-Z]+\((?:[^()]+|\((?:[^()]+|\([^()]*\))*\))*\)))";

            input = Regex.Replace(input, powerPattern, "Pow($1, $2)");
            input = ProcessSquareRoots(input);

            return input;
        }

        private string ProcessSquareRoots(string input)
        {

            return Regex.Replace(input, @"√(\((?:[^()]+|\([^()]*\))*\)|\d+\.?\d*|[a-zA-Z]+)", match =>
            {
                string innerExpression = match.Groups[1].Value;
                if (innerExpression.Contains("√"))
                {
                    // Processa recursivamente as raízes quadradas aninhadas.
                    innerExpression = ProcessSquareRoots(innerExpression);
                }
                return $"Sqrt({innerExpression})";
            });
        }

        public FrmCalculadora()
        {
            InitializeComponent();
            EsconderCursorTxtVisor();
            this.KeyPreview = true;
        }

        private void FrmCalculadora_Shown(object sender, EventArgs e)
        {

            this.txtVisor.SelectionStart = txtVisor.Text.Length; // Move o cursor para o final.
            txtVisor.SelectionLength = 0; // Remove qualquer seleção inicial do texto.
            this.txtVisor.Focus();
        }

        private void btn_MouseHover(object sender, EventArgs e)
        {
            this.ForeColor = Color.DarkGray;
        }

        private void btn_MouseLeave(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = Color.Gray;
            btn.FlatAppearance.BorderSize = 0;
            btn.FlatStyle = FlatStyle.Flat;
            btn.Font = new Font("Consolas", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
        }


        private void txtVisor_KeyDown(object sender, KeyEventArgs e)
        {
            var txtVisor = (TextBox)sender;
            if ((e.KeyCode == Keys.Back || e.KeyCode == Keys.Delete) &&
                (txtVisor.Text == "0" || (txtVisor.SelectionStart == 0 && txtVisor.SelectionLength == txtVisor.Text.Length)))
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void txtVisor_TextChanged(object sender, EventArgs e)
        {
            var txtVisor = (TextBox)sender;

            HideCaret(txtVisor.Handle);

            if (string.IsNullOrEmpty(txtVisor.Text))
            {
                txtVisor.Text = "0";
                txtVisor.SelectionStart = txtVisor.Text.Length;
            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (!txtVisor.Text.All(x => x == '0'))
                txtVisor.Text += '0';
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            // Se o texto atual for "0" e um novo dígito for digitado, substitui o "0"
            if (txtVisor.Text == "0")
            {
                txtVisor.Text = "1";
                txtVisor.SelectionStart = txtVisor.Text.Length;
            }
            else if (calculouExpressao)
            {
                txtVisor.Text = "1";
                calculouExpressao = false;
            }
            else
                txtVisor.Text += '1';
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            // Se o texto atual for "0" e um novo dígito for digitado, substitui o "0"
            if (txtVisor.Text == "0")
            {
                txtVisor.Text = "2";
                txtVisor.SelectionStart = txtVisor.Text.Length;
            }
            else if (calculouExpressao)
            {
                txtVisor.Text = "2";
                calculouExpressao = false;
            }
            else
                txtVisor.Text += '2';
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            // Se o texto atual for "0" e um novo dígito for digitado, substitui o "0"
            if (txtVisor.Text == "0")
            {
                txtVisor.Text = "3";
                txtVisor.SelectionStart = txtVisor.Text.Length;
            }
            else if (calculouExpressao)
            {
                txtVisor.Text = "3";
                calculouExpressao = false;
            }
            else
                txtVisor.Text += '3';
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            // Se o texto atual for "0" e um novo dígito for digitado, substitui o "0"
            if (txtVisor.Text == "0")
            {
                txtVisor.Text = "4";
                txtVisor.SelectionStart = txtVisor.Text.Length;
            }
            else if (calculouExpressao)
            {
                txtVisor.Text = "4";
                calculouExpressao = false;
            }
            else
                txtVisor.Text += '4';
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            // Se o texto atual for "0" e um novo dígito for digitado, substitui o "0"
            if (txtVisor.Text == "0")
            {
                txtVisor.Text = "5";
                txtVisor.SelectionStart = txtVisor.Text.Length;
            }
            else if (calculouExpressao)
            {
                txtVisor.Text = "5";
                calculouExpressao = false;
            }
            else
                txtVisor.Text += '5';
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            // Se o texto atual for "0" e um novo dígito for digitado, substitui o "0"
            if (txtVisor.Text == "0")
            {
                txtVisor.Text = "6";
                txtVisor.SelectionStart = txtVisor.Text.Length;
            }
            else if (calculouExpressao)
            {
                txtVisor.Text = "6";
                calculouExpressao = false;
            }
            else
                txtVisor.Text += '6';
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            // Se o texto atual for "0" e um novo dígito for digitado, substitui o "0"
            if (txtVisor.Text == "0")
            {
                txtVisor.Text = "7";
                txtVisor.SelectionStart = txtVisor.Text.Length;
            }
            else if (calculouExpressao)
            {
                txtVisor.Text = "7";
                calculouExpressao = false;
            }
            else
                txtVisor.Text += '7';
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            // Se o texto atual for "0" e um novo dígito for digitado, substitui o "0"
            if (txtVisor.Text == "0")
            {
                txtVisor.Text = "8";
                txtVisor.SelectionStart = txtVisor.Text.Length;
            }
            else if (calculouExpressao)
            {
                txtVisor.Text = "8";
                calculouExpressao = false;
            }
            else
                txtVisor.Text += '8';
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            // Se o texto atual for "0" e um novo dígito for digitado, substitui o "0"
            if (txtVisor.Text == "0")
            {
                txtVisor.Text = "9";
                txtVisor.SelectionStart = txtVisor.Text.Length;
            }
            else if (calculouExpressao)
            {
                txtVisor.Text = "9";
                calculouExpressao = false;
            }
            else
                txtVisor.Text += '9';
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            if (calculouExpressao)
            {
                txtVisor.Text += '/';
                calculouExpressao = false;
            }
            // precisa haver um número antes para inserir o símbolo de divisão.
            if (txtVisor.Text.Length > 0)
                txtVisor.Text += '/';
        }

        private void btnMultiplicacao_Click(object sender, EventArgs e)
        {
            if (calculouExpressao)
            {
                txtVisor.Text += '*';
                calculouExpressao = false;
            }
            if (txtVisor.Text.Length > 0)
                txtVisor.Text += '*';
        }

        private void btnSubtracao_Click(object sender, EventArgs e)
        {
            if (calculouExpressao)
            {
                txtVisor.Text += '-';
                calculouExpressao = false;
            }
            if (txtVisor.Text.Length > 0)
                txtVisor.Text += '-';
        }

        private void btnAdicao_Click(object sender, EventArgs e)
        {
            if (calculouExpressao)
            {
                txtVisor.Text += '+';
                calculouExpressao = false;
            }
            else if (txtVisor.Text.Length > 0)
                txtVisor.Text += '+';
        }

        private void btnElevadoQuadrado_Click(object sender, EventArgs e)
        {
            if (calculouExpressao)
            {
                txtVisor.Text += "^2";
                calculouExpressao = false;
            }
            else if (txtVisor.Text.Length > 0)
                txtVisor.Text += "^2";

        }

        private void btnSqrt_Click(object sender, EventArgs e)
        {
            if (calculouExpressao)
            {
                txtVisor.Text += "√";
                calculouExpressao = false;
            }
            else if (txtVisor.Text == "0")
                txtVisor.Text = "√";
            else
                txtVisor.Text += "√";
        }

        private void btnAbreParenteses_Click(object sender, EventArgs e)
        {
            if (calculouExpressao)
            {
                txtVisor.Text += "(";
                calculouExpressao = false;
            }
            else if (txtVisor.Text == "0")
                txtVisor.Text = "(";
            else
                txtVisor.Text += "(";
        }

        private void btnFechaParenteses_Click(object sender, EventArgs e)
        {
            if (txtVisor.Text.Any(x => x == '('))
            {
                if (calculouExpressao)
                {
                    txtVisor.Text += ")";
                    calculouExpressao = false;
                }
                else
                    txtVisor.Text += ')';
            }
        }

        private void btnBackspace_Click(object sender, EventArgs e)
        {
            txtVisor.Text = txtVisor.Text.Remove(txtVisor.Text.Length - 1);
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtVisor.Text = "";
            if (calculouExpressao)
            {
                calculouExpressao = false;
            }
        }

        private void btnModulo_Click(object sender, EventArgs e)
        {
            if (calculouExpressao)
            {
                txtVisor.Text += " Mod ";
                calculouExpressao = false;
            }
            else if (txtVisor.Text.Length > 0)
            {
                txtVisor.Text += " Mod ";
            }
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            try
            {
                var exp = ParseExpression(txtVisor.Text);
                var expression = new Expression(exp);
                txtVisor.Text = expression.Evaluate().ToString();
                calculouExpressao = true;
            }

            catch (EvaluationException ex)
            {
                MessageBox.Show($"Houve um erro durante o cálculo da expressão: {ex.Message}");
                txtVisor.Text = "0";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro inesperado: {ex.Message}");
                txtVisor.Text = "0";
            }
        }

        private void FrmCalculadora_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Handle regular key presses (digits and operators)
            if (char.IsDigit(e.KeyChar) || listaCaracteresPermitidos.Contains(e.KeyChar))
            {
                // If the current text is "0" and a digit is pressed, replace the "0"
                if (txtVisor.Text == "0" && char.IsDigit(e.KeyChar))
                {
                    txtVisor.Text = e.KeyChar.ToString();
                }
                // If the current text is "0" and an operator is pressed, add it after the "0"
                else if (txtVisor.Text == "0" && listaCaracteresPermitidos.Contains(e.KeyChar))
                {
                    txtVisor.Text += e.KeyChar;
                }
                // If the expression was already calculated, start a new one unless it is a digit.
                else if (calculouExpressao && char.IsDigit(e.KeyChar) && !txtVisor.Text.Any(x => char.IsDigit(x)))
                {
                    txtVisor.Text = e.KeyChar.ToString();
                    calculouExpressao = false;
                }
                else
                    txtVisor.Text += e.KeyChar;

                txtVisor.SelectionStart = txtVisor.Text.Length;
                e.Handled = true;
            }
        }

        private void FrmCalculadora_KeyDown(object sender, KeyEventArgs e)
        {
            // se a tecla Backspace for pressionada, remove o último caractere
            if (e.KeyCode == Keys.Back)
            {
                if (txtVisor.Text.Length > 0)
                {
                    txtVisor.Text = txtVisor.Text.Remove(txtVisor.Text.Length - 1);
                    txtVisor.SelectionStart = txtVisor.Text.Length;
                    calculouExpressao = false;
                }
                e.Handled = true;
                e.SuppressKeyPress = true;
                return;
            }

            // Se a tecla Enter for pressionada, calcula a expressão
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    var exp = ParseExpression(txtVisor.Text);
                    var expression = new Expression(exp);
                    txtVisor.Text = expression.Evaluate().ToString();
                    txtVisor.SelectionStart = txtVisor.Text.Length;
                    calculouExpressao = true;
                }

                catch (EvaluationException ex)
                {
                    MessageBox.Show($"Houve um erro durante o cálculo da expressão: {ex.Message}");
                    txtVisor.Text = "0";
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro inesperado: {ex.Message}");
                    txtVisor.Text = "0";
                }
            }
        }
    }
}
