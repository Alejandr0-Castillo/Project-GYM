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
    public partial class FormularioModicarUser : Form
    {
        // Propiedad para almacenar el ID de la marca
        public int MarcaID { get; set; }

        public FormularioModicarUser()
        {
            InitializeComponent();
            CargarTiposEjercicio();
        }

        private void CargarTiposEjercicio()
        {
            CBtipoEjer.Items.AddRange(new string[] {
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
        }

        private void BotonGuardarModiU_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombreM.Text) || CBtipoEjer.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor complete los campos obligatorios", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (MySqlConnection conexion = Conexion.ObtenerConexion())
            {
                try
                {
                    conexion.Open();
                    string query = @"UPDATE registromarca 
                           SET NombreMarca = @Nombre, 
                               TipoEjercicio = @Ejercicio, 
                               PesoUtilizado = @Peso, 
                               DistanciaRecorrida = @Distancia, 
                               TiempoDuracion = @Tiempo 
                           WHERE MarcaID = @MarcaId";

                    using (MySqlCommand cmd = new MySqlCommand(query, conexion))
                    {
                        // Valores obligatorios
                        cmd.Parameters.AddWithValue("@MarcaId", MarcaID);
                        cmd.Parameters.AddWithValue("@Nombre", txtNombreM.Text);
                        cmd.Parameters.AddWithValue("@Ejercicio", CBtipoEjer.Text);

                        // Valores opcionales con manejo de nulos
                        if (decimal.TryParse(txtPeso.Text, out decimal peso))
                            cmd.Parameters.AddWithValue("@Peso", peso);
                        else
                            cmd.Parameters.AddWithValue("@Peso", DBNull.Value);

                        if (decimal.TryParse(txtDistancia.Text, out decimal distancia))
                            cmd.Parameters.AddWithValue("@Distancia", distancia);
                        else
                            cmd.Parameters.AddWithValue("@Distancia", DBNull.Value);

                        if (!string.IsNullOrEmpty(txtTiempo.Text))
                        {
                            if (TimeSpan.TryParse(txtTiempo.Text, out TimeSpan tiempo))
                                cmd.Parameters.AddWithValue("@Tiempo", tiempo);
                            else
                                cmd.Parameters.AddWithValue("@Tiempo", DBNull.Value);
                        }
                        else
                            cmd.Parameters.AddWithValue("@Tiempo", DBNull.Value);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Marca actualizada exitosamente", "Éxito",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DialogResult = DialogResult.OK;
                        Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al actualizar marca: {ex.Message}\n\nDetalles: {ex.InnerException?.Message}",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
