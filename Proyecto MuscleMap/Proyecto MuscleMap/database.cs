using MySql.Data.MySqlClient;

namespace Proyecto_MuscleMap
{
    public class Conexion
    {
        private static string cadenaConexion = "Server=localhost;Database=MuscleMap;Uid=root;Pwd=;";

        public static MySqlConnection ObtenerConexion()
        {
            MySqlConnection conexion = new MySqlConnection(cadenaConexion);
            try
            {
                return conexion;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de conexión: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public static bool RegistrarUsuario(string nombreCompleto, string correo, string rut, string contrasena, DateTime fechaNacimiento)
        {
            using (MySqlConnection conexion = ObtenerConexion())
            {
                if (conexion == null) return false;

                string query = @"INSERT INTO usuarios (NombreCompleto, CorreoElectronico, Rut, Contrasena, FechaNacimiento, Rol) 
                               VALUES (@Nombre, @Correo, @Rut, @Contrasena, @FechaNac, 'Usuario')";

                try
                {
                    conexion.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conexion))
                    {
                        cmd.Parameters.AddWithValue("@Nombre", nombreCompleto);
                        cmd.Parameters.AddWithValue("@Correo", correo);
                        cmd.Parameters.AddWithValue("@Rut", rut);
                        cmd.Parameters.AddWithValue("@Contrasena", contrasena);
                        cmd.Parameters.AddWithValue("@FechaNac", fechaNacimiento);

                        cmd.ExecuteNonQuery();
                        return true;
                    }
                }
                catch (Exception exe)
                {
                    MessageBox.Show("Error al registrar: " + exe.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }

        public static (bool exito, string rol) IniciarSesion(string rut, string contrasena)
        {
            using (MySqlConnection conexion = ObtenerConexion())
            {
                if (conexion == null) return (false, null);

                string query = "SELECT Rol FROM usuarios WHERE Rut = @Rut AND Contrasena = @Contrasena";

                try
                {
                    conexion.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conexion))
                    {
                        cmd.Parameters.AddWithValue("@Rut", rut);
                        cmd.Parameters.AddWithValue("@Contrasena", contrasena);

                        object resultado = cmd.ExecuteScalar();
                        if (resultado != null)
                        {
                            return (true, resultado.ToString());
                        }
                        return (false, null);
                    }
                }
                catch (Exception exex)
                {
                    MessageBox.Show("Error al iniciar sesión: " + exex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return (false, null);
                }
            }
        }
        public static bool RegistrarNuevaMarca(string rut, string nombreMarca, string ejercicio, DateTime fecha, decimal? peso, decimal? kilometros, TimeSpan? tiempo)
        {
            using (MySqlConnection conexion = ObtenerConexion())
            {
                if (conexion == null) return false;

                string query = @"INSERT INTO registromarca (UsuarioRut, NombreMarca, TipoEjercicio, FechaRegistro, PesoUtilizado, DistanciaRecorrida, TiempoDuracion) 
                               VALUES (@UsuarioRut, @NombreMarca, @TipoEjercicio, @FechaRegistro, @PesoUtilizado, @DistanciaRecorrida, @TiempoDuracion)";
                try
                {
                    conexion.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conexion))
                    {
                        cmd.Parameters.AddWithValue("@UsuarioRut", rut);
                        cmd.Parameters.AddWithValue("@NombreMarca", nombreMarca);
                        cmd.Parameters.AddWithValue("@TipoEjercicio", ejercicio);
                        cmd.Parameters.AddWithValue("@FechaRegistro", fecha);
                        cmd.Parameters.AddWithValue("@PesoUtilizado", peso.HasValue ? (object)peso.Value : DBNull.Value);
                        cmd.Parameters.AddWithValue("@DistanciaRecorrida", kilometros.HasValue ? (object)kilometros.Value : DBNull.Value);
                        cmd.Parameters.AddWithValue("@TiempoDuracion", tiempo.HasValue ? (object)tiempo.Value : DBNull.Value);

                        cmd.ExecuteNonQuery();
                        return true;
                    }
                }
                catch (Exception exexe)
                {
                    MessageBox.Show("Error al registrar marca: " + exexe.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }
    }
}