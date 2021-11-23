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
        
        public void GuardarValoracionIngreso(ValoracionIngreso valoracionIngreso)
        {
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "insert into ValoracionesIngreso (Deportiva,DiagnosticoRemision,ImagenDiagnostica) values (@Deportiva,@DiagnosticoRemision,@ImagenDiagnostica)";
                command.Parameters.Add(new SqlParameter("@Deportiva",valoracionIngreso.Deportiva));
                command.Parameters.Add(new SqlParameter("@DiagnosticoRemision",valoracionIngreso.DiagnosticoRemision));
                command.Parameters.Add(new SqlParameter("@ImagenDiagnostica",valoracionIngreso.ImagenDiagnostico));
                int fila = command.ExecuteNonQuery();

            }

        }
        
    }
}