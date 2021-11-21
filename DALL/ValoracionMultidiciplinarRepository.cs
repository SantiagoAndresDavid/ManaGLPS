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
        
        public void GuardarValoracionMultidiciplinar(ConsultaMedica consulta)
        {
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "insert into Temporalidades (InformeIndividual,InformeGrupal) values (@InformeIndividual,@InformeGrupal)";
                command.Parameters.Add(new SqlParameter("@InformeIndividual",consulta.ValoracionMultiDiciplinar.InformeIndividual));
                command.Parameters.Add(new SqlParameter("@InformeGrupal",consulta.ValoracionMultiDiciplinar.InformeGrupal));
                
                int fila = command.ExecuteNonQuery();

            }
        }
        
    }
}