using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoRefaccionaria.BD
{
    public abstract class ConexionBD
    {
        private string _cadenaConexion;

        protected SqlConnection _conexion;

        public ConexionBD( string servidor, string bd)
        {
           _cadenaConexion = $"Data Source = {servidor}; " +
                $"Initial Catalog = {bd};" +
                " Integrated Security = True";
        }

        
        public void AbrirConexion()
        {
            _conexion = new SqlConnection(_cadenaConexion);

            _conexion.Open();
        }

        public void CerrarConexion()
        {
            if( _conexion != null && 
                _conexion.State == System.Data.ConnectionState.Open )
            {
                _conexion.Close();
            }
        }
            
    }
}
