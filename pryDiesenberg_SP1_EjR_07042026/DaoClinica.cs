using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.IO;



namespace pryDiesenberg_SP1_EjR_07042026
{
    internal static class DaoClinica
    {
        private static string GetConnectionString()
        {
            string baseDir = AppDomain.CurrentDomain.BaseDirectory;
            string dbFileAccdb = Path.Combine(baseDir, "clinica.accdb");
            string dbFileMdb = Path.Combine(baseDir, "clinica.mdb");

            if (File.Exists(dbFileAccdb))
            {
                return $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={dbFileAccdb};Persist Security Info=False;";
            }

            if (File.Exists(dbFileMdb))
            {
                return $"Provider=Microsoft.Jet.OLEDB.4.0;Data Source={dbFileMdb};Persist Security Info=False;";
            }

            throw new FileNotFoundException("No se encontró 'clinica.mdb' ni 'clinica.accdb' en el directorio del ejecutable.");
        }

        public static bool InsertMedico(Medico medico)
        {
            if (medico == null) throw new ArgumentNullException(nameof(medico));

            string connStr = GetConnectionString();

            using (var cnn = new OleDbConnection(connStr))
            using (var cmd = cnn.CreateCommand())
            {
                cmd.CommandText = "INSERT INTO Medicos (Matricula, Nombre, IdEspecialidad) VALUES (?, ?, ?)";
                cmd.Parameters.AddWithValue("?", medico.Matricula);
                cmd.Parameters.AddWithValue("?", medico.Nombre);
                cmd.Parameters.AddWithValue("?", medico.IdEspecialidad);

                cnn.Open();
                int filas = cmd.ExecuteNonQuery();
                return filas > 0;
            }
        }
    }
}
