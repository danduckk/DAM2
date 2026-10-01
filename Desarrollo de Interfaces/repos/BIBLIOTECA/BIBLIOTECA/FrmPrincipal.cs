namespace BIBLIOTECA
{
    public partial class Form1 : Form
    {
        private FrmAlta frmAlta;
        private FrmConsulta frmConsulta;
        public Form1()
        {
            InitializeComponent();
        }

        private void altaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAlta = new FrmAlta();
            frmAlta.MdiParent = this;
            frmAlta.Show();
        }
    }
}
