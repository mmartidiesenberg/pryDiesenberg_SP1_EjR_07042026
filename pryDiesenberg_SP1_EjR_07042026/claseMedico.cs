using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryDiesenberg_SP1_EjR_07042026
{
    internal class claseMedico
    {
        public int Matricula { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Especialidad { get; set; }

        public claseMedico(int matricula, string nombre, string apellido, int especialidad)
        {
            Matricula = matricula;
            Nombre = nombre;
            Apellido = apellido;
            Especialidad = especialidad;
        }

        public void RegistrarMedicoBD()
        {
            // Crea el objeto modelo que usa el DAO (ajusta constructor si cambia)
            Medico nuevoMedico = new Medico(this.Matricula, this.Nombre, this.Especialidad);

            try
            {
                bool ok = DaoClinica.InsertMedico(nuevoMedico);
                if (ok)
                {
                    // Opcional: mantener en la lista en memoria
                    GestorDatos.ListaMedicos.Add(nuevoMedico);
                }
                else
                {
                    throw new Exception("No se pudo insertar el médico en la base de datos.");
                }
            }
            catch (Exception ex)
            {
                // Maneja el error según la UX de tu aplicación
                System.Windows.Forms.MessageBox.Show("Error al guardar en la BD: " + ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }
    }
}
