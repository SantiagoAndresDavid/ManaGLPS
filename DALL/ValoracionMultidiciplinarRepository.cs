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
        
        public void GuardarValoracionMultidiciplinar(ValoracionMultiDiciplinar valoracionMultiDiciplinar)
        {
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "insert into ValoracionesMultidiciplinar (InformeIndividual,InformeGrupal) values (@InformeIndividual,@InformeGrupal)";
                command.Parameters.Add(new SqlParameter("@InformeIndividual",valoracionMultiDiciplinar.InformeIndividual));
                command.Parameters.Add(new SqlParameter("@InformeGrupal",valoracionMultiDiciplinar.InformeGrupal));
                
                int fila = command.ExecuteNonQuery();

            }
        }
        
    }
}