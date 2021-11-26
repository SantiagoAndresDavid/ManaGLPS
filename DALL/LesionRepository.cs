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
        
        public void GuardarLesion(Lesion lesion,int codigoValoracionIngreso)
        {
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "insert into Lesiones (Caracteristica,Antecedentes,CodigoValoracionIngreso) values (@Caracteristica,@Antecedentes,@CodigoValoracionIngreso)";
                command.Parameters.Add(new SqlParameter("@Caracteristica",lesion.Caracteristicas));
                command.Parameters.Add(new SqlParameter("@Antecedentes",lesion.Antecedentes));
                command.Parameters.Add(new SqlParameter("@CodigoValoracionIngreso",codigoValoracionIngreso));
                command.ExecuteNonQuery();
            }
        }
        
    }
}