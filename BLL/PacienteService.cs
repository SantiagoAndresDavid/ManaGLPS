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
        
        public Paciente buscarPaciente(int Identificacion)
        {
            try
            {
                _connectionManager.Open();
               return _pacienteRepository.BuscarPorID(Identificacion);

            }
            catch
            {

            }
            return null;
        }

        public string Modificar(int codigo)
        {
            try
            {
                _connectionManager.Open();
                string estado = _pacienteRepository.BuscarEstado(codigo);
                if(estado.Equals("Desactivado")){
                    _pacienteRepository.Activar(codigo); 
                }
                _pacienteRepository.Desactivar(codigo);
            }
            catch (Exception e)
            {
                return "Se presento el siguiente error" + e.Message;
            }

            return "se modifico con Exito";
        }
        

    }
}