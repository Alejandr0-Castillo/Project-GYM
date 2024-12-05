namespace Proyecto_MuscleMap.Formularios
{
    partial class FormularioModicarUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioModicarUser));
            label8 = new Label();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            BotonGuardarModiU = new Button();
            label6 = new Label();
            txtDistancia = new TextBox();
            label5 = new Label();
            txtNombreM = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtTiempo = new TextBox();
            txtPeso = new TextBox();
            CBtipoEjer = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 15F);
            label8.ForeColor = Color.Orange;
            label8.Location = new Point(241, 422);
            label8.Name = "label8";
            label8.Size = new Size(113, 28);
            label8.TabIndex = 36;
            label8.Text = "Modifitions";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(174, 422);
            label4.Name = "label4";
            label4.Size = new Size(73, 28);
            label4.TabIndex = 35;
            label4.Text = "Muscle";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(360, 377);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 85);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 34;
            pictureBox1.TabStop = false;
            // 
            // BotonGuardarModiU
            // 
            BotonGuardarModiU.BackColor = Color.Black;
            BotonGuardarModiU.ForeColor = Color.Orange;
            BotonGuardarModiU.Location = new Point(132, 308);
            BotonGuardarModiU.Name = "BotonGuardarModiU";
            BotonGuardarModiU.Size = new Size(115, 38);
            BotonGuardarModiU.TabIndex = 30;
            BotonGuardarModiU.Text = "Guardar";
            BotonGuardarModiU.UseVisualStyleBackColor = false;
            BotonGuardarModiU.Click += BotonGuardarModiU_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(87, 189);
            label6.Name = "label6";
            label6.Size = new Size(167, 15);
            label6.TabIndex = 29;
            label6.Text = "Distancia Recorrida (Opcional)";
            // 
            // txtDistancia
            // 
            txtDistancia.Location = new Point(87, 207);
            txtDistancia.Name = "txtDistancia";
            txtDistancia.Size = new Size(225, 23);
            txtDistancia.TabIndex = 28;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(87, 41);
            label5.Name = "label5";
            label5.Size = new Size(87, 15);
            label5.TabIndex = 27;
            label5.Text = "Nombre Marca";
            // 
            // txtNombreM
            // 
            txtNombreM.Location = new Point(87, 59);
            txtNombreM.Name = "txtNombreM";
            txtNombreM.Size = new Size(225, 23);
            txtNombreM.TabIndex = 26;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(87, 243);
            label3.Name = "label3";
            label3.Size = new Size(157, 15);
            label3.TabIndex = 25;
            label3.Text = "Tiempo Duracion (Opcional)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(87, 136);
            label2.Name = "label2";
            label2.Size = new Size(140, 15);
            label2.TabIndex = 24;
            label2.Text = "Peso Utilizado (Opcional)";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(87, 89);
            label1.Name = "label1";
            label1.Size = new Size(77, 15);
            label1.TabIndex = 23;
            label1.Text = "Tipo Ejercicio";
            // 
            // txtTiempo
            // 
            txtTiempo.Location = new Point(87, 261);
            txtTiempo.Name = "txtTiempo";
            txtTiempo.Size = new Size(225, 23);
            txtTiempo.TabIndex = 22;
            // 
            // txtPeso
            // 
            txtPeso.Location = new Point(87, 154);
            txtPeso.Name = "txtPeso";
            txtPeso.Size = new Size(225, 23);
            txtPeso.TabIndex = 21;
            // 
            // CBtipoEjer
            // 
            CBtipoEjer.FormattingEnabled = true;
            CBtipoEjer.Location = new Point(87, 107);
            CBtipoEjer.Name = "CBtipoEjer";
            CBtipoEjer.Size = new Size(225, 23);
            CBtipoEjer.TabIndex = 37;
            // 
            // FormularioModicarUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Moccasin;
            ClientSize = new Size(480, 485);
            Controls.Add(CBtipoEjer);
            Controls.Add(label8);
            Controls.Add(label4);
            Controls.Add(pictureBox1);
            Controls.Add(BotonGuardarModiU);
            Controls.Add(label6);
            Controls.Add(txtDistancia);
            Controls.Add(label5);
            Controls.Add(txtNombreM);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtTiempo);
            Controls.Add(txtPeso);
            Name = "FormularioModicarUser";
            Text = "FormularioModicarUser";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label8;
        private Label label4;
        private PictureBox pictureBox1;
        private Button BotonGuardarModiU;
        private Label label6;
        public TextBox txtDistancia;
        private Label label5;
        public TextBox txtNombreM;
        private Label label3;
        private Label label2;
        private Label label1;
        public TextBox txtTiempo;
        public TextBox txtPeso;
        public ComboBox CBtipoEjer;
    }
}