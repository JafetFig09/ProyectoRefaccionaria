using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoRefaccionaria.Entidades
{
    public class Camion
    {
        public int IdCamion { get; set; }

        public string Nombre { get; set; }

        public decimal Totalmacenaje { get; set; }

        public string Placas { get; set; }

        public string Marca { get; set; }

        public Camion(int IdCamion, string Nombre, decimal Totalmacenaje, string Placas,
            string Marca)
        {
            this.IdCamion = IdCamion;
            this.Nombre = Nombre;
            this.Totalmacenaje = Totalmacenaje;
            this.Placas = Placas;
            this.Marca = Marca;

        }
    }
}
