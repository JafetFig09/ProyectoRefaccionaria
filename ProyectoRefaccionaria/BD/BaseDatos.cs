using ProyectoRefaccionaria.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoRefaccionaria.BD
{
    public class BaseDatos : ConexionBD
    {

        public BaseDatos(string servidor, string bd) : base(servidor, bd) 
        {
         
        }

        public Camion[] LeerBD()
        {
            int longitud = 0;
            int indice = 0;
            string consulta = "SELECT * FROM Camion";

            AbrirConexion();
            SqlCommand comando = new SqlCommand(consulta, _conexion);
            SqlDataReader datos = comando.ExecuteReader();

            while(datos.Read())
            {
                longitud++;
            }


            Camion[] camionesBD = new Camion[longitud];

            datos.Close();
            datos = comando.ExecuteReader();

            while (datos.Read())
            {
                int IdCamion = Convert.ToInt32(datos[0]);
                string Nombre = Convert.ToString(datos[1]);
                decimal Totalmacenaje = Convert.ToDecimal(datos[2]);
                string Placas = Convert.ToString(datos[3]);
                string Marca = Convert.ToString(datos[4]);

                camionesBD[indice] = new Camion(IdCamion,Nombre,Totalmacenaje,Placas,Marca);
                indice++;
            }

            CerrarConexion();

            return camionesBD;

        }
    }
}
