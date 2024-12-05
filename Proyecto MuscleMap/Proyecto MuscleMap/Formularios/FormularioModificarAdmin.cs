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
    public partial class FormularioModificarAdmin : Form
    {
        public FormularioModificarAdmin()
        {
            InitializeComponent();
        }

        private void BotonGuardarModiA_Click(object sender, EventArgs e)
        {
            MySqlConnection conexion = Conexion.ObtenerConexion();
            try
            {
                conexion.Open();
                string query = "UPDATE usuarios SET Rut = '"+txtRutt.Text+"', NombreCompleto = '"+txtNombree.Text +"', CorreoElectronico = '"+txtContras.Text +"', " +
                    "Contrasena = '"+txtContras.Text +"', Rol = '"+txtRol.Text+"' WHERE UsuarioID = '"+txtIDD.Text +"'";
                MySqlDataAdapter sda = new MySqlDataAdapter(query, conexion);
                sda.SelectCommand.ExecuteNonQuery();
                MessageBox.Show("Modificacion Exitosa");
                conexion.Close();
            }
            catch (Exception w)
            {

                MessageBox.Show("Error" + w);
            }
            finally
            {
                conexion.Close();
            }
        }
    }
}
