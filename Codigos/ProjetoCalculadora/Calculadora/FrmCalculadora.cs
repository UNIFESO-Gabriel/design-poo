using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class FrmCalculadora : Form
    {
        public FrmCalculadora()
        {
            InitializeComponent();
            CreateCalculatorNumericButtons();
        }


        private void FrmCalculadora_Shown(object sender, EventArgs e)
        {

            this.txtExpressaoResultado.SelectionStart = txtExpressaoResultado.Text.Length; // Move o cursor para o final.
            txtExpressaoResultado.SelectionLength = 0; // Remove qualquer seleção inicial do texto.
            this.txtExpressaoResultado.Focus();
        }

        private void btn_MouseHover(object sender, EventArgs e)
        {
            this.ForeColor = Color.DarkGray;
        }

        private void btn_MouseLeave(object sender, EventArgs e)
        {
            Button btn = sender as Button;
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

        private void txtExpressaoResultado_KeyPress(object sender, KeyPressEventArgs e)
        {
            var txtVisor = (TextBox)sender;
            // Permite apenas dígitos, vírgula decimal e teclas de controle
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = true;
                return;
            }

            // Permite apenas uma vírgula decimal
            if (e.KeyChar == ',' && txtVisor.Text.Contains(','))
            {
                e.Handled = true;
                return;
            }

            // Trata a entrada de dígitos
            if (char.IsDigit(e.KeyChar))
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

        private void txtExpressaoResultado_TextChanged(object sender, EventArgs e)
        {
            var txtVisor = (TextBox)sender;
            if (string.IsNullOrEmpty(txtVisor.Text))
            {
                txtVisor.Text = "0";
                txtVisor.SelectionStart = txtVisor.Text.Length;
            }
        }
    }
}
