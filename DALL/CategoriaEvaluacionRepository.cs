using System.Data.Common;
using System.Data.SqlClient;
using Entity;

namespace DALL
{
    public class CategoriaEvaluacionRepository
    {
        DbConnection _connection;

        public CategoriaEvaluacionRepository(DbConnection connection)
        {
            _connection = connection;
        }
        
        public void GuardarCategoriaEvaluacion(CategoriaEvaluacion categoriaEvaluacion)
        {
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "insert into CategoriaEvaluaciones (EscalaDolor,Localizacion,FrecuenciaAumento,FrecuenciaDisminucion) values (@EscalaDolor,@Localizacion,@FrecuenciaAumento,@FrecuenciaDisminucion)";
                command.Parameters.Add(new SqlParameter("@EscalaDolor",categoriaEvaluacion.EscalaDolor));
                command.Parameters.Add(new SqlParameter("@Localizacion",categoriaEvaluacion.Localizacion));
                command.Parameters.Add(new SqlParameter("@FrecuenciaAumento",categoriaEvaluacion.FrecuenciaAumento));
                command.Parameters.Add(new SqlParameter("@FrecuenciaDisminucion",categoriaEvaluacion.FrecuenciaDisminucion));
                
                int fila = command.ExecuteNonQuery();
            }
        }
        
    }
}