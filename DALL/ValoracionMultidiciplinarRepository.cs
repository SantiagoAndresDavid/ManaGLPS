using System.Data.Common;
using System.Data.SqlClient;
using Entity;

namespace DALL
{
    public class ValoracionMultidiciplinarRepository
    {
        DbConnection _connection;

        public ValoracionMultidiciplinarRepository(DbConnection connection)
        {
            _connection = connection;
        }
        
        public void GuardarValoracionMultidiciplinar(ValoracionMultiDiciplinar valoracionMultiDiciplinar,int codigoConsulta)
        {
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "insert into ValoracionesMultidiciplinar (InformeIndividual,InformeGrupal,CodigoConsultaMedica) values (@InformeIndividual,@InformeGrupal,@CodigoConsultaMedica)";
                command.Parameters.Add(new SqlParameter("@InformeIndividual",valoracionMultiDiciplinar.InformeIndividual));
                command.Parameters.Add(new SqlParameter("@InformeGrupal",valoracionMultiDiciplinar.InformeGrupal));
                command.Parameters.Add(new SqlParameter("@CodigoConsultaMedica",codigoConsulta));
                
                int fila = command.ExecuteNonQuery();

            }
        }
        
        public int BuscarCodigoValoracionMultiDiciplinar(int codigoConsulta)
        {
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "select * from ValoracionesMultidiciplinar where CodigoConsultaMedica=@CodigoConsultaMedica";
                command.Parameters.Add(new SqlParameter("@CodigoConsultaMedica",codigoConsulta));
                var reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    int codigoValoracionMultidiciplinar = 0;
                    while (reader.Read())
                    {
                        codigoValoracionMultidiciplinar = reader.GetInt32(0);
                    }
                    reader.Close();
                    return codigoValoracionMultidiciplinar;
                }
                return 0;
            }
        }
    }
}