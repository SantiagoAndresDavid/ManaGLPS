using System.Data.Common;
using System.Data.SqlClient;
using Entity;

namespace DALL
{
    public class MedicacionesRepository
    {
        DbConnection _connection;

        public MedicacionesRepository(DbConnection connection)
        {
            _connection = connection;
        }
        
        public void GuardarMedicacion(Medicacion medicacion)
        {
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "insert into Medicaciones (Prescripcion,Rehabilitacion) values (@Prescripcion,@Rehabilitacion)";
                command.Parameters.Add(new SqlParameter("@Prescripcion",medicacion.Prescripcion));
                command.Parameters.Add(new SqlParameter("@Rehabilitacion",medicacion.Rehabilitacion));
                int fila = command.ExecuteNonQuery();

            }
        }
        
        
        
    }
}