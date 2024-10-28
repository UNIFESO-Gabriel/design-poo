using NCalc;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;

namespace Calculadora
{
    public partial class FrmCalculadora : Form
    {
        private bool calculouExpressao = false;
        private readonly Label focusKeeper;
        private readonly List<char> listaCaracteresPermitidos = new() { ',', '(', ')', '*', '/', '+', '-', '%', '^' };

        [DllImport("user32.dll")]
        private static extern bool HideCaret(IntPtr hWnd);

        private void HideCaretTxtVisor()
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
                    innerExpression = ProcessSquareRoots(innerExpression);
                }
                return $"Sqrt({innerExpression})";
            });
        }

        private void AddToHistory(string expression, string result)
        {
            string item = $"{expression.PadRight(expression.Length + 16)}= {result}";
            lvHistorico.Items.Insert(0, new ListViewItem(item));
        }

        public FrmCalculadora()
        {
            InitializeComponent();
            HideCaretTxtVisor();
            this.KeyPreview = true;

            focusKeeper = new Label
            {
                Location = new Point(-1000, -1000),
                Size = new Size(1, 1),
                TabStop = true
            };
            this.Controls.Add(focusKeeper);

            foreach (Control control in this.Controls)
            {
                if (control is Button)
                {
                    ((Button)control).TabStop = false;
                }
            }
        }

        private void FrmCalculadora_Shown(object sender, EventArgs e)
        {
            this.txtVisor.SelectionStart = txtVisor.Text.Length;
            txtVisor.SelectionLength = 0;
            focusKeeper.Focus();
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

        private void AtualizarVisor(char digito)
        {
            if (calculouExpressao)
            {
                txtVisor.Text = digito.ToString();
                calculouExpressao = false;
            }
            else if (txtVisor.Text == "0")
            {
                txtVisor.Text = digito.ToString();
            }
            else
            {
                txtVisor.Text += digito;
            }
            focusKeeper.Focus();
        }

        private void btn0_Click(object sender, EventArgs e) => AtualizarVisor('0');
        private void btn1_Click(object sender, EventArgs e) => AtualizarVisor('1');
        private void btn2_Click(object sender, EventArgs e) => AtualizarVisor('2');
        private void btn3_Click(object sender, EventArgs e) => AtualizarVisor('3');
        private void btn4_Click(object sender, EventArgs e) => AtualizarVisor('4');
        private void btn5_Click(object sender, EventArgs e) => AtualizarVisor('5');
        private void btn6_Click(object sender, EventArgs e) => AtualizarVisor('6');
        private void btn7_Click(object sender, EventArgs e) => AtualizarVisor('7');
        private void btn8_Click(object sender, EventArgs e) => AtualizarVisor('8');
        private void btn9_Click(object sender, EventArgs e) => AtualizarVisor('9');

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            if (calculouExpressao || txtVisor.Text.Length > 0)
            {
                txtVisor.Text += '/';
                calculouExpressao = false;
            }
            focusKeeper.Focus();
        }

        private void btnMultiplicacao_Click(object sender, EventArgs e)
        {
            if (calculouExpressao || txtVisor.Text.Length > 0)
            {
                txtVisor.Text += '*';
                calculouExpressao = false;
            }
            focusKeeper.Focus();
        }

        private void btnSubtracao_Click(object sender, EventArgs e)
        {
            if (calculouExpressao || txtVisor.Text.Length > 0)
            {
                txtVisor.Text += '-';
                calculouExpressao = false;
            }
            focusKeeper.Focus();
        }

        private void btnAdicao_Click(object sender, EventArgs e)
        {
            if (calculouExpressao || txtVisor.Text.Length > 0)
            {
                txtVisor.Text += '+';
                calculouExpressao = false;
            }
            focusKeeper.Focus();
        }

        private void btnElevadoQuadrado_Click(object sender, EventArgs e)
        {
            if (calculouExpressao || txtVisor.Text.Length > 0)
            {
                txtVisor.Text += "^2";
                calculouExpressao = false;
            }
            focusKeeper.Focus();
        }

        private void btnSqrt_Click(object sender, EventArgs e)
        {
            if (calculouExpressao)
            {
                txtVisor.Text = "√";
                calculouExpressao = false;
            }
            else if (txtVisor.Text == "0")
            {
                txtVisor.Text = "√";
            }
            else
            {
                txtVisor.Text += "√";
            }
            focusKeeper.Focus();
        }

        private void btnAbreParenteses_Click(object sender, EventArgs e)
        {
            if (calculouExpressao)
            {
                txtVisor.Text = "(";
                calculouExpressao = false;
            }
            else if (txtVisor.Text == "0")
            {
                txtVisor.Text = "(";
            }
            else
            {
                txtVisor.Text += "(";
            }
            focusKeeper.Focus();
        }

        private void btnFechaParenteses_Click(object sender, EventArgs e)
        {
            if (txtVisor.Text.Any(x => x == '('))
            {
                if (calculouExpressao)
                {
                    txtVisor.Text = ")";
                    calculouExpressao = false;
                }
                else
                {
                    txtVisor.Text += ')';
                }
            }
            focusKeeper.Focus();
        }

        private void btnBackspace_Click(object sender, EventArgs e)
        {
            if (txtVisor.Text.Length > 0)
            {
                txtVisor.Text = txtVisor.Text.Remove(txtVisor.Text.Length - 1);
            }
            focusKeeper.Focus();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtVisor.Text = "0";
            calculouExpressao = false;
            focusKeeper.Focus();
        }

        private void btnModulo_Click(object sender, EventArgs e)
        {
            if (calculouExpressao || txtVisor.Text.Length > 0)
            {
                txtVisor.Text += " Mod ";
                calculouExpressao = false;
            }
            focusKeeper.Focus();
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            try
            {
                var raw_exp = txtVisor.Text;
                var exp = ParseExpression(txtVisor.Text);
                var expression = new NCalc.Expression(exp);
                txtVisor.Text = expression.Evaluate().ToString();
                AddToHistory(raw_exp, txtVisor.Text);
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
            focusKeeper.Focus();
        }

        private void FrmCalculadora_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || listaCaracteresPermitidos.Contains(e.KeyChar))
            {
                if (calculouExpressao && char.IsDigit(e.KeyChar))
                {
                    txtVisor.Text = e.KeyChar.ToString();
                    calculouExpressao = false;
                }
                else if (calculouExpressao && listaCaracteresPermitidos.Contains(e.KeyChar))
                {
                    txtVisor.Text += e.KeyChar;
                    calculouExpressao = false;
                }
                else if (txtVisor.Text == "0" && char.IsDigit(e.KeyChar))
                {
                    txtVisor.Text = e.KeyChar.ToString();
                }
                else
                {
                    txtVisor.Text += e.KeyChar;
                }

                txtVisor.SelectionStart = txtVisor.Text.Length;
                e.Handled = true;
            }
        }

        private void FrmCalculadora_KeyDown(object sender, KeyEventArgs e)
        {
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

            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    var raw_exp = txtVisor.Text;
                    var exp = ParseExpression(txtVisor.Text);
                    var expression = new NCalc.Expression(exp);
                    txtVisor.Text = expression.Evaluate().ToString();
                    AddToHistory(raw_exp, txtVisor.Text);
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

        private void lvHistorico_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvHistorico.SelectedItems.Count == 1) // Verifica se exatamente um item está selecionado
            {
                string selectedItem = lvHistorico.SelectedItems[0].Text;
                string expressao = selectedItem.Split('=')[0].Trim();
                txtVisor.Text = expressao;
            }
        }
    }
}