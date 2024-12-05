using MySql.Data;
using MySql.Data.MySqlClient;
using Proyecto_MuscleMap.Formularios;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Proyecto_MuscleMap
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        private void Form3_Load(object sender, EventArgs e)
        {

        }
        private void DgVUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            //Se inicia conexion con la base de datos creada del archivo "database.cs"
            MySqlConnection conexion = Conexion.ObtenerConexion();

            try
            {
                conexion.Open();
                MySqlCommand comando = new MySqlCommand();
                comando.Connection = conexion;
                comando.CommandText = ("SELECT * FROM usuarios");
                //Adaptar todo los datos de la consulta ingresada
                MySqlDataAdapter adaptar = new MySqlDataAdapter();
                adaptar.SelectCommand = comando;
                //crear una instancia 
                DataTable tabla = new DataTable();
                adaptar.Fill(tabla);
                //cuando ya sean adaptados, mostrar en el DataGridView
                DgVUsers.DataSource = tabla;
                conexion.Close();
            }
            catch (Exception b)
            {

                MessageBox.Show(b.Message + b.StackTrace);
            }
        }

        private void BotonModificarAdmin_Click(object sender, EventArgs e)
        {
            if ((DgVUsers.SelectedRows.Count > 0))
            {
                //Se crea una instancia para pasar datos formulario Padre a formulario Hijo
                FormularioModificarAdmin frm = new FormularioModificarAdmin();
                //posicion que debe mostrar del DataGridView en los TextBox
                frm.txtIDD.Text = DgVUsers.CurrentRow.Cells[0].Value.ToString();
                frm.txtRutt.Text = DgVUsers.CurrentRow.Cells[1].Value.ToString();
                frm.txtNombree.Text = DgVUsers.CurrentRow.Cells[2].Value.ToString();
                frm.txtCorreoo.Text = DgVUsers.CurrentRow.Cells[3].Value.ToString();
                frm.txtContras.Text = DgVUsers.CurrentRow.Cells[4].Value.ToString();
                frm.txtRol.Text = DgVUsers.CurrentRow.Cells[6].Value.ToString();
                //
                frm.ShowDialog();
            }
            else
                MessageBox.Show("Por favor seleccione una fila");
        }

        private void BotonEliminar_Click(object sender, EventArgs e)
        {
            if (DgVUsers.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("¿Está seguro de eliminar este usuario?", "Confirmar Eliminación",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string rut = DgVUsers.SelectedRows[0].Cells["Rut"].Value.ToString();
                    EliminarUsuario(rut);
                }
            }
            else
            {
                MessageBox.Show("Por favor seleccione un usuario para eliminar", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void EliminarUsuario(string rut)
        {
            using (MySqlConnection conexion = Conexion.ObtenerConexion())
            {
                if (conexion == null) return;


                // Luego eliminar el usuario
                string deleteUsuario = "DELETE FROM usuarios WHERE Rut = @Rut";
                using (MySqlCommand cmdUsuario = new MySqlCommand(deleteUsuario, conexion))
                {
                    conexion.Open();
                    cmdUsuario.Parameters.AddWithValue("@Rut", rut);
                    try
                    {
                        cmdUsuario.ExecuteNonQuery();
                        MessageBox.Show("Usuario eliminado correctamente", "Éxito",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Actualizar el DataGridView
                        DgVUsers.Rows.RemoveAt(DgVUsers.SelectedRows[0].Index);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al eliminar usuario: " + ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        conexion.Close();
                    }
                }
            }
        }
        //Filtrado por ID y Nombre
       private void TxtBuscadoFiltrado_TextChanged(object sender, EventArgs e)
        {
            if (DgVUsers.DataSource != null)
            {
                string filtro = TxtBuscadoFiltrado.Text.Trim();

                ((DataTable)DgVUsers.DataSource).DefaultView.RowFilter = string.Format(
                    "NombreCompleto LIKE '%{0}%' OR Convert(UsuarioID, 'System.String') LIKE '%{0}%'",
                    filtro.Replace("'", "''"));
            }
        }
    }
}
