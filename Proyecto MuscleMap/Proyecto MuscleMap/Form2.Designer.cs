namespace Proyecto_MuscleMap
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            PanelLateral = new Panel();
            BotonProgreso = new FontAwesome.Sharp.IconButton();
            BotonNuevaMarca = new FontAwesome.Sharp.IconButton();
            PanelLogo = new Panel();
            label2 = new Label();
            label1 = new Label();
            BotonInicio = new PictureBox();
            PanelHijo = new Panel();
            PanelEscritorio = new Panel();
            pictureBox1 = new PictureBox();
            PanelSombra = new Panel();
            PanelTitulo = new Panel();
            TituloFormHijo = new Label();
            IconHijo = new FontAwesome.Sharp.IconPictureBox();
            PanelLateral.SuspendLayout();
            PanelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BotonInicio).BeginInit();
            PanelHijo.SuspendLayout();
            PanelEscritorio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            PanelTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)IconHijo).BeginInit();
            SuspendLayout();
            // 
            // PanelLateral
            // 
            PanelLateral.AutoScroll = true;
            PanelLateral.BackColor = Color.Black;
            PanelLateral.Controls.Add(BotonProgreso);
            PanelLateral.Controls.Add(BotonNuevaMarca);
            PanelLateral.Controls.Add(PanelLogo);
            PanelLateral.Dock = DockStyle.Left;
            PanelLateral.Location = new Point(0, 0);
            PanelLateral.Name = "PanelLateral";
            PanelLateral.Size = new Size(250, 561);
            PanelLateral.TabIndex = 0;
            // 
            // BotonProgreso
            // 
            BotonProgreso.Dock = DockStyle.Top;
            BotonProgreso.FlatAppearance.BorderSize = 0;
            BotonProgreso.FlatStyle = FlatStyle.Flat;
            BotonProgreso.ForeColor = Color.Orange;
            BotonProgreso.IconChar = FontAwesome.Sharp.IconChar.ArrowTrendUp;
            BotonProgreso.IconColor = Color.Orange;
            BotonProgreso.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BotonProgreso.IconSize = 32;
            BotonProgreso.ImageAlign = ContentAlignment.MiddleLeft;
            BotonProgreso.Location = new Point(0, 160);
            BotonProgreso.Name = "BotonProgreso";
            BotonProgreso.Padding = new Padding(10, 0, 20, 0);
            BotonProgreso.Size = new Size(250, 60);
            BotonProgreso.TabIndex = 4;
            BotonProgreso.Text = "Progreso";
            BotonProgreso.TextAlign = ContentAlignment.MiddleLeft;
            BotonProgreso.TextImageRelation = TextImageRelation.ImageBeforeText;
            BotonProgreso.UseVisualStyleBackColor = true;
            BotonProgreso.Click += BotonProgreso_Click;
            // 
            // BotonNuevaMarca
            // 
            BotonNuevaMarca.Dock = DockStyle.Top;
            BotonNuevaMarca.FlatAppearance.BorderSize = 0;
            BotonNuevaMarca.FlatStyle = FlatStyle.Flat;
            BotonNuevaMarca.ForeColor = Color.Orange;
            BotonNuevaMarca.IconChar = FontAwesome.Sharp.IconChar.Dumbbell;
            BotonNuevaMarca.IconColor = Color.Orange;
            BotonNuevaMarca.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BotonNuevaMarca.IconSize = 32;
            BotonNuevaMarca.ImageAlign = ContentAlignment.MiddleLeft;
            BotonNuevaMarca.Location = new Point(0, 100);
            BotonNuevaMarca.Name = "BotonNuevaMarca";
            BotonNuevaMarca.Padding = new Padding(10, 0, 20, 0);
            BotonNuevaMarca.Size = new Size(250, 60);
            BotonNuevaMarca.TabIndex = 3;
            BotonNuevaMarca.Text = "Nueva Marca";
            BotonNuevaMarca.TextAlign = ContentAlignment.MiddleLeft;
            BotonNuevaMarca.TextImageRelation = TextImageRelation.ImageBeforeText;
            BotonNuevaMarca.UseVisualStyleBackColor = true;
            BotonNuevaMarca.Click += BotonNuevaMarca_Click;
            // 
            // PanelLogo
            // 
            PanelLogo.BackColor = Color.Moccasin;
            PanelLogo.Controls.Add(label2);
            PanelLogo.Controls.Add(label1);
            PanelLogo.Controls.Add(BotonInicio);
            PanelLogo.Dock = DockStyle.Top;
            PanelLogo.Location = new Point(0, 0);
            PanelLogo.Name = "PanelLogo";
            PanelLogo.Size = new Size(250, 100);
            PanelLogo.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(173, 9);
            label2.Name = "label2";
            label2.Size = new Size(52, 28);
            label2.TabIndex = 2;
            label2.Text = "Map";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.ForeColor = Color.Orange;
            label1.Location = new Point(107, 9);
            label1.Name = "label1";
            label1.Size = new Size(73, 28);
            label1.TabIndex = 1;
            label1.Text = "Muscle";
            // 
            // BotonInicio
            // 
            BotonInicio.Image = (Image)resources.GetObject("BotonInicio.Image");
            BotonInicio.Location = new Point(43, 12);
            BotonInicio.Name = "BotonInicio";
            BotonInicio.Size = new Size(95, 80);
            BotonInicio.SizeMode = PictureBoxSizeMode.Zoom;
            BotonInicio.TabIndex = 0;
            BotonInicio.TabStop = false;
            BotonInicio.Click += BotonInicio_Click;
            // 
            // PanelHijo
            // 
            PanelHijo.BackColor = SystemColors.ControlDark;
            PanelHijo.Controls.Add(PanelEscritorio);
            PanelHijo.Controls.Add(PanelSombra);
            PanelHijo.Controls.Add(PanelTitulo);
            PanelHijo.Dock = DockStyle.Fill;
            PanelHijo.Location = new Point(250, 0);
            PanelHijo.Name = "PanelHijo";
            PanelHijo.Size = new Size(684, 561);
            PanelHijo.TabIndex = 1;
            // 
            // PanelEscritorio
            // 
            PanelEscritorio.BackColor = Color.Moccasin;
            PanelEscritorio.Controls.Add(pictureBox1);
            PanelEscritorio.Dock = DockStyle.Fill;
            PanelEscritorio.Location = new Point(0, 87);
            PanelEscritorio.Name = "PanelEscritorio";
            PanelEscritorio.Size = new Size(684, 474);
            PanelEscritorio.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(169, 73);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(360, 237);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // PanelSombra
            // 
            PanelSombra.BackColor = Color.DarkOrange;
            PanelSombra.Dock = DockStyle.Top;
            PanelSombra.Location = new Point(0, 80);
            PanelSombra.Name = "PanelSombra";
            PanelSombra.Size = new Size(684, 7);
            PanelSombra.TabIndex = 1;
            // 
            // PanelTitulo
            // 
            PanelTitulo.BackColor = Color.Black;
            PanelTitulo.Controls.Add(TituloFormHijo);
            PanelTitulo.Controls.Add(IconHijo);
            PanelTitulo.Dock = DockStyle.Top;
            PanelTitulo.Location = new Point(0, 0);
            PanelTitulo.Name = "PanelTitulo";
            PanelTitulo.Size = new Size(684, 80);
            PanelTitulo.TabIndex = 0;
            PanelTitulo.MouseDown += PanelTitulo_MouseDown;
            // 
            // TituloFormHijo
            // 
            TituloFormHijo.AutoSize = true;
            TituloFormHijo.Font = new Font("Segoe UI", 15F);
            TituloFormHijo.ForeColor = Color.Coral;
            TituloFormHijo.Location = new Point(65, 23);
            TituloFormHijo.Name = "TituloFormHijo";
            TituloFormHijo.Size = new Size(59, 28);
            TituloFormHijo.TabIndex = 1;
            TituloFormHijo.Text = "Inicio";
            // 
            // IconHijo
            // 
            IconHijo.ForeColor = Color.Chocolate;
            IconHijo.IconChar = FontAwesome.Sharp.IconChar.House;
            IconHijo.IconColor = Color.Chocolate;
            IconHijo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            IconHijo.IconSize = 44;
            IconHijo.Location = new Point(23, 16);
            IconHijo.Name = "IconHijo";
            IconHijo.Size = new Size(50, 44);
            IconHijo.TabIndex = 0;
            IconHijo.TabStop = false;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(934, 561);
            Controls.Add(PanelHijo);
            Controls.Add(PanelLateral);
            Font = new Font("Segoe UI", 10F);
            MinimumSize = new Size(950, 600);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            PanelLateral.ResumeLayout(false);
            PanelLogo.ResumeLayout(false);
            PanelLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)BotonInicio).EndInit();
            PanelHijo.ResumeLayout(false);
            PanelEscritorio.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            PanelTitulo.ResumeLayout(false);
            PanelTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)IconHijo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel PanelLateral;
        private Panel PanelLogo;
        private PictureBox BotonInicio;
        private Panel PanelHijo;
        private FontAwesome.Sharp.IconButton BotonNuevaMarca;
        private FontAwesome.Sharp.IconButton BotonProgreso;
        private Panel PanelTitulo;
        private FontAwesome.Sharp.IconPictureBox IconHijo;
        private Label TituloFormHijo;
        private Panel PanelSombra;
        private Panel PanelEscritorio;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
    }
}