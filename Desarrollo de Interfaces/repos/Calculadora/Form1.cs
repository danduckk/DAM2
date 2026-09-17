namespace Calculadora
{
    public partial class FrmInicio : Form
    {
        double Resultado;
        double ValorInicial = 0;
        double ValorSegundo = 0;
        public FrmInicio()
        {
            InitializeComponent();
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            TxtCaja.Text += "1";
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            TxtCaja.Text += "2";
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            TxtCaja.Text += "3";
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            TxtCaja.Text += "4";
        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            TxtCaja.Text += "5";
        }

        private void Btn6_Click(object sender, EventArgs e)
        {
            TxtCaja.Text += "6";
        }

        private void Btn7_Click(object sender, EventArgs e)
        {
            TxtCaja.Text += "7";
        }

        private void Btn8_Click(object sender, EventArgs e)
        {
            TxtCaja.Text += "8";
        }

        private void Btn9_Click(object sender, EventArgs e)
        {
            TxtCaja.Text += "9";
        }

        private void BtnC_Click(object sender, EventArgs e)
        {
            TxtCaja.Clear();
        }

        private void BtnCE_Click(object sender, EventArgs e)
        {
            TxtCaja.Clear();
        }

        private void Btn0_Click(object sender, EventArgs e)
        {
            TxtCaja.Text = "0";
        }

        private void buttonIgual_Click(object sender, EventArgs e)
        {
            ValorSegundo = double.Parse(TxtCaja.Text);
            Resultado = ValorInicial + ValorSegundo;
            TxtCaja.Text = Resultado.ToString();
        }

        private void BtnSumar_Click(object sender, EventArgs e)
        {
            ValorInicial = double.Parse(TxtCaja.Text);
            TxtCaja.Clear();
        }
    }
}
