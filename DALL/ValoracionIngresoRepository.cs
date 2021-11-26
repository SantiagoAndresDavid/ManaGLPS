using System.Data.Common;
using System.Data.SqlClient;
using Entity;

namespace DALL
{
    public class ValoracionIngresoRepository
    {
        DbConnection _connection;

        public ValoracionIngresoRepository(DbConnection connection)
        {
            _connection = connection;
        }
        
        public void GuardarValoracionIngreso(ValoracionIngreso valoracionIngreso,int codigo)
        {
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "insert into ValoracionesIngreso (Deportiva,DiagnosticoRemision,ImagenDiagnostica,CodigoConsultaMedica) values (@Deportiva,@DiagnosticoRemision,@ImagenDiagnostica,@CodigoConsultaMedica)";
                command.Parameters.Add(new SqlParameter("@Deportiva",valoracionIngreso.Deportiva));
                command.Parameters.Add(new SqlParameter("@DiagnosticoRemision",valoracionIngreso.DiagnosticoRemision));
                command.Parameters.Add(new SqlParameter("@ImagenDiagnostica",valoracionIngreso.ImagenDiagnostico));
                command.Parameters.Add(new SqlParameter("@CodigoConsultaMedica",codigo)); 
                int fila = command.ExecuteNonQuery();

            }

        }
        
        public int BuscarCodigoValoracionIngreso(int codigoConsulta)
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