using System.Data.Common;
using System.Data.SqlClient;
using Entity;

namespace DALL
{
    public class CIERepository
    {
        DbConnection _connection;

        public CIERepository(DbConnection connection)
        {
            _connection = connection;
        }
        
        public void GuardarCIE(CIE cie)
        {
            using (var command = _connection.CreateCommand())
            {
                
                // Esta debe ser distinta por que trabaja con una lista preguntar a andres terminar 
                command.CommandText = "insert into CIE (Codigo,Descripcion,) values (@Codigo,@Descripcion)";
                command.Parameters.Add(new SqlParameter("@Codigo",cie.Codigo));
                command.Parameters.Add(new SqlParameter("@Descripcion",cie.Descripcion));

                int fila = command.ExecuteNonQuery();

            }
        }
        
    }
}