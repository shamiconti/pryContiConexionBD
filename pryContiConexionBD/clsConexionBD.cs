using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace pryContiConexionBD
{
    internal class clsConexionBD
    {
        public void ConectarBase(DataGridView dgvConexion)
        {
            string connectionString = "Server=PC229;Database=Comercio;Trusted_Connection=True;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = @"SELECT p.Codigo, p.Nombre, p.Descripcion, p.Precio, p.Stock, c.Nombre AS Categoria
                     FROM Productos p
                     INNER JOIN Categorias c ON p.CategoriaId = c.Id";
                    SqlCommand command = new SqlCommand(query, connection);

                    // Utilizando un DataTable para almacenar los resultados
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(command);
                    da.Fill(dt);  // Llenamos el DataTable con los resultados de la consulta

                    // Asignamos el DataTable al DataGridView
                    dgvConexion.DataSource = dt; // dataGridView1 es el nombre de tu grilla

                }
                catch (Exception ex)
                {
                    MessageBox.Show("❌ Error al conectar: " + ex.Message);
                }
            }
        }
    }
}
