namespace Proyecto_MuscleMap
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Para el cambio de color al presionar los botones
        private void BotonMouseEnter(object sender, EventArgs e)
        {
            Button bt = sender as Button;
            foreach (Control ctr in PanelPrincipal.Controls)
            {
                if (ctr is Button)
                {
                    bt.ForeColor = Color.Black;
                }
            }
        }

        //cambio de color cuando dejas de dar click en el boton
        private void BotonMouseLeave(object sender, EventArgs e)
        {
            Button bt = sender as Button;
            foreach (Control ctr in PanelPrincipal.Controls)
            {
                if (ctr is Button)
                {
                    bt.ForeColor = Color.Orange;
                }
            }
        }
        //Cambio de color de los paneles al presionar un TextBox del panel 
        private void txtEnter(object sender, EventArgs e)
        {
            TextBox tx = sender as TextBox;
            foreach (Control ctr in PanelRegistro.Controls)
            {
                if (ctr is Panel && ctr.Name == "Panel" + tx.Tag.ToString())
                {
                    ctr.BackColor = Color.Black;
                }
            }
        }
        //Color inicial de los paneles que estan debajo de cada TextBox del panel Registro
        private void txtLeave(object sender, EventArgs e)
        {
            TextBox tx = sender as TextBox;
            foreach (Control ctr in PanelRegistro.Controls)
            {
                if (ctr is Panel && ctr.Name == "Panel" + tx.Tag.ToString())
                {
                    ctr.BackColor = Color.DarkOrange;
                }
            }
        }
        //Se crea un contador (Timer) para el movimiento de los paneles creando una "animación"
        private bool controlTimer = false;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!controlTimer)
            {
                PanelContenedor.Left += 10;
                PanelRegistro.BringToFront();
                if (PanelContenedor.Left == 400)
                {
                    timer1.Stop();
                    controlTimer = true;
                }
            }
            else
            {
                PanelContenedor.Left -= 10;
                PanelCon.BringToFront();
                if (PanelContenedor.Left == 0)
                {
                    timer1.Stop();
                    controlTimer = false;
                }
            }
        }
        //Se crea eventos que al dar click a los botones Registrar o Acceder cambie de posición los paneles
        private void BotonRegistro_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
        private void BotonIniciarSesion_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void botonRegistrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxNombreCompleto.Text) ||
                string.IsNullOrWhiteSpace(textBoxCorreoElectronico.Text) ||
                string.IsNullOrWhiteSpace(textBoxRut.Text) ||
                string.IsNullOrWhiteSpace(textBoxContrase.Text))
            {
                MessageBox.Show("Por favor complete todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool registroExitoso = Conexion.RegistrarUsuario(
                textBoxNombreCompleto.Text,
                textBoxCorreoElectronico.Text,
                textBoxRut.Text,
                textBoxContrase.Text,
                dateTimePicker1.Value
            );
            if (registroExitoso)
            {
                MessageBox.Show("Usuario registrado exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCamposRegistro();
            }
        }
        private void BotonIniciar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox2.Text) || string.IsNullOrWhiteSpace(textBox5.Text))
            {
                MessageBox.Show("Por favor ingrese RUT y contraseña", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var (exito, rol) = Conexion.IniciarSesion(textBox2.Text, textBox5.Text);
            if (exito)
            {
                if (rol.ToLower() == "administrador")
                {
                    Form3 formAdmin = new Form3();
                    this.Hide();
                    formAdmin.ShowDialog();
                    this.Close();
                }
                else
                {
                    Form2 formUsuario = new Form2(textBox2.Text);
                    this.Hide();
                    formUsuario.ShowDialog();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("RUT y/o Contraseña incorrectas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LimpiarCamposRegistro()
        {
            textBoxNombreCompleto.Clear();
            textBoxCorreoElectronico.Clear();
            textBoxRut.Clear();
            textBoxContrase.Clear();
            dateTimePicker1.Value = DateTime.Now;
        }
    }
}
