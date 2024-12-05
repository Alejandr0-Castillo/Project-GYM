namespace Proyecto_MuscleMap.Formularios
{
    partial class FormularioModificarAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioModificarAdmin));
            txtNombree = new TextBox();
            txtCorreoo = new TextBox();
            txtContras = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            txtIDD = new TextBox();
            label6 = new Label();
            txtRutt = new TextBox();
            BotonGuardarModiA = new Button();
            button2 = new Button();
            label7 = new Label();
            txtRol = new TextBox();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtNombree
            // 
            txtNombree.Location = new Point(28, 115);
            txtNombree.Name = "txtNombree";
            txtNombree.Size = new Size(225, 23);
            txtNombree.TabIndex = 0;
            // 
            // txtCorreoo
            // 
            txtCorreoo.Location = new Point(28, 162);
            txtCorreoo.Name = "txtCorreoo";
            txtCorreoo.Size = new Size(225, 23);
            txtCorreoo.TabIndex = 1;
            // 
            // txtContras
            // 
            txtContras.Location = new Point(28, 269);
            txtContras.Name = "txtContras";
            txtContras.Size = new Size(225, 23);
            txtContras.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 97);
            label1.Name = "label1";
            label1.Size = new Size(107, 15);
            label1.TabIndex = 4;
            label1.Text = "Nombre Completo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 144);
            label2.Name = "label2";
            label2.Size = new Size(105, 15);
            label2.TabIndex = 5;
            label2.Text = "Correo Electronico";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 251);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 6;
            label3.Text = "Contraseña";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(28, 44);
            label5.Name = "label5";
            label5.Size = new Size(18, 15);
            label5.TabIndex = 10;
            label5.Text = "ID";
            // 
            // txtIDD
            // 
            txtIDD.Location = new Point(28, 62);
            txtIDD.Name = "txtIDD";
            txtIDD.Size = new Size(225, 23);
            txtIDD.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(28, 197);
            label6.Name = "label6";
            label6.Size = new Size(28, 15);
            label6.TabIndex = 12;
            label6.Text = "RUT";
            // 
            // txtRutt
            // 
            txtRutt.Location = new Point(28, 215);
            txtRutt.Name = "txtRutt";
            txtRutt.Size = new Size(225, 23);
            txtRutt.TabIndex = 11;
            // 
            // BotonGuardarModiA
            // 
            BotonGuardarModiA.Location = new Point(336, 132);
            BotonGuardarModiA.Name = "BotonGuardarModiA";
            BotonGuardarModiA.Size = new Size(115, 38);
            BotonGuardarModiA.TabIndex = 13;
            BotonGuardarModiA.Text = "Guardar";
            BotonGuardarModiA.UseVisualStyleBackColor = true;
            BotonGuardarModiA.Click += BotonGuardarModiA_Click;
            // 
            // button2
            // 
            button2.Location = new Point(336, 200);
            button2.Name = "button2";
            button2.Size = new Size(115, 38);
            button2.TabIndex = 14;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(28, 307);
            label7.Name = "label7";
            label7.Size = new Size(24, 15);
            label7.TabIndex = 16;
            label7.Text = "Rol";
            // 
            // txtRol
            // 
            txtRol.Location = new Point(28, 325);
            txtRol.Name = "txtRol";
            txtRol.Size = new Size(225, 23);
            txtRol.TabIndex = 15;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(368, 398);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 85);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(182, 443);
            label4.Name = "label4";
            label4.Size = new Size(73, 28);
            label4.TabIndex = 18;
            label4.Text = "Muscle";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 15F);
            label8.ForeColor = Color.Orange;
            label8.Location = new Point(249, 443);
            label8.Name = "label8";
            label8.Size = new Size(113, 28);
            label8.TabIndex = 19;
            label8.Text = "Modifitions";
            // 
            // FormularioModificarAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Moccasin;
            ClientSize = new Size(492, 495);
            Controls.Add(label8);
            Controls.Add(label4);
            Controls.Add(pictureBox1);
            Controls.Add(label7);
            Controls.Add(txtRol);
            Controls.Add(button2);
            Controls.Add(BotonGuardarModiA);
            Controls.Add(label6);
            Controls.Add(txtRutt);
            Controls.Add(label5);
            Controls.Add(txtIDD);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtContras);
            Controls.Add(txtCorreoo);
            Controls.Add(txtNombree);
            Name = "FormularioModificarAdmin";
            Text = "FormularioModificarAdmin";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label5;
        private TextBox textBox4;
        private Label label6;
        public TextBox txtNombree;
        public TextBox txtCorreoo;
        public TextBox txtContras;
        public TextBox txtIDD;
        public TextBox txtRutt;
        private Button BotonGuardarModiA;
        private Button button2;
        private Label label7;
        public TextBox txtRol;
        private PictureBox pictureBox1;
        private Label label4;
        private Label label8;
    }
}