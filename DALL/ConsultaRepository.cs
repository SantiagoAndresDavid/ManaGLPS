using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;

namespace DALL
{
    public class ConsultaRepository
    {
        DbConnection _connection;

        public ConsultaRepository(DbConnection connection)
        {
            _connection = connection;
        }

        public void GuardarConsulta(ConsultaMedica consulta)
        {
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "insert into ConsultasMedicas (Estado,FaseTratamiento) values (@Estado,@FaseTratamiento)";
                command.Parameters.Add(new SqlParameter("@Estado",consulta.Estado));
                command.Parameters.Add(new SqlParameter("@FaseTratamiento",consulta.FaseTratamiento));
                int fila = command.ExecuteNonQuery();

            }
        }
    }

}

