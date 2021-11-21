using System;
using DALL;
using Entity;

namespace BLL
{
    public class HistoriaMedicaService
    {
        
        ConnectionManager _connectionManager;
        HistoriaMedicaRepository _historiaMedicaRepository;

        public HistoriaMedicaService(string connectionString)
        {
            _connectionManager = new ConnectionManager(connectionString);
            _historiaMedicaRepository = new HistoriaMedicaRepository(_connectionManager.Connection);
        }

        public string Guardar(HistoriaMedica historiaMedica)
        {
            try
            {
                _connectionManager.Open();
                _historiaMedicaRepository.GuardarHistoriaMedica(historiaMedica);
            }
            catch (Exception e)
            {
                return "Se presento el siguiente error" + e.Message;
            }
            finally
            {
                _connectionManager.Close();
            }
            return "se guardo con exito";
        }
    }
}