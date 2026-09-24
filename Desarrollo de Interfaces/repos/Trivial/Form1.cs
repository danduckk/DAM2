namespace Trivial
{
    public partial class Capitales : Form
    {
        public Capitales()
        {
            InitializeComponent();
        }

        private void Capitales_Load(object sender, EventArgs e)
        {

        }

        String[] paises = { "España", "Francia", "Portugal", "Alemania" };
        String[] capitales = { "Madrid", "París", "Lisboa", "Berlín" };

        Random rand = new Random();

        int respuestaCorrecta;
        int seleccion;

        private void generarRonda()
        {
            int numeroRandom = rand.Next(0, paises.Length + 1);
            lblPregunta.Text = paises[numeroRandom];
        }
        private void comprobar()
        {

        }

        private void nuevaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            generarRonda();
        }
    }
}
