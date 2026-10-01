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
            foreach (Form f in MdiChildren)
            {
                MessageBox.Show(f.GetType().ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void MnuSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
