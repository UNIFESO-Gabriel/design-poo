namespace Calculadora_V0
{
    public partial class frmCalculadora : Form
    {
        public frmCalculadora()
        {
            InitializeComponent();
        }

        private void btn_CapturaDigito(object sender, EventArgs e)
        {
            // realizar type-cast de sender para o tipo Button.
            var btnDigito = (Button)sender;

            // se o valor de Text do txtVisor for igual a 0, substitui o 0 pelo número de btnDigito.
            if (txtVisor.Text == "0")
                txtVisor.Text = btnDigito.Text;

            // cliquei no botão do dígito e quero que o valor de 'Text' vá para o 'txtVisor'.
            else
                txtVisor.Text += btnDigito.Text;
        }
    }
}
