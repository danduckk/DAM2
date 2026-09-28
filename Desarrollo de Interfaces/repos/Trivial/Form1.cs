namespace Trivial
{
    public partial class Capitales : Form
    {
        // Campos
        private List<string> paises = new List<string>();
        private List<string> capitales = new List<string>();
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
            int posicionCorrecta = azar.Next(4);
            Label[] opciones = { lblOpcion1, lblOpcion2, lblOpcion3, lblOpcion4 };
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
                    int candidato = azar.Next(8);

                    while (candidato = usados.)
                }
            }

        }
    }
}
