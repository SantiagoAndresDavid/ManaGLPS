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
        
        public void GuardarMedicacion(Medicacion medicacion,int codigo)
        {
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "insert into Medicaciones (Prescripcion,Rehabilitacion,CodigoConsultaMedica) values (@Prescripcion,@Rehabilitacion,@CodigoConsultaMedica)";
                command.Parameters.Add(new SqlParameter("@Prescripcion",medicacion.Prescripcion));
                command.Parameters.Add(new SqlParameter("@Rehabilitacion",medicacion.Rehabilitacion));
                command.Parameters.Add(new SqlParameter("@CodigoConsultaMedica", codigo));
                int fila = command.ExecuteNonQuery();

            }
        }
        
        
        
    }
}