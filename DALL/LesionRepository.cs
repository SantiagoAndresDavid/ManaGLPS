using System.Data.Common;
using System.Data.SqlClient;
using Entity;

namespace DALL
{
    public class LesionRepository
    {
        DbConnection _connection;

        public LesionRepository(DbConnection connection)
        {
            _connection = connection;
        }
        
        public void GuardarLesion(Lesion lesion)
        {
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "insert into Lesiones (Caracteristica,Antecedentes) values (@Caracteristica,@Antecedentes)";
                command.Parameters.Add(new SqlParameter("@Caracteristica",lesion.Caracteristicas));
                command.Parameters.Add(new SqlParameter("@Antecedentes",lesion.Antecedentes));
                int fila = command.ExecuteNonQuery();

            }
        }
        
    }
}