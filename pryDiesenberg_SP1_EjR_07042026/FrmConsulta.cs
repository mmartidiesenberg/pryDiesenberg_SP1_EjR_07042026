using System;
using System.Windows.Forms;
using System.Linq;

namespace pryDiesenberg_SP1_EjR_07042026
{
    public partial class FrmConsulta : Form
    {
        public FrmConsulta()
        {
            InitializeComponent();
        }

        private void FrmConsulta_Load(object sender, EventArgs e)
        {
            CargarComboEspecialidades();
        }

        private void CargarComboEspecialidades()
        {
            cmbEspecialidad.DataSource = null;
            cmbEspecialidad.DataSource = GestorDatos.ListaEspecialidades;
            cmbEspecialidad.DisplayMember = "Nombre";
            cmbEspecialidad.ValueMember = "Id";
            cmbEspecialidad.SelectedIndex = -1;
        }

        private void cmbEspecialidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbEspecialidad.SelectedIndex >= 0)
            {
                int idEspecialidad = (int)cmbEspecialidad.SelectedValue;
                MostrarMedicosEspecialidad(idEspecialidad);
            }
            else
            {
                dgvMedicos.DataSource = null;
            }
        }

        private void MostrarMedicosEspecialidad(int idEspecialidad)
        {
            var medicosEspecialidad = GestorDatos.ListaMedicos
                .Where(m => m.IdEspecialidad == idEspecialidad)
                .Select(m => new { m.Matricula, m.Nombre })
                .ToList();

            dgvMedicos.DataSource = medicosEspecialidad;
            
            if (dgvMedicos.Columns.Count > 0)
            {
                dgvMedicos.Columns[0].HeaderText = "Matrícula";
                dgvMedicos.Columns[1].HeaderText = "Nombre";
            }
        }

        private void btnRegistrarEspecialidad_Click(object sender, EventArgs e)
        {
            FrmEspecialidades frmEspecialidades = new FrmEspecialidades();
            frmEspecialidades.ShowDialog();
            CargarComboEspecialidades();
        }

        private void btnRegistrarMedico_Click(object sender, EventArgs e)
        {
            FrmMedicos frmMedicos = new FrmMedicos();
            frmMedicos.ShowDialog();
        }
    }
}