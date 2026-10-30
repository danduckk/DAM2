using System.Windows.Forms;


namespace FormulariosHeredados
{
    public partial class frmBase : Form
    {
        public frmBase()
        {
            InitializeComponent();
        }
        private void mnuSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mnuConsultaList_Click(object sender, EventArgs e)
        {
            
        }
    }
}
