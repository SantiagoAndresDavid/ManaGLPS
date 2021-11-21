using System;
using DALL;
using Entity;

namespace BLL
{
    public class PacienteService
    {
        PacienteRepository _pacienteRepository;
        ConnectionManager _connectionManager;


        public PacienteService(string connectionString)
        {
            _connectionManager = new ConnectionManager(connectionString);
            _pacienteRepository = new PacienteRepository(_connectionManager.Connection);
        }
        
        public string Guardar(Paciente paciente)
        {
            try
            {
                _connectionManager.Open();
                _pacienteRepository.GuardarPaciente(paciente);
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