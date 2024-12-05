using System.Runtime.InteropServices;
using FontAwesome.Sharp;
using Proyecto_MuscleMap.Formularios;

namespace Proyecto_MuscleMap
{
    public partial class Form2 : Form
    {
        private string rutUsuario;
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;
        //Construcción
        public Form2(string rut)
        {
            InitializeComponent();
            this.rutUsuario = rut;

            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            PanelLateral.Controls.Add(leftBorderBtn);
            //Formulario
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        private void BotonActivo(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DesactivarBoton();
                //personalizacion del boton
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.Black;
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleCenter;
                //personalizacion del borde izquierdo del boton
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                //Icono hijo de formulario
                IconHijo.IconChar = currentBtn.IconChar;
                IconHijo.IconColor = color;
            }
        }
        //Metodo para desactivar el resaltado del boton
        private void DesactivarBoton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.Black;
                currentBtn.ForeColor = Color.Orange;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Orange;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }
        private void AbrirFormularioHijo(Form childForm)
        {
            if (currentChildForm != null)
            {
                //abrira solamente el formulario
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            PanelEscritorio.Controls.Add(childForm);
            PanelEscritorio.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            TituloFormHijo.Text = childForm.Text;
        }

        private void BotonNuevaMarca_Click(object sender, EventArgs e)
        {
            BotonActivo(sender, Color.Chocolate);
            AbrirFormularioHijo(new FormularioNuevaMarca(rutUsuario));
        }

        private void BotonProgreso_Click(object sender, EventArgs e)
        {
            BotonActivo(sender, Color.Chocolate);
            AbrirFormularioHijo(new FormularioProgreso(rutUsuario));
        }

        private void BotonInicio_Click(object sender, EventArgs e)
        {
            currentChildForm.Close();
            Inicio();
        }
        private void Inicio()
        {
            DesactivarBoton();
            leftBorderBtn.Visible = false;
            IconHijo.IconChar = IconChar.Home;
            IconHijo.IconColor = Color.Chocolate;
            TituloFormHijo.Text = "Inicio";
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void PanelTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
