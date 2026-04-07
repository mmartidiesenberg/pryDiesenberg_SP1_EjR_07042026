using System;
using System.Windows.Forms;
using System.Linq;

namespace pryDiesenberg_SP1_EjR_07042026
{
    public partial class FrmMedicos : Form
    {
        public FrmMedicos()
        {
            InitializeComponent();
        }

        private void FrmMedicos_Load(object sender, EventArgs e)
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!ValidarDatos())
                return;

            int matricula = int.Parse(txtMatricula.Text);
            string nombreMedico = txtNombreMedico.Text.Trim();
            int idEspecialidad = (int)cmbEspecialidad.SelectedValue;

            if (ExisteMatricula(matricula))
            {
                MessageBox.Show("La matrícula del médico ya existe. Por favor, ingrese otra.", 
                    "Error - Matrícula Duplicada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Medico nuevoMedico = new Medico(matricula, nombreMedico, idEspecialidad);
            GestorDatos.ListaMedicos.Add(nuevoMedico);

            MessageBox.Show("Médico registrado correctamente.", 
                "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            LimpiarCampos();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private bool ValidarDatos()
        {
            if (string.IsNullOrWhiteSpace(txtMatricula.Text))
            {
                MessageBox.Show("La matrícula del médico no puede estar vacía.", 
                    "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMatricula.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtNombreMedico.Text))
            {
                MessageBox.Show("El nombre del médico no puede estar vacío.", 
                    "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNombreMedico.Focus();
                return false;
            }

            if (cmbEspecialidad.SelectedIndex < 0)
            {
                MessageBox.Show("Debe seleccionar una especialidad.", 
                    "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbEspecialidad.Focus();
                return false;
            }

            if (!int.TryParse(txtMatricula.Text, out int matricula) || matricula <= 0)
            {
                MessageBox.Show("La matrícula debe ser un número positivo válido.", 
                    "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMatricula.Focus();
                return false;
            }

            return true;
        }

        private bool ExisteMatricula(int matricula)
        {
            return GestorDatos.ListaMedicos.Any(m => m.Matricula == matricula);
        }

        private void LimpiarCampos()
        {
            txtMatricula.Clear();
            txtNombreMedico.Clear();
            cmbEspecialidad.SelectedIndex = -1;
            txtMatricula.Focus();
        }
    }
}