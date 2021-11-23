using System.Data.Common;
using System.Data.SqlClient;
using Entity;

namespace DALL
{
    public class DiagnosticoRepository
    {
        DbConnection _connection;

        public DiagnosticoRepository(DbConnection connection)
        {
            _connection = connection;
        }

        public void GuardarDiagnostico(Diagnostico diagnostico)
        {
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "insert into Diagnosticos (ObservacionesExtra) values (@ObservacionesExtra)";
                command.Parameters.Add(new SqlParameter("@ObservacionesExtra", diagnostico.ObservacionesExtra));

                int fila = command.ExecuteNonQuery();
            }
        }
    }
}
