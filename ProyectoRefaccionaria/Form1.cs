using ProyectoRefaccionaria.Servicios;
using System.Windows.Forms;
namespace ProyectoRefaccionaria
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        Servicio servicio = new Servicio();

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void MostrarTodos_Click(object sender, EventArgs e)
        {
            servicio.CargarDatos(dataGridView1);
        }

        private void BuscarId_Click(object sender, EventArgs e)
        {
            if (int.TryParse(IdCamion.Text.Trim(), out int id) && IdCamion.Text.Trim() != "")
            {
                servicio.BuscarPorId(id, dataGridView1);
                IdCamion.Text = "";
            }
            else
            {
                MessageBox.Show("Algo ha ocurrido", "Error");
            }
        }



        private void BuscarNombre_Click_1(object sender, EventArgs e)
        {
            if (Nombre.Text.Trim() != "")
            {
                servicio.BuscarPorNombre(Nombre.Text.Trim(), dataGridView1);
                Nombre.Text = "";
            }
            else
            {
                MessageBox.Show("Algo ha ocurrido", "Error");
            }
        }

        private void BuscarTotal_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(Totalmacenaje.Text.Trim(), out decimal totalmacenaje) &&
                Totalmacenaje.Text.Trim() != "")
            {
                servicio.BuscarPorTotalmacenaje(totalmacenaje, dataGridView1);
                Totalmacenaje.Text = "";
            }
            else
            {
                MessageBox.Show("Algo ha ocurrido", "Error");
            }
        }

        private void BuscarPlacas_Click(object sender, EventArgs e)
        {
            if (Placas.Text.Trim() != "")
            {
                servicio.BuscarPorPlacas(Placas.Text.Trim().ToLower(), dataGridView1);
                Placas.Text = "";
            }
            else
            {
                MessageBox.Show("Algo ha ocurrido", "Error");
            }
        }

      

        private void BuscarMarca_Click(object sender, EventArgs e)
        {
            if (Marca.Text.Trim() != "")
            {
                servicio.BuscarPorMarca(Marca.Text.Trim(), dataGridView1);
                Nombre.Text = "";
            }
            else
            {
                MessageBox.Show("Algo ha ocurrido", "Error");
            }
        }
    }
}