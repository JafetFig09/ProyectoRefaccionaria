using ProyectoRefaccionaria.BD;
using ProyectoRefaccionaria.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoRefaccionaria.Servicios
{
    public class Servicio
    {
        private BaseDatos conexionBD;
        private Camion[] camionesBD;

        public Servicio()
        {
            conexionBD = new BaseDatos(@"DESKTOP-3R8J3AA\SQLEXPRESS", "refaccionaria");
            camionesBD = conexionBD.LeerBD();
        }


        public void CargarDatos(DataGridView dataGridView)
        {
            dataGridView.Rows.Clear();
            dataGridView.Columns.Clear();
            dataGridView.Columns.Add("IdCamion", "IdCamion");
            dataGridView.Columns.Add("Nombre", "Nombre");
            dataGridView.Columns.Add("TotalAlmacenaje", "Total Almacenaje");
            dataGridView.Columns.Add("Placas", "Placas");
            dataGridView.Columns.Add("Marca", "Marca");

            foreach(var camion  in camionesBD)
            {
                dataGridView.Rows.Add(camion.IdCamion, camion.Nombre, camion.Totalmacenaje,
               camion.Placas, camion.Marca);
            }
            
        }

        public void BuscarPorNombre(string nombre, DataGridView dataGridView)
        {
            Camion camion = null;

            for (int i = 0; i < camionesBD.Length; i++)
            {
                if (camionesBD[i].Nombre == nombre)
                {
                    camion = camionesBD[i];
                    break;
                }

            }

            if (camion != null)
            {
                ImprimirCamion(dataGridView, camion);
            }
            else
            {
                MessageBox.Show("Camión no encontrado", "Error");
            }
        }


        public void BuscarPorPlacas(string placas, DataGridView dataGridView)
        {
            Camion camion = null;

            for (int i = 0; i < camionesBD.Length; i++)
            {
                if (camionesBD[i].Placas == placas)
                {
                    camion = camionesBD[i];
                    break;
                }
  
            }

            if (camion != null)
            {
                ImprimirCamion(dataGridView, camion);
            }
            else
            {
                MessageBox.Show("Camión no encontrado", "Error");
            }

        }


        public void BuscarPorId(int Id, DataGridView dataGridView)
        {
            Camion camion = null;

            for (int i = 0; i < camionesBD.Length; i++)
            {
                if (camionesBD[i].IdCamion == Id)
                {
                    camion = camionesBD[i];

                    break;
                }

            }

            if (camion != null)
            {
                ImprimirCamion(dataGridView, camion);
            }
            else
            {
                MessageBox.Show("Camión no encontrado", "Error");
            }
        }


        public void BuscarPorMarca(string marca, DataGridView dataGridView)
        {
            Camion camion = null;

            for (int i = 0; i < camionesBD.Length; i++)
            {
                if (camionesBD[i].Marca == marca)
                {
                    camion = camionesBD[i];
                    break;
                }
           
            }
            if (camion != null)
            {
                ImprimirCamion(dataGridView, camion);
            }
            else
            {
                MessageBox.Show("Camión no encontrado", "Error");
            }
        }


        public void BuscarPorTotalmacenaje(decimal total, DataGridView dataGridView)
        {
            Camion camion = null;

            for (int i = 0; i < camionesBD.Length; i++)
            {
                if (camionesBD[i].Totalmacenaje == total)
                {
                    camion = camionesBD[i];
                    break;
                }

            }
            if (camion != null)
            {
                ImprimirCamion(dataGridView, camion);
            }
            else
            {
                MessageBox.Show("Camión no encontrado", "Error");
            }
        }


        public void ImprimirCamion(DataGridView dataGridView, Camion camion)
        {

            dataGridView.Rows.Clear();
            dataGridView.Columns.Clear();
            dataGridView.Columns.Add("IdCamion", "IdCamion");
            dataGridView.Columns.Add("Nombre", "Nombre");
            dataGridView.Columns.Add("TotalAlmacenaje", "Total Almacenaje");
            dataGridView.Columns.Add("Placas", "Placas");
            dataGridView.Columns.Add("Marca", "Marca");
            dataGridView.Rows.Add(camion.IdCamion,camion.Nombre,camion.Totalmacenaje,
                camion.Placas, camion.Marca);
        }


    }
}


