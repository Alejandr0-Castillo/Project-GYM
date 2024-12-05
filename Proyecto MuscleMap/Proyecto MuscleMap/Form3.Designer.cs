namespace Proyecto_MuscleMap
{
    partial class Form3
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
            PanelAdmin = new Panel();
            DgVUsers = new DataGridView();
            PanelSombra = new Panel();
            PanelTitulo = new Panel();
            label3 = new Label();
            PanelLateral = new Panel();
            label4 = new Label();
            TxtBuscadoFiltrado = new TextBox();
            BotonEliminar = new FontAwesome.Sharp.IconButton();
            BotonModificarAdmin = new FontAwesome.Sharp.IconButton();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            PanelLogo = new Panel();
            label2 = new Label();
            label1 = new Label();
            PanelAdmin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgVUsers).BeginInit();
            PanelTitulo.SuspendLayout();
            PanelLateral.SuspendLayout();
            PanelLogo.SuspendLayout();
            SuspendLayout();
            // 
            // PanelAdmin
            // 
            PanelAdmin.BackColor = SystemColors.ControlDark;
            PanelAdmin.Controls.Add(DgVUsers);
            PanelAdmin.Controls.Add(PanelSombra);
            PanelAdmin.Controls.Add(PanelTitulo);
            PanelAdmin.Dock = DockStyle.Fill;
            PanelAdmin.Location = new Point(250, 0);
            PanelAdmin.Name = "PanelAdmin";
            PanelAdmin.Size = new Size(550, 450);
            PanelAdmin.TabIndex = 3;
            // 
            // DgVUsers
            // 
            DgVUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgVUsers.Dock = DockStyle.Fill;
            DgVUsers.Location = new Point(0, 87);
            DgVUsers.Name = "DgVUsers";
            DgVUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgVUsers.Size = new Size(550, 363);
            DgVUsers.TabIndex = 2;
            DgVUsers.CellContentClick += DgVUsers_CellContentClick;
            // 
            // PanelSombra
            // 
            PanelSombra.BackColor = Color.DarkOrange;
            PanelSombra.Dock = DockStyle.Top;
            PanelSombra.Location = new Point(0, 80);
            PanelSombra.Name = "PanelSombra";
            PanelSombra.Size = new Size(550, 7);
            PanelSombra.TabIndex = 1;
            // 
            // PanelTitulo
            // 
            PanelTitulo.BackColor = Color.Black;
            PanelTitulo.Controls.Add(label3);
            PanelTitulo.Dock = DockStyle.Top;
            PanelTitulo.Location = new Point(0, 0);
            PanelTitulo.Name = "PanelTitulo";
            PanelTitulo.Size = new Size(550, 80);
            PanelTitulo.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.DarkOrange;
            label3.Location = new Point(73, 30);
            label3.Name = "label3";
            label3.Size = new Size(148, 28);
            label3.TabIndex = 0;
            label3.Text = "Administrador";
            // 
            // PanelLateral
            // 
            PanelLateral.AutoScroll = true;
            PanelLateral.BackColor = Color.Black;
            PanelLateral.Controls.Add(label4);
            PanelLateral.Controls.Add(TxtBuscadoFiltrado);
            PanelLateral.Controls.Add(BotonEliminar);
            PanelLateral.Controls.Add(BotonModificarAdmin);
            PanelLateral.Controls.Add(iconButton1);
            PanelLateral.Controls.Add(PanelLogo);
            PanelLateral.Dock = DockStyle.Left;
            PanelLateral.Location = new Point(0, 0);
            PanelLateral.Name = "PanelLateral";
            PanelLateral.Size = new Size(250, 450);
            PanelLateral.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.ForeColor = Color.Orange;
            label4.Location = new Point(12, 225);
            label4.Name = "label4";
            label4.Size = new Size(68, 19);
            label4.TabIndex = 7;
            label4.Text = "Buscador:";
            // 
            // TxtBuscadoFiltrado
            // 
            TxtBuscadoFiltrado.Dock = DockStyle.Bottom;
            TxtBuscadoFiltrado.Location = new Point(0, 247);
            TxtBuscadoFiltrado.Name = "TxtBuscadoFiltrado";
            TxtBuscadoFiltrado.Size = new Size(250, 23);
            TxtBuscadoFiltrado.TabIndex = 6;
            TxtBuscadoFiltrado.TextChanged += TxtBuscadoFiltrado_TextChanged;
            // 
            // BotonEliminar
            // 
            BotonEliminar.Dock = DockStyle.Bottom;
            BotonEliminar.FlatAppearance.BorderSize = 0;
            BotonEliminar.FlatStyle = FlatStyle.Flat;
            BotonEliminar.ForeColor = Color.Orange;
            BotonEliminar.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            BotonEliminar.IconColor = Color.Orange;
            BotonEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BotonEliminar.IconSize = 32;
            BotonEliminar.ImageAlign = ContentAlignment.MiddleLeft;
            BotonEliminar.Location = new Point(0, 270);
            BotonEliminar.Name = "BotonEliminar";
            BotonEliminar.Padding = new Padding(10, 0, 20, 0);
            BotonEliminar.Size = new Size(250, 60);
            BotonEliminar.TabIndex = 5;
            BotonEliminar.Text = "Eliminar";
            BotonEliminar.TextAlign = ContentAlignment.MiddleLeft;
            BotonEliminar.TextImageRelation = TextImageRelation.ImageBeforeText;
            BotonEliminar.UseVisualStyleBackColor = true;
            BotonEliminar.Click += BotonEliminar_Click;
            // 
            // BotonModificarAdmin
            // 
            BotonModificarAdmin.Dock = DockStyle.Bottom;
            BotonModificarAdmin.FlatAppearance.BorderSize = 0;
            BotonModificarAdmin.FlatStyle = FlatStyle.Flat;
            BotonModificarAdmin.ForeColor = Color.Orange;
            BotonModificarAdmin.IconChar = FontAwesome.Sharp.IconChar.Cog;
            BotonModificarAdmin.IconColor = Color.Orange;
            BotonModificarAdmin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BotonModificarAdmin.IconSize = 32;
            BotonModificarAdmin.ImageAlign = ContentAlignment.MiddleLeft;
            BotonModificarAdmin.Location = new Point(0, 330);
            BotonModificarAdmin.Name = "BotonModificarAdmin";
            BotonModificarAdmin.Padding = new Padding(10, 0, 20, 0);
            BotonModificarAdmin.Size = new Size(250, 60);
            BotonModificarAdmin.TabIndex = 4;
            BotonModificarAdmin.Text = "Modificar";
            BotonModificarAdmin.TextAlign = ContentAlignment.MiddleLeft;
            BotonModificarAdmin.TextImageRelation = TextImageRelation.ImageBeforeText;
            BotonModificarAdmin.UseVisualStyleBackColor = true;
            BotonModificarAdmin.Click += BotonModificarAdmin_Click;
            // 
            // iconButton1
            // 
            iconButton1.Dock = DockStyle.Bottom;
            iconButton1.FlatAppearance.BorderSize = 0;
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.ForeColor = Color.Orange;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.Users;
            iconButton1.IconColor = Color.Orange;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 32;
            iconButton1.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton1.Location = new Point(0, 390);
            iconButton1.Name = "iconButton1";
            iconButton1.Padding = new Padding(10, 0, 20, 0);
            iconButton1.Size = new Size(250, 60);
            iconButton1.TabIndex = 3;
            iconButton1.Text = "Usuarios";
            iconButton1.TextAlign = ContentAlignment.MiddleLeft;
            iconButton1.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton1.UseVisualStyleBackColor = true;
            iconButton1.Click += iconButton1_Click;
            // 
            // PanelLogo
            // 
            PanelLogo.BackColor = Color.Moccasin;
            PanelLogo.Controls.Add(label2);
            PanelLogo.Controls.Add(label1);
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
            label2.Location = new Point(106, 30);
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
            label1.Location = new Point(41, 30);
            label1.Name = "label1";
            label1.Size = new Size(73, 28);
            label1.TabIndex = 1;
            label1.Text = "Muscle";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(PanelAdmin);
            Controls.Add(PanelLateral);
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            PanelAdmin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DgVUsers).EndInit();
            PanelTitulo.ResumeLayout(false);
            PanelTitulo.PerformLayout();
            PanelLateral.ResumeLayout(false);
            PanelLateral.PerformLayout();
            PanelLogo.ResumeLayout(false);
            PanelLogo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel PanelAdmin;
        private Panel PanelSombra;
        private Panel PanelTitulo;
        private Panel PanelLateral;
        private FontAwesome.Sharp.IconButton BotonModificarAdmin;
        private FontAwesome.Sharp.IconButton iconButton1;
        private Panel PanelLogo;
        private Label label2;
        private Label label1;
        private Label label3;
        private DataGridView DgVUsers;
        private FontAwesome.Sharp.IconButton BotonEliminar;
        private TextBox TxtBuscadoFiltrado;
        private Label label4;
    }
}