using System;
using DALL;
using Entity;

namespace BLL
{
    public class ConsultaService
    {
        ConnectionManager _connectionManager;
        ConsultaRepository _consultaRepository;

        public ConsultaService(string connectionString)
        {
            _connectionManager = new ConnectionManager(connectionString);
            _consultaRepository = new ConsultaRepository(_connectionManager.Connection);
        }
        
        public string Guardar(ConsultaMedica consulta)
        {
            try
            {
                _connectionManager.Open();
                _consultaRepository.GuardarConsulta(consulta);
            }
            catch (Exception e)
            {
                return "Se presento el siguiente error" + e.Message;
            }
            finally
            {
                _connectionManager.Close();
            }

            return "";
        }
        
        
        
        
    }
}