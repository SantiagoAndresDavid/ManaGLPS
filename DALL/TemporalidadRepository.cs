using System.Data.Common;
using System.Data.SqlClient;
using Entity;

namespace DALL
{
    public class TemporalidadRepository
    {
        DbConnection _connection;
        
        public TemporalidadRepository(DbConnection connection)
        {
            _connection = connection;
        }
        
        public void GuardarTemporalidad(Temporalidad temporalidad)
        {
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "insert into Temporalidades (FechaCreada,UltimaModificacion) values (@FechaCreada,@UltimaModificacion)";
                command.Parameters.Add(new SqlParameter("@Fechacreada",temporalidad.FechaCreada));
                command.Parameters.Add(new SqlParameter("@UltimaModificacion",temporalidad.UltimaModificacion));
                int fila = command.ExecuteNonQuery();

            }
        }
        
    }
}