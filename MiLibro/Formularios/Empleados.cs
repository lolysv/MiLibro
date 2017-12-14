using MiLibro.Model;
using MiLibro.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiLibro.Formularios
{
    public partial class Empleados : Form
    {
        public Empleados()
        {
            InitializeComponent();
            UpdateDataGrid();
        }

        private void AgregarBtn_Click(object sender, EventArgs e)
        {

        }

        private void ActualizarBtn_Click(object sender, EventArgs e)
        {

        }

        private void EliminarBtn_Click(object sender, EventArgs e)
        {
            delete();
        }

        private void BuscarBtn_Click(object sender, EventArgs e)
        {

        }

        void UpdateDataGrid()
        {
            List<EmpleadosModel> lista = new List<EmpleadosModel>();
            SqlDataReader reader = BasicServices.Instance.Read("SELECT * FROM empleados");
            while (reader.Read())
            {
                
                EmpleadosModel e = new EmpleadosModel()
                {
                    Id = reader.GetInt32(0),
                    Nombre = reader.GetString(1),
                    Apellido = reader.GetString(2),
                    Edad = reader.GetInt32(3),
                    Genero = reader.GetString(4),
                    FechaNacimiento = reader.GetDateTime(5),
                    EstadoCivil = reader.GetString(6),
                    NivelAcademico = reader.GetString(7),
                    Dui = reader.GetString(8),
                    Nit = reader.GetString(9),
                    Nup = reader.GetString(10),
                    Isss = reader.GetString(11),
                    Telefono = reader.GetInt32(12),
                    AreaLaboral = reader.GetString(13),
                    SueldoNominal = reader.GetDecimal(14),
                    Estado = reader.GetInt32(15)
                };
                lista.Add(e);
            }
            reader.Close();
            dataGrid.DataSource = null;
            dataGrid.DataSource = lista;
        }

        void delete()
        {
            int posicion = dataGrid.SelectedCells[0].RowIndex;
            string id = dataGrid.Rows[posicion].Cells[0].Value.ToString();
            BasicServices.Instance.Delete("DELETE FROM empleados WHERE id = " + id);
        }
    }
}
