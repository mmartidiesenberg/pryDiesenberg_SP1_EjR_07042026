using System.Collections.Generic;

namespace pryDiesenberg_SP1_EjR_07042026
{
    public class Especialidad
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        public Especialidad(int id, string nombre)
        {
            Id = id;
            Nombre = nombre;
        }
    }

    public class Medico
    {
        public int Matricula { get; set; }
        public string Nombre { get; set; }
        public int IdEspecialidad { get; set; }

        public Medico(int matricula, string nombre, int idEspecialidad)
        {
            Matricula = matricula;
            Nombre = nombre;
            IdEspecialidad = idEspecialidad;
        }
    }

    public class GestorDatos
    {
        public static List<Especialidad> ListaEspecialidades = new List<Especialidad>();
        public static List<Medico> ListaMedicos = new List<Medico>();
    }
}