namespace Proyecto_MuscleMap.Formularios
{
    partial class FormularioProgreso
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
            panel1 = new Panel();
            DgVProgre = new DataGridView();
            panel4 = new Panel();
            BuscadorYFiltrado = new TextBox();
            panel2 = new Panel();
            panel3 = new Panel();
            BotonModificarUser = new FontAwesome.Sharp.IconButton();
            MostrarData = new FontAwesome.Sharp.IconButton();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgVProgre).BeginInit();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Moccasin;
            panel1.Controls.Add(DgVProgre);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 450);
            panel1.TabIndex = 0;
            // 
            // DgVProgre
            // 
            DgVProgre.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgVProgre.Dock = DockStyle.Fill;
            DgVProgre.Location = new Point(200, 100);
            DgVProgre.Name = "DgVProgre";
            DgVProgre.Size = new Size(600, 350);
            DgVProgre.TabIndex = 6;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Black;
            panel4.Controls.Add(label2);
            panel4.Controls.Add(BuscadorYFiltrado);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(200, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(600, 100);
            panel4.TabIndex = 5;
            // 
            // BuscadorYFiltrado
            // 
            BuscadorYFiltrado.Location = new Point(167, 47);
            BuscadorYFiltrado.Name = "BuscadorYFiltrado";
            BuscadorYFiltrado.Size = new Size(358, 23);
            BuscadorYFiltrado.TabIndex = 0;
            BuscadorYFiltrado.TextChanged += BuscadorYFiltrado_TextChanged;
            // 
            // panel2
            // 
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 450);
            panel2.TabIndex = 4;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Black;
            panel3.Controls.Add(BotonModificarUser);
            panel3.Controls.Add(MostrarData);
            panel3.Controls.Add(label1);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 68);
            panel3.Name = "panel3";
            panel3.Size = new Size(200, 382);
            panel3.TabIndex = 0;
            // 
            // BotonModificarUser
            // 
            BotonModificarUser.BackColor = Color.Black;
            BotonModificarUser.Dock = DockStyle.Bottom;
            BotonModificarUser.FlatAppearance.BorderSize = 0;
            BotonModificarUser.FlatStyle = FlatStyle.Flat;
            BotonModificarUser.ForeColor = Color.Orange;
            BotonModificarUser.IconChar = FontAwesome.Sharp.IconChar.Eye;
            BotonModificarUser.IconColor = Color.Orange;
            BotonModificarUser.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BotonModificarUser.IconSize = 32;
            BotonModificarUser.ImageAlign = ContentAlignment.MiddleLeft;
            BotonModificarUser.Location = new Point(0, 237);
            BotonModificarUser.Name = "BotonModificarUser";
            BotonModificarUser.Padding = new Padding(10, 0, 20, 0);
            BotonModificarUser.Size = new Size(200, 60);
            BotonModificarUser.TabIndex = 5;
            BotonModificarUser.Text = "Modificar";
            BotonModificarUser.TextAlign = ContentAlignment.MiddleLeft;
            BotonModificarUser.TextImageRelation = TextImageRelation.ImageBeforeText;
            BotonModificarUser.UseVisualStyleBackColor = false;
            BotonModificarUser.Click += BotonModificarUser_Click;
            // 
            // MostrarData
            // 
            MostrarData.BackColor = Color.Black;
            MostrarData.Dock = DockStyle.Bottom;
            MostrarData.FlatAppearance.BorderSize = 0;
            MostrarData.FlatStyle = FlatStyle.Flat;
            MostrarData.ForeColor = Color.Orange;
            MostrarData.IconChar = FontAwesome.Sharp.IconChar.Users;
            MostrarData.IconColor = Color.Orange;
            MostrarData.IconFont = FontAwesome.Sharp.IconFont.Auto;
            MostrarData.IconSize = 32;
            MostrarData.ImageAlign = ContentAlignment.MiddleLeft;
            MostrarData.Location = new Point(0, 297);
            MostrarData.Name = "MostrarData";
            MostrarData.Padding = new Padding(10, 0, 20, 0);
            MostrarData.Size = new Size(200, 60);
            MostrarData.TabIndex = 4;
            MostrarData.Text = "Mostrar Progreso";
            MostrarData.TextAlign = ContentAlignment.MiddleLeft;
            MostrarData.TextImageRelation = TextImageRelation.ImageBeforeText;
            MostrarData.UseVisualStyleBackColor = false;
            MostrarData.Click += MostrarData_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Bottom;
            label1.Font = new Font("Segoe UI", 13F);
            label1.ForeColor = Color.Orange;
            label1.Location = new Point(0, 357);
            label1.Name = "label1";
            label1.Size = new Size(87, 25);
            label1.TabIndex = 0;
            label1.Text = "Opciones";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.ForeColor = Color.Orange;
            label2.Location = new Point(16, 49);
            label2.Name = "label2";
            label2.Size = new Size(145, 21);
            label2.TabIndex = 1;
            label2.Text = "Buscador de marca:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F);
            label3.Location = new Point(41, 29);
            label3.Name = "label3";
            label3.Size = new Size(72, 25);
            label3.TabIndex = 1;
            label3.Text = "Muscle";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F);
            label4.ForeColor = Color.Orange;
            label4.Location = new Point(106, 29);
            label4.Name = "label4";
            label4.Size = new Size(36, 25);
            label4.TabIndex = 2;
            label4.Text = "Up";
            // 
            // FormularioProgreso
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "FormularioProgreso";
            Text = "Form1";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DgVProgre).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView DgVProgre;
        private Panel panel4;
        private TextBox BuscadorYFiltrado;
        private Panel panel2;
        private Panel panel3;
        private Label label1;
        private FontAwesome.Sharp.IconButton MostrarData;
        private FontAwesome.Sharp.IconButton BotonModificarUser;
        private Label label2;
        private Label label4;
        private Label label3;
    }
}