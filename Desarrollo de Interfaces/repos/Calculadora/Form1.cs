namespace Calculadora
{
    public partial class FrmInicio : Form
    {
        double Resultado;
        public FrmInicio()
        {
            InitializeComponent();
        }

        //variables
        string operador = "";
        double num1 = 0;
        double num2 = 0;
        string memoria = "";
        private void BtnC_Click(object sender, EventArgs e)
        {
            TxtCaja.Clear();
            num1 = 0;
            num2 = 0;
            operador = "";
        }
        private void BtnCE_Click(object sender, EventArgs e)
        {
            if (TxtCaja.TextLength == 1) TxtCaja.Text = "0";
            else TxtCaja.Text = TxtCaja.Text.Substring(0, TxtCaja.Text.Length - 1);
        }
        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            TxtCaja.Text += btn.Text;
        }

        private void Btn0_Click(object sender, EventArgs e)
        {
            TxtCaja.Text += "0";
        }

        private void BtnPunto_Click(object sender, EventArgs e)
        {
            TxtCaja.Text += ",";
        }

        private void BtnSumar_Click(object sender, EventArgs e)
        {
            operador = "+";
            num1 = Convert.ToDouble(TxtCaja.Text);
            TxtCaja.Clear();
        }

        private void buttonResta_Click(object sender, EventArgs e)
        {
            operador = "-";
            num1 = Convert.ToDouble(TxtCaja.Text);
            TxtCaja.Clear();
        }

        private void buttonMultiplicacion_Click(object sender, EventArgs e)
        {
            operador = "*";
            num1 = Convert.ToDouble(TxtCaja.Text);
            TxtCaja.Clear();
        }

        private void buttonDivision_Click(object sender, EventArgs e)
        {
            operador = "/";
            num1 = Convert.ToDouble(TxtCaja.Text);
            TxtCaja.Clear();
        }

        private void buttonIgual_Click(object sender, EventArgs e)
        {
            num2 = Convert.ToDouble(TxtCaja.Text);

            switch (operador)
            {
                case "+":
                    Resultado = num1 + num2;
                    TxtCaja.Text = Resultado.ToString();
                    break;
                case "-":
                    Resultado = num1 - num2;
                    TxtCaja.Text = Resultado.ToString();
                    break;
                case "*":
                    Resultado = num1 * num2;
                    TxtCaja.Text = Resultado.ToString();
                    break;
                case "/":
                    if (num2 == 0)
                    {
                        TxtCaja.Text = "ERROR";
                    }
                    else
                    {
                        Resultado = num1 / num2;
                        TxtCaja.Text = Resultado.ToString();
                    }
                    break;
            }


        }

        private void BtnMplus_Click(object sender, EventArgs e)
        {
            double total = Convert.ToDouble(memoria) + Convert.ToDouble(TxtCaja.Text);
            memoria = total.ToString();

        }

        private void BtnMS_Click(object sender, EventArgs e)
        {
            memoria = TxtCaja.Text;

        }

        private void BtnMR_Click(object sender, EventArgs e)
        {
            TxtCaja.Text = memoria;
        }

        private void BtnMC_Click(object sender, EventArgs e)
        {
            memoria = "";
        }
    }
}
