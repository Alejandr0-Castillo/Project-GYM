namespace Proyecto_MuscleMap
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            PanelPrincipal = new Panel();
            BotonInicioSesion = new Button();
            label3 = new Label();
            label4 = new Label();
            BotonRegistro = new Button();
            label2 = new Label();
            label1 = new Label();
            PanelContenedor = new Panel();
            PanelCon = new Panel();
            BotonIniciar = new Button();
            panel7 = new Panel();
            textBox2 = new TextBox();
            label18 = new Label();
            panel8 = new Panel();
            textBox5 = new TextBox();
            label19 = new Label();
            label22 = new Label();
            pictureBox3 = new PictureBox();
            PanelRegistro = new Panel();
            botonRegistrar = new Button();
            dateTimePicker1 = new DateTimePicker();
            PanelFechaDeNacimiento = new Panel();
            label10 = new Label();
            PanelRut = new Panel();
            textBoxRut = new TextBox();
            label9 = new Label();
            PanelContra = new Panel();
            textBoxContrase = new TextBox();
            label8 = new Label();
            PanelCorreo = new Panel();
            textBoxCorreoElectronico = new TextBox();
            label7 = new Label();
            PanelNombre = new Panel();
            textBoxNombreCompleto = new TextBox();
            label6 = new Label();
            label5 = new Label();
            button1 = new Button();
            PanelRutInit = new Panel();
            label12 = new Label();
            PanelContraInit = new Panel();
            textBoxContraIni = new TextBox();
            label13 = new Label();
            label16 = new Label();
            pictureBox2 = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            label11 = new Label();
            label14 = new Label();
            label15 = new Label();
            label17 = new Label();
            pictureBox4 = new PictureBox();
            PanelPrincipal.SuspendLayout();
            PanelContenedor.SuspendLayout();
            PanelCon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            PanelRegistro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // PanelPrincipal
            // 
            PanelPrincipal.BackColor = Color.Black;
            PanelPrincipal.Controls.Add(BotonInicioSesion);
            PanelPrincipal.Controls.Add(label3);
            PanelPrincipal.Controls.Add(label4);
            PanelPrincipal.Controls.Add(BotonRegistro);
            PanelPrincipal.Controls.Add(label2);
            PanelPrincipal.Controls.Add(label1);
            PanelPrincipal.Location = new Point(0, 40);
            PanelPrincipal.Name = "PanelPrincipal";
            PanelPrincipal.Size = new Size(800, 370);
            PanelPrincipal.TabIndex = 0;
            // 
            // BotonInicioSesion
            // 
            BotonInicioSesion.BackColor = Color.Transparent;
            BotonInicioSesion.FlatAppearance.BorderColor = Color.Orange;
            BotonInicioSesion.FlatAppearance.MouseDownBackColor = SystemColors.ScrollBar;
            BotonInicioSesion.FlatAppearance.MouseOverBackColor = Color.Orange;
            BotonInicioSesion.FlatStyle = FlatStyle.Flat;
            BotonInicioSesion.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BotonInicioSesion.ForeColor = Color.Orange;
            BotonInicioSesion.Location = new Point(35, 220);
            BotonInicioSesion.Name = "BotonInicioSesion";
            BotonInicioSesion.Size = new Size(331, 41);
            BotonInicioSesion.TabIndex = 6;
            BotonInicioSesion.Text = "Iniciar sesión";
            BotonInicioSesion.UseVisualStyleBackColor = false;
            BotonInicioSesion.Click += BotonIniciarSesion_Click;
            BotonInicioSesion.MouseEnter += BotonMouseEnter;
            BotonInicioSesion.MouseLeave += BotonMouseLeave;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(35, 147);
            label3.Name = "label3";
            label3.Size = new Size(332, 24);
            label3.TabIndex = 5;
            label3.Text = "Da click en iniciar sesión para acceder";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(48, 84);
            label4.Name = "label4";
            label4.Size = new Size(299, 31);
            label4.TabIndex = 4;
            label4.Text = "¿Ya estas registrado?";
            // 
            // BotonRegistro
            // 
            BotonRegistro.BackColor = Color.Transparent;
            BotonRegistro.FlatAppearance.BorderColor = Color.Orange;
            BotonRegistro.FlatAppearance.MouseDownBackColor = SystemColors.ScrollBar;
            BotonRegistro.FlatAppearance.MouseOverBackColor = Color.Orange;
            BotonRegistro.FlatStyle = FlatStyle.Flat;
            BotonRegistro.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BotonRegistro.ForeColor = Color.Orange;
            BotonRegistro.Location = new Point(440, 220);
            BotonRegistro.Name = "BotonRegistro";
            BotonRegistro.Size = new Size(331, 41);
            BotonRegistro.TabIndex = 3;
            BotonRegistro.Text = "Registrarse";
            BotonRegistro.UseVisualStyleBackColor = false;
            BotonRegistro.Click += BotonRegistro_Click;
            BotonRegistro.MouseEnter += BotonMouseEnter;
            BotonRegistro.MouseLeave += BotonMouseLeave;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(411, 147);
            label2.Name = "label2";
            label2.Size = new Size(372, 24);
            label2.TabIndex = 2;
            label2.Text = "Registrate dando click en el botón de abajo";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(416, 84);
            label1.Name = "label1";
            label1.Size = new Size(355, 31);
            label1.TabIndex = 1;
            label1.Text = "¿Aún no estas registrado?";
            // 
            // PanelContenedor
            // 
            PanelContenedor.BackColor = Color.White;
            PanelContenedor.Controls.Add(PanelCon);
            PanelContenedor.Controls.Add(PanelRegistro);
            PanelContenedor.Location = new Point(0, 10);
            PanelContenedor.Name = "PanelContenedor";
            PanelContenedor.Size = new Size(410, 430);
            PanelContenedor.TabIndex = 1;
            // 
            // PanelCon
            // 
            PanelCon.Controls.Add(label14);
            PanelCon.Controls.Add(label11);
            PanelCon.Controls.Add(BotonIniciar);
            PanelCon.Controls.Add(panel7);
            PanelCon.Controls.Add(textBox2);
            PanelCon.Controls.Add(label18);
            PanelCon.Controls.Add(panel8);
            PanelCon.Controls.Add(textBox5);
            PanelCon.Controls.Add(label19);
            PanelCon.Controls.Add(label22);
            PanelCon.Controls.Add(pictureBox3);
            PanelCon.Location = new Point(6, 5);
            PanelCon.Name = "PanelCon";
            PanelCon.Size = new Size(400, 430);
            PanelCon.TabIndex = 3;
            // 
            // BotonIniciar
            // 
            BotonIniciar.BackColor = Color.Black;
            BotonIniciar.FlatAppearance.BorderColor = Color.Orange;
            BotonIniciar.FlatAppearance.MouseDownBackColor = SystemColors.ScrollBar;
            BotonIniciar.FlatAppearance.MouseOverBackColor = Color.DarkOrange;
            BotonIniciar.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BotonIniciar.ForeColor = Color.Orange;
            BotonIniciar.Location = new Point(9, 258);
            BotonIniciar.Name = "BotonIniciar";
            BotonIniciar.Size = new Size(362, 41);
            BotonIniciar.TabIndex = 17;
            BotonIniciar.Text = "Acceder";
            BotonIniciar.UseVisualStyleBackColor = false;
            BotonIniciar.MouseEnter += BotonMouseEnter;
            BotonIniciar.MouseLeave += BotonMouseLeave;
            // 
            // panel7
            // 
            panel7.BackColor = Color.DarkOrange;
            panel7.Location = new Point(14, 155);
            panel7.Name = "panel7";
            panel7.Size = new Size(362, 3);
            panel7.TabIndex = 13;
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(14, 135);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(362, 19);
            textBox2.TabIndex = 12;
            textBox2.Tag = "Rut";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label18.Location = new Point(14, 102);
            label18.Name = "label18";
            label18.Size = new Size(54, 20);
            label18.TabIndex = 11;
            label18.Text = "R.U.T:";
            // 
            // panel8
            // 
            panel8.BackColor = Color.DarkOrange;
            panel8.Location = new Point(13, 218);
            panel8.Name = "panel8";
            panel8.Size = new Size(362, 3);
            panel8.TabIndex = 10;
            // 
            // textBox5
            // 
            textBox5.BorderStyle = BorderStyle.None;
            textBox5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox5.Location = new Point(9, 198);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(362, 19);
            textBox5.TabIndex = 9;
            textBox5.Tag = "Contra";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label19.Location = new Point(9, 165);
            label19.Name = "label19";
            label19.Size = new Size(96, 20);
            label19.TabIndex = 8;
            label19.Text = "Contraseña:";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label22.Location = new Point(173, 29);
            label22.Name = "label22";
            label22.Size = new Size(187, 31);
            label22.TabIndex = 1;
            label22.Text = "Iniciar sesión";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(3, -3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(51, 63);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            // 
            // PanelRegistro
            // 
            PanelRegistro.Controls.Add(label15);
            PanelRegistro.Controls.Add(label17);
            PanelRegistro.Controls.Add(pictureBox4);
            PanelRegistro.Controls.Add(botonRegistrar);
            PanelRegistro.Controls.Add(dateTimePicker1);
            PanelRegistro.Controls.Add(PanelFechaDeNacimiento);
            PanelRegistro.Controls.Add(label10);
            PanelRegistro.Controls.Add(PanelRut);
            PanelRegistro.Controls.Add(textBoxRut);
            PanelRegistro.Controls.Add(label9);
            PanelRegistro.Controls.Add(PanelContra);
            PanelRegistro.Controls.Add(textBoxContrase);
            PanelRegistro.Controls.Add(label8);
            PanelRegistro.Controls.Add(PanelCorreo);
            PanelRegistro.Controls.Add(textBoxCorreoElectronico);
            PanelRegistro.Controls.Add(label7);
            PanelRegistro.Controls.Add(PanelNombre);
            PanelRegistro.Controls.Add(textBoxNombreCompleto);
            PanelRegistro.Controls.Add(label6);
            PanelRegistro.Controls.Add(label5);
            PanelRegistro.Location = new Point(6, 5);
            PanelRegistro.Name = "PanelRegistro";
            PanelRegistro.Size = new Size(390, 420);
            PanelRegistro.TabIndex = 2;
            // 
            // botonRegistrar
            // 
            botonRegistrar.BackColor = Color.Black;
            botonRegistrar.FlatAppearance.BorderColor = Color.Orange;
            botonRegistrar.FlatAppearance.MouseDownBackColor = SystemColors.ScrollBar;
            botonRegistrar.FlatAppearance.MouseOverBackColor = Color.DarkOrange;
            botonRegistrar.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            botonRegistrar.ForeColor = Color.Orange;
            botonRegistrar.Location = new Point(12, 374);
            botonRegistrar.Name = "botonRegistrar";
            botonRegistrar.Size = new Size(362, 41);
            botonRegistrar.TabIndex = 17;
            botonRegistrar.Text = "Registrar";
            botonRegistrar.UseVisualStyleBackColor = false;
            botonRegistrar.MouseEnter += BotonMouseEnter;
            botonRegistrar.MouseLeave += BotonMouseLeave;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarFont = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker1.CalendarTitleBackColor = Color.Orange;
            dateTimePicker1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker1.Location = new Point(9, 336);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(362, 22);
            dateTimePicker1.TabIndex = 2;
            // 
            // PanelFechaDeNacimiento
            // 
            PanelFechaDeNacimiento.BackColor = Color.DarkOrange;
            PanelFechaDeNacimiento.Location = new Point(9, 359);
            PanelFechaDeNacimiento.Name = "PanelFechaDeNacimiento";
            PanelFechaDeNacimiento.Size = new Size(362, 3);
            PanelFechaDeNacimiento.TabIndex = 16;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(9, 306);
            label10.Name = "label10";
            label10.Size = new Size(163, 20);
            label10.TabIndex = 14;
            label10.Text = "Fecha de Nacimiento:";
            // 
            // PanelRut
            // 
            PanelRut.BackColor = Color.DarkOrange;
            PanelRut.Location = new Point(9, 300);
            PanelRut.Name = "PanelRut";
            PanelRut.Size = new Size(362, 3);
            PanelRut.TabIndex = 13;
            // 
            // textBoxRut
            // 
            textBoxRut.BorderStyle = BorderStyle.None;
            textBoxRut.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxRut.Location = new Point(9, 280);
            textBoxRut.Name = "textBoxRut";
            textBoxRut.Size = new Size(362, 19);
            textBoxRut.TabIndex = 12;
            textBoxRut.Tag = "Rut";
            textBoxRut.Enter += txtEnter;
            textBoxRut.Leave += txtLeave;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(9, 247);
            label9.Name = "label9";
            label9.Size = new Size(54, 20);
            label9.TabIndex = 11;
            label9.Text = "R.U.T:";
            // 
            // PanelContra
            // 
            PanelContra.BackColor = Color.DarkOrange;
            PanelContra.Location = new Point(9, 241);
            PanelContra.Name = "PanelContra";
            PanelContra.Size = new Size(362, 3);
            PanelContra.TabIndex = 10;
            // 
            // textBoxContrase
            // 
            textBoxContrase.BorderStyle = BorderStyle.None;
            textBoxContrase.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxContrase.Location = new Point(9, 221);
            textBoxContrase.Name = "textBoxContrase";
            textBoxContrase.Size = new Size(362, 19);
            textBoxContrase.TabIndex = 9;
            textBoxContrase.Tag = "Contra";
            textBoxContrase.Enter += txtEnter;
            textBoxContrase.Leave += txtLeave;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(9, 188);
            label8.Name = "label8";
            label8.Size = new Size(96, 20);
            label8.TabIndex = 8;
            label8.Text = "Contraseña:";
            // 
            // PanelCorreo
            // 
            PanelCorreo.BackColor = Color.DarkOrange;
            PanelCorreo.Location = new Point(9, 178);
            PanelCorreo.Name = "PanelCorreo";
            PanelCorreo.Size = new Size(362, 3);
            PanelCorreo.TabIndex = 7;
            // 
            // textBoxCorreoElectronico
            // 
            textBoxCorreoElectronico.BorderStyle = BorderStyle.None;
            textBoxCorreoElectronico.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxCorreoElectronico.Location = new Point(9, 157);
            textBoxCorreoElectronico.Name = "textBoxCorreoElectronico";
            textBoxCorreoElectronico.Size = new Size(362, 19);
            textBoxCorreoElectronico.TabIndex = 6;
            textBoxCorreoElectronico.Tag = "Correo";
            textBoxCorreoElectronico.Enter += txtEnter;
            textBoxCorreoElectronico.Leave += txtLeave;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(9, 125);
            label7.Name = "label7";
            label7.Size = new Size(144, 20);
            label7.TabIndex = 5;
            label7.Text = "Correo Electrónico:";
            // 
            // PanelNombre
            // 
            PanelNombre.BackColor = Color.DarkOrange;
            PanelNombre.Location = new Point(12, 119);
            PanelNombre.Name = "PanelNombre";
            PanelNombre.Size = new Size(362, 3);
            PanelNombre.TabIndex = 4;
            // 
            // textBoxNombreCompleto
            // 
            textBoxNombreCompleto.BorderStyle = BorderStyle.None;
            textBoxNombreCompleto.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxNombreCompleto.Location = new Point(12, 99);
            textBoxNombreCompleto.Name = "textBoxNombreCompleto";
            textBoxNombreCompleto.Size = new Size(362, 19);
            textBoxNombreCompleto.TabIndex = 3;
            textBoxNombreCompleto.Tag = "Nombre";
            textBoxNombreCompleto.Enter += txtEnter;
            textBoxNombreCompleto.Leave += txtLeave;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(12, 66);
            label6.Name = "label6";
            label6.Size = new Size(141, 20);
            label6.TabIndex = 2;
            label6.Text = "Nombre Completo:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(189, 11);
            label5.Name = "label5";
            label5.Size = new Size(124, 31);
            label5.TabIndex = 1;
            label5.Text = "Registro";
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.FlatAppearance.BorderColor = Color.Orange;
            button1.FlatAppearance.MouseDownBackColor = SystemColors.ScrollBar;
            button1.FlatAppearance.MouseOverBackColor = Color.DarkOrange;
            button1.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Orange;
            button1.Location = new Point(9, 268);
            button1.Name = "button1";
            button1.Size = new Size(362, 41);
            button1.TabIndex = 17;
            button1.Text = "Acceder";
            button1.UseVisualStyleBackColor = false;
            // 
            // PanelRutInit
            // 
            PanelRutInit.BackColor = Color.DarkOrange;
            PanelRutInit.Location = new Point(12, 172);
            PanelRutInit.Name = "PanelRutInit";
            PanelRutInit.Size = new Size(362, 3);
            PanelRutInit.TabIndex = 13;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.Location = new Point(12, 119);
            label12.Name = "label12";
            label12.Size = new Size(54, 20);
            label12.TabIndex = 11;
            label12.Text = "R.U.T:";
            // 
            // PanelContraInit
            // 
            PanelContraInit.BackColor = Color.DarkOrange;
            PanelContraInit.Location = new Point(12, 241);
            PanelContraInit.Name = "PanelContraInit";
            PanelContraInit.Size = new Size(362, 3);
            PanelContraInit.TabIndex = 10;
            // 
            // textBoxContraIni
            // 
            textBoxContraIni.BorderStyle = BorderStyle.None;
            textBoxContraIni.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxContraIni.Location = new Point(12, 221);
            textBoxContraIni.Name = "textBoxContraIni";
            textBoxContraIni.Size = new Size(362, 19);
            textBoxContraIni.TabIndex = 9;
            textBoxContraIni.Tag = "ContraInit";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.Location = new Point(12, 188);
            label13.Name = "label13";
            label13.Size = new Size(96, 20);
            label13.TabIndex = 8;
            label13.Text = "Contraseña:";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.Location = new Point(185, 16);
            label16.Name = "label16";
            label16.Size = new Size(191, 31);
            label16.TabIndex = 1;
            label16.Text = "Iniciar Sesión";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(134, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(51, 61);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // timer1
            // 
            timer1.Interval = 1;
            timer1.Tick += timer1_Tick;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.ForeColor = Color.DarkOrange;
            label11.Location = new Point(42, 7);
            label11.Name = "label11";
            label11.Size = new Size(45, 15);
            label11.TabIndex = 18;
            label11.Text = "Muscle";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.ForeColor = Color.Black;
            label14.Location = new Point(83, 8);
            label14.Name = "label14";
            label14.Size = new Size(31, 15);
            label14.TabIndex = 19;
            label14.Text = "Map";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.ForeColor = Color.Black;
            label15.Location = new Point(83, 11);
            label15.Name = "label15";
            label15.Size = new Size(31, 15);
            label15.TabIndex = 22;
            label15.Text = "Map";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.ForeColor = Color.DarkOrange;
            label17.Location = new Point(42, 10);
            label17.Name = "label17";
            label17.Size = new Size(45, 15);
            label17.TabIndex = 21;
            label17.Text = "Muscle";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(3, 0);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(51, 63);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 20;
            pictureBox4.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(PanelContenedor);
            Controls.Add(PanelPrincipal);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            PanelPrincipal.ResumeLayout(false);
            PanelPrincipal.PerformLayout();
            PanelContenedor.ResumeLayout(false);
            PanelCon.ResumeLayout(false);
            PanelCon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            PanelRegistro.ResumeLayout(false);
            PanelRegistro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel PanelPrincipal;
        private Label label1;
        private Button BotonRegistro;
        private Label label2;
        private Button BotonInicioSesion;
        private Label label3;
        private Label label4;
        private Panel PanelContenedor;
        private Panel PanelRegistro;
        private TextBox textBoxNombreCompleto;
        private Label label6;
        private Label label5;
        private Panel PanelCorreo;
        private TextBox textBoxCorreoElectronico;
        private Label label7;
        private Panel PanelNombre;
        private Panel PanelFechaDeNacimiento;
        private Label label10;
        private Panel PanelRut;
        private TextBox textBoxRut;
        private Label label9;
        private Panel PanelContra;
        private TextBox textBoxContrase;
        private Label label8;
        private DateTimePicker dateTimePicker1;
        private Button botonRegistrar;
        private Button button1;
        private DateTimePicker dateTimePicker2;
        private Panel panel2;
        private Label label11;
        private Panel PanelRutInit;
        private TextBox textBox1;
        private Label label12;
        private Panel PanelContraInit;
        private TextBox textBoxContraIni;
        private Label label13;
        private Panel panel5;
        private TextBox textBox3;
        private Label label14;
        private Panel panel6;
        private TextBox textBox4;
        private Label label15;
        private Label label16;
        private PictureBox pictureBox2;
        private Panel PanelCon;
        private Button BotonIniciar;
        private Panel panel7;
        private TextBox textBox2;
        private Label label18;
        private Panel panel8;
        private TextBox textBox5;
        private Label label19;
        private Label label22;
        private PictureBox pictureBox3;
        private System.Windows.Forms.Timer timer1;
        private Label label17;
        private PictureBox pictureBox4;
    }
}
