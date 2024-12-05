using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Proyecto_MuscleMap.Formularios
{
    public partial class FormularioProgreso : Form
    {
        private string rutUsuario;

        public FormularioProgreso(string rut)
        {
            InitializeComponent();
            this.rutUsuario = rut;
            CargarDatosUsuario();
        }

        private void CargarDatosUsuario()
        {
            MySqlConnection conexion = Conexion.ObtenerConexion();

            try
            {
                conexion.Open();
                string query = "SELECT MarcaID, NombreMarca, TipoEjercicio, FechaRegistro, " +
                              "PesoUtilizado, DistanciaRecorrida, TiempoDuracion " +
                              "FROM registromarca WHERE UsuarioRut = @Rut " +
                              "ORDER BY FechaRegistro DESC";

                using (MySqlCommand cmd = new MySqlCommand(query, conexion))
                {
                    cmd.Parameters.AddWithValue("@Rut", rutUsuario);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable tabla = new DataTable();
                    adapter.Fill(tabla);

                    DgVProgre.DataSource = tabla;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexion.Close();
            }
        }
        private void MostrarData_Click(object sender, EventArgs e)
        {
            CargarDatosUsuario();
        }
        //
        //Filtrado por el nombre de la marca
        //
        private void BuscadorYFiltrado_TextChanged(object sender, EventArgs e)
        {
            if (DgVProgre.DataSource != null)
            {
                string filtro = BuscadorYFiltrado.Text.Trim();

                ((DataTable)DgVProgre.DataSource).DefaultView.RowFilter = string.Format(
                    "NombreMarca LIKE '%{0}%'",
                    filtro.Replace("'", "''"));
            }
        }

        private void BotonModificarUser_Click(object sender, EventArgs e)
        {
            if ((DgVProgre.SelectedRows.Count > 0))
            {
                FormularioModicarUser frm = new FormularioModicarUser();

                // Asegúrate de que los índices coincidan con el orden de las columnas en tu DataGridView
                frm.txtNombreM.Text = DgVProgre.CurrentRow.Cells["NombreMarca"].Value?.ToString();
                frm.CBtipoEjer.Text = DgVProgre.CurrentRow.Cells["TipoEjercicio"].Value?.ToString();
                frm.txtPeso.Text = DgVProgre.CurrentRow.Cells["PesoUtilizado"].Value?.ToString();
                frm.txtDistancia.Text = DgVProgre.CurrentRow.Cells["DistanciaRecorrida"].Value?.ToString();
                frm.txtTiempo.Text = DgVProgre.CurrentRow.Cells["TiempoDuracion"].Value?.ToString();

                // Guardar el ID de la marca para usarlo en la actualización
                frm.MarcaID = Convert.ToInt32(DgVProgre.CurrentRow.Cells["MarcaID"].Value);

                if (frm.ShowDialog() == DialogResult.OK)
                {
                    CargarDatosUsuario(); // Recargar el DataGridView después de modificar
                }
            }
            else
                MessageBox.Show("Por favor seleccione una fila");
        }
    }
}

