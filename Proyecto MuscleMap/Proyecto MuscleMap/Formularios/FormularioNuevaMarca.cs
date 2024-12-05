using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;

namespace Proyecto_MuscleMap.Formularios
{
    public partial class FormularioNuevaMarca : Form
    {
        private string rutUsuario;
        public FormularioNuevaMarca(string rut)
        {
            InitializeComponent();
            this.rutUsuario = rut;

            comboEjercicio.Items.AddRange(new string[] {
            "Press de Banca",
            "Sentadillas",
            "Peso Muerto",
            "Dominadas",
            "Press Militar",
            "Curl de Bíceps",
            "Extensiones de Tríceps",
            "Remo con Barra",
            "Zancadas",
            "Correr en Cinta"
        });

            dateFecha.Value = DateTime.Now;
        }
        private void BotonGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMarca.Text) || comboEjercicio.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor complete los campos obligatorios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MySqlConnection conexion = Conexion.ObtenerConexion();
            try
            {
                conexion.Open();
                string query = @"INSERT INTO registromarca (UsuarioRut, NombreMarca, TipoEjercicio, FechaRegistro, 
                           PesoUtilizado, DistanciaRecorrida, TiempoDuracion) 
                           VALUES (@Rut, @Nombre, @Ejercicio, @Fecha, @Peso, @Km, @Tiempo)";

                using (MySqlCommand cmd = new MySqlCommand(query, conexion))
                {
                    cmd.Parameters.AddWithValue("@Rut", rutUsuario);
                    cmd.Parameters.AddWithValue("@Nombre", txtMarca.Text);
                    cmd.Parameters.AddWithValue("@Ejercicio", comboEjercicio.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@Fecha", dateFecha.Value.Date);
                    cmd.Parameters.AddWithValue("@Peso", string.IsNullOrEmpty(txtPeso.Text) ? DBNull.Value : (object)decimal.Parse(txtPeso.Text));
                    cmd.Parameters.AddWithValue("@Km", string.IsNullOrEmpty(txtKilometros.Text) ? DBNull.Value : (object)decimal.Parse(txtKilometros.Text));
                    cmd.Parameters.AddWithValue("@Tiempo", string.IsNullOrEmpty(txtTiempo.Text) ? DBNull.Value : (object)TimeSpan.Parse(txtTiempo.Text));

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Marca registrada exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar marca: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexion.Close();
            }
        }

        private void LimpiarCampos()
        {
            txtMarca.Clear();
            comboEjercicio.SelectedIndex = -1;
            dateFecha.Value = DateTime.Now;
            txtPeso.Clear();
            txtKilometros.Clear();
            txtTiempo.Clear();
        }
    }
    
}
