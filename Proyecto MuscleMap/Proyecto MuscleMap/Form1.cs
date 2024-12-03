namespace Proyecto_MuscleMap
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
//Para el cambio de color 
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
                if(PanelContenedor.Left == 400)
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
    }
}
