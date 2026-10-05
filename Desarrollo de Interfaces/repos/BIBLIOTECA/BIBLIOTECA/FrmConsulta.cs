using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BIBLIOTECA
{
    public partial class FrmConsulta : Form
    {
        public FrmConsulta()
        {
            InitializeComponent();
        }

        private void FrmConsulta_Load(object sender, EventArgs e)
        {
            lsbTitulos.Items.Add("Don Quijote");
            lsbTitulos.Items.Add("La Odisea");
            lsbAutorEditorial.Items.Add("Cervantes");
            lsbAutorEditorial.Items.Add("Homero");
        }

        private void lsbTitulos_DoubleClick(object sender, EventArgs e)
        {

        }
    }
}
