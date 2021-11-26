using System;
using System.Collections.Generic;
using DALL;
using Entity;

namespace BLL
{
    public class UsuarioService
    {
        UsuarioRepository _usuarioReprository;
        ConnectionManager _connectionManager;


        public UsuarioService(string connectionString)
        {
            _connectionManager = new ConnectionManager(connectionString);
            _usuarioReprository = new UsuarioRepository(_connectionManager.Connection);
        }

        public string Guardar(Usuario usuario)
        {
            try
            {
                _connectionManager.Open();
                _usuarioReprository.GuardarUsuario(usuario);
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
        
        public Usuario BuscarPorNombre(string nombre){
            try
            {
               _connectionManager.Open();
               return  _usuarioReprository.buscarPorNombre(nombre);
            }
            finally
            {
               _connectionManager.Close(); 
            } 
            
        }

        public IList<Usuario> BuscarUsusarios()
        {
            try
            {
                _connectionManager.Open();

                return _usuarioReprository.buscarUsuarios();
            }
            finally
            {
                _connectionManager.Close();
            }

        }

    }

}