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
            btn.Font = new Font("Consolas", 15.75F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
        }
    }
}
