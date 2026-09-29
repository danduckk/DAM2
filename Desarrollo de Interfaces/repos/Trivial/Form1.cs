namespace Trivial
{
    public partial class Capitales : Form
    {
        // Campos
        private List<string> paises = new List<string>();
        private List<string> capitales = new List<string>();
        Label[] opciones;
        Random azar = new Random();

        // Estado de la partida
        private int aciertos = 0;
        private int preguntasHechas = 0;
        private int indiceActual;   // posición de la pregunta en curso

        // Constructor
        public Capitales()
        {
            InitializeComponent();
            CargarDatos();
            NuevaPregunta();
        }

        // Eventos





        // Metodos propios
        private void AnadirPais(string pais, string capital)
        {
            paises.Add(pais);
            capitales.Add(capital);
        }

        private void CargarDatos()
        {
            AnadirPais("España", "Madrid");
            AnadirPais("París", "Francia");
            AnadirPais("Alemania", "Berlín");
            AnadirPais("Polonia", "Varsovia");
            AnadirPais("Bélgica", "Bruselas");
            AnadirPais("Países Bajos", "Amsterdam");
            AnadirPais("Rumanía", "Bucarest");
            AnadirPais("Grecia", "Atenas");
        }

        private void NuevaPregunta()
        {
            indiceActual = azar.Next(paises.Count);
            lblPregunta.Text = paises[indiceActual];
            opciones = new Label[] { lblOpcion1, lblOpcion2, lblOpcion3, lblOpcion4 };
            int posicionCorrecta = azar.Next(4);
            List<int> usados = new List<int>();
            usados.Add(indiceActual);
            for (int i = 0; i < 4; i++)
            {
                if (i == posicionCorrecta)
                {
                    opciones[i].Text = capitales[indiceActual];
                }
                else
                {
                    int candidato = azar.Next(paises.Count);

                    while (usados.Contains(candidato))
                    {
                        candidato = azar.Next(paises.Count);

                    }

                    usados.Add(candidato);
                    opciones[i].Text = capitales[candidato];

                }
            }
        }

        private void Opcion_Click(object sender, EventArgs e)
        {
            Label pulsado = (Label)sender; // cast para pasarlo de object a Label
            if (pulsado.Text == capitales[indiceActual])
            {
                lblResultado.Text = "¡Correcto!";
                btnSiguiente.Enabled = true;
                preguntasHechas++;
                aciertos++;
            }
            else
            {
                lblResultado.Text = "¡Incorrecto!";
                btnSiguiente.Enabled = true;
                preguntasHechas++;
            }
        }
    }
}

