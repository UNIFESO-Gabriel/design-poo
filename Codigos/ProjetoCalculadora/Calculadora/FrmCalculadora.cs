using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class FrmCalculadora : Form
    {
        private readonly List<char> listaCaracteresPermitidos = new() { ',', '(', ')', '*', '/', '+', '-', '%' };

        [DllImport("user32.dll")]
        private static extern bool HideCaret(IntPtr hWnd);

        private void EsconderCursorTxtVisor()
        {
            txtVisor.GotFocus += (s, e) => HideCaret(txtVisor.Handle);
            txtVisor.MouseDown += (s, e) => HideCaret(txtVisor.Handle);
            txtVisor.KeyUp += (s, e) => HideCaret(txtVisor.Handle);
        }

        public FrmCalculadora()
        {
            InitializeComponent();
            EsconderCursorTxtVisor();
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

        private void txtExpressaoResultado_KeyDown(object sender, KeyEventArgs e)
        {
            var txtVisor = (TextBox)sender;
            if ((e.KeyCode == Keys.Back || e.KeyCode == Keys.Delete) &&
                (txtVisor.Text == "0" || (txtVisor.SelectionStart == 0 && txtVisor.SelectionLength == txtVisor.Text.Length)))
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void TxtVisor_KeyPress(object sender, KeyPressEventArgs e)
        {
            var txtVisor = (TextBox)sender;

            // Se a tecla pressionada for Enter, calcula a expressão em txtVisor.
            if (e.KeyChar == (char)Keys.Enter)
            {
                try
                {
                    var resultado = new DataTable().Compute(txtVisor.Text, null);
                    txtVisor.Text = resultado.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro");
                }
            }

            // Permite apenas dígitos, vírgula decimal e teclas de controle
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !listaCaracteresPermitidos.Contains(e.KeyChar))
            {
                e.Handled = true;
                return;
            }

            // Trata a entrada de dígitos
            if (char.IsDigit(e.KeyChar) || listaCaracteresPermitidos.Contains(e.KeyChar))
            {
                // Se o texto atual for "0" e um novo dígito for digitado, substitui o "0"
                if (txtVisor.Text == "0")
                {
                    txtVisor.Text = e.KeyChar.ToString();
                    txtVisor.SelectionStart = txtVisor.Text.Length;
                    e.Handled = true;
                }
                // Se todo o texto estiver selecionado, substitui o texto existente
                else if (txtVisor.SelectionLength == txtVisor.Text.Length)
                {
                    txtVisor.Text = e.KeyChar.ToString();
                    txtVisor.SelectionStart = txtVisor.Text.Length;
                    e.Handled = true;
                }
            }
        }

        private void TxtVisor_TextChanged(object sender, EventArgs e)
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
            else
                txtVisor.Text += '9';
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            // precisa haver um número antes para inserir o símbolo de divisão.
            if (txtVisor.Text.Length > 0 && char.IsDigit(txtVisor.Text[txtVisor.Text.Length - 1]))
                txtVisor.Text += '/';
        }

        private void btnMultiplicacao_Click(object sender, EventArgs e)
        {
            // precisa haver um número antes para inserir o símbolo de divisão.
            if (txtVisor.Text.Length > 0 && char.IsDigit(txtVisor.Text[txtVisor.Text.Length - 1]))
                txtVisor.Text += '*';
        }

        private void btnSubtracao_Click(object sender, EventArgs e)
        {
            // precisa haver um número antes para inserir o símbolo de divisão.
            if (txtVisor.Text.Length > 0 && char.IsDigit(txtVisor.Text[txtVisor.Text.Length - 1]))
                txtVisor.Text += '-';
        }

        private void btnAdicao_Click(object sender, EventArgs e)
        {
            // precisa haver um número antes para inserir o símbolo de divisão.
            if (txtVisor.Text.Length > 0 && char.IsDigit(txtVisor.Text[txtVisor.Text.Length - 1]))
                txtVisor.Text += '+';
        }

        private void btnElevadoQuadrado_Click(object sender, EventArgs e)
        {
            // precisa haver um número antes para inserir o símbolo de divisão.
            if (txtVisor.Text.Length > 0 && char.IsDigit(txtVisor.Text[txtVisor.Text.Length - 1]))
                txtVisor.Text += "**2";
        }

        private void btnSqrt_Click(object sender, EventArgs e)
        {
            if (txtVisor.Text.Length > 0 && char.IsDigit(txtVisor.Text[txtVisor.Text.Length - 1]))
                txtVisor.Text += "**0,5";
        }

        private void btnAbreParenteses_Click(object sender, EventArgs e)
        {
            txtVisor.Text += "(";
        }

        private void btnFechaParenteses_Click(object sender, EventArgs e)
        {
            if (txtVisor.Text.Any(x => x == '('))
            {
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
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            try
            {
                var resultado = new DataTable().Compute(txtVisor.Text, null);
                txtVisor.Text = resultado.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro");
            }
        }
    }
}
