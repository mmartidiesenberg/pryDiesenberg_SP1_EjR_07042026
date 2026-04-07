using System;
using System.Windows.Forms;
using System.Linq;

namespace pryDiesenberg_SP1_EjR_07042026
{
    public partial class FrmEspecialidades : Form
    {
        public FrmEspecialidades()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!ValidarDatos())
                return;

            int idEspecialidad = int.Parse(txtIdEspecialidad.Text);
            string nombreEspecialidad = txtNombreEspecialidad.Text.Trim();

            if (ExisteEspecialidad(idEspecialidad))
            {
                MessageBox.Show("El ID de la especialidad ya existe. Por favor, ingrese otro.", 
                    "Error - ID Duplicado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Especialidad nuevaEspecialidad = new Especialidad(idEspecialidad, nombreEspecialidad);
            GestorDatos.ListaEspecialidades.Add(nuevaEspecialidad);

            MessageBox.Show("Especialidad registrada correctamente.", 
                "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            LimpiarCampos();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private bool ValidarDatos()
        {
            if (string.IsNullOrWhiteSpace(txtIdEspecialidad.Text))
            {
                MessageBox.Show("El ID de la especialidad no puede estar vacío.", 
                    "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtIdEspecialidad.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtNombreEspecialidad.Text))
            {
                MessageBox.Show("El nombre de la especialidad no puede estar vacío.", 
                    "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNombreEspecialidad.Focus();
                return false;
            }

            if (!int.TryParse(txtIdEspecialidad.Text, out int id) || id <= 0)
            {
                MessageBox.Show("El ID de la especialidad debe ser un número positivo válido.", 
                    "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtIdEspecialidad.Focus();
                return false;
            }

            return true;
        }

        private bool ExisteEspecialidad(int id)
        {
            return GestorDatos.ListaEspecialidades.Any(e => e.Id == id);
        }

        private void LimpiarCampos()
        {
            txtIdEspecialidad.Clear();
            txtNombreEspecialidad.Clear();
            txtIdEspecialidad.Focus();
        }
    }
}