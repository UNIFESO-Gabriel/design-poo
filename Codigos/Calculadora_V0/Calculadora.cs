using Calculadora_V0.Core;

namespace Calculadora_V0
{
    public partial class frmCalculadora : Form
    {
        // Variável responsável por armazenar os números recuperados do visor da calculadora.
        private float numeroEmMemoria;
        private bool clicouBotaoEnter;
        private Fabrica fabrica;

        public frmCalculadora()
        {
            // Inicializa os componentes da calculadora (Método Deus).
            InitializeComponent();

            // Inicializa a variável privada 'ciclouBotaoEnter' como false.
            clicouBotaoEnter = false;

            // Inicializa a variável privada fabrica.
            fabrica = new Fabrica();
        }

        private void btn_CapturaDigito(object sender, EventArgs e)
        {
            // Se o visor da calculadora for diferente de 0 e clicou no botão Enter, então reseta o conteúdo do visor da calculadora.
            if (txtVisor.Text != "0" && clicouBotaoEnter)
            {
                clicouBotaoEnter = false;
                txtVisor.Text = "0";
            }

            // realizar type-cast de sender para o tipo Button.
            var btnDigito = (Button)sender;

            // se o valor de Text do txtVisor for igual a 0, substitui o 0 pelo número de btnDigito.
            if (txtVisor.Text == "0")
                txtVisor.Text = btnDigito.Text;

            // cliquei no botão do dígito e quero que o valor de 'Text' vá para o 'txtVisor'.
            else
                txtVisor.Text += btnDigito.Text;
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            clicouBotaoEnter = true;
            var numeroVisor = float.Parse(txtVisor.Text);

            // Captura o radio button selecionado.
            var radioButton = grpBotoesRadio.Controls.OfType<RadioButton>().First(r => r.Checked).Name;

            // Captura o nome do radio button selecionado para instanciar a classe concreta em OperacoesMatematicas.cs via reflection.
            var operacaoMatematica = fabrica.CriarInstancia(radioButton);

            // Instancia a classe OperacoesMatematicas e realiza a operação matemática.
            var operacoesMatematicas = new OperacoesMatematicas(operacaoMatematica);

            // Realiza a operação matemática e armazena o resultado em 'numeroEmMemoria'.
            numeroEmMemoria = operacoesMatematicas.RealizarOperacao(numeroEmMemoria, numeroVisor);
            
            // Atualiza o visor da calculadora com o valor da operação matemática.
            txtVisor.Text = numeroEmMemoria.ToString();
        }

        //private void btnEnter_Click(object sender, EventArgs e)
        //{
        //    clicouBotaoEnter = true;
        //    var numeroVisor = float.Parse(txtVisor.Text);

        //    // Verifica qual radio button está selecionado para realizar a operação matemática correspondente.
        //    if (radioAdicao.Checked)
        //    {
        //        numeroEmMemoria += numeroVisor;
        //    }
        //    else if (radioSubtracao.Checked)
        //    {
        //        numeroEmMemoria -= numeroVisor;
        //    }
        //    else if (radioMultiplicacao.Checked)
        //    {
        //        numeroEmMemoria *= numeroVisor;
        //    }
        //    else if (radioDivisao.Checked)
        //    {
        //        // tratar o erro de divisão por zero.
        //        if (numeroVisor == 0)
        //        {
        //            MessageBox.Show("Não é possível dividir por zero.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //            ResetarCalculadora();
        //            return;
        //        }
        //        numeroEmMemoria /= numeroVisor;
        //    }
        //    // Atualiza o visor da calculadora com o valor da operação matemática.
        //    txtVisor.Text = numeroEmMemoria.ToString();
        //}

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            ResetarCalculadora();
        }

        private void ResetarCalculadora()
        {
            // Reseta todos os estados da calculadora.
            txtVisor.Text = "0";
            clicouBotaoEnter = false;
            numeroEmMemoria = 0.0F;
        }
    }
}
