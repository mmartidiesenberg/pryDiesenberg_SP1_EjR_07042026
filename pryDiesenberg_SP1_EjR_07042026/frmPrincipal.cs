using System;
using System.Windows.Forms;

namespace pryDiesenberg_SP1_EjR_07042026
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnGestionarEspecialidades_Click(object sender, EventArgs e)
        {
            FrmEspecialidades frmEspecialidades = new FrmEspecialidades();
            frmEspecialidades.ShowDialog();
        }

        private void btnGestionarMedicos_Click(object sender, EventArgs e)
        {
            FrmMedicos frmMedicos = new FrmMedicos();
            frmMedicos.ShowDialog();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            FrmConsulta frmConsulta = new FrmConsulta();
            frmConsulta.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}