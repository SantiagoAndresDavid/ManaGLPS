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

        public void GuardarDiagnostico(Diagnostico diagnostico,int codigo)
        {
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "insert into Diagnosticos (ObservacionesExtra,CodigoConsultaMedica) values (@ObservacionesExtra,@CodigoConsultaMedica)";
                command.Parameters.Add(new SqlParameter("@ObservacionesExtra", diagnostico.ObservacionesExtra));
                command.Parameters.Add(new SqlParameter("@CodigoConsultaMedica", codigo));
                int fila = command.ExecuteNonQuery();
            }
            
        }
        
        public int BuscarCodigoDiagnostico(int codigoConsulta)
        {
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "select * from ValoracionesMultidiciplinar where CodigoConsultaMedica=@CodigoConsultaMedica";
                command.Parameters.Add(new SqlParameter("@CodigoConsultaMedica",codigoConsulta));
                var reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        return reader.GetInt32(0);
                    }
                    reader.Close();
                }

                return 0;
            }
        }
    }
}
