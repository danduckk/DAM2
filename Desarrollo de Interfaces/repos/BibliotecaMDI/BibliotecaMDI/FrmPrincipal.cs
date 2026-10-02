namespace BibliotecaMDI
{
    public partial class frmPrincipal : Form
    {
        private FrmAlta frmAlta;
        private FrmConsulta frmConsulta;
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void MnuAlta_Click(object sender, EventArgs e)
        {
            frmAlta = new FrmAlta();
            frmAlta.MdiParent = this;
            frmAlta.Show();
            frmAlta.WindowState = FormWindowState.Maximized; // hacer que aparezca maximizado

            // MdiChildren;
        }

        private void MnuConsulta_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.FileName = "";
            button1.Filter = "jpg files (*.jpg)|*.jpg|All files(*.*)|*.*";
            button1.InitialDirectory = "C:\\";
            button1.ShowDialog();
            Bitmap imagen = new Bitmap(button1.FileName);
            pcbPortada.Image = imagen;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void MnuSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
