namespace Proyecto_MuscleMap.Formularios
{
    partial class FormularioNuevaMarca
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
            BotonRegisMarca = new Button();
            label6 = new Label();
            label5 = new Label();
            txtPeso = new TextBox();
            txtKilometros = new TextBox();
            txtMarca = new TextBox();
            dateFecha = new DateTimePicker();
            comboEjercicio = new ComboBox();
            txtTiempo = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Moccasin;
            panel1.Controls.Add(BotonRegisMarca);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txtPeso);
            panel1.Controls.Add(txtKilometros);
            panel1.Controls.Add(txtMarca);
            panel1.Controls.Add(dateFecha);
            panel1.Controls.Add(comboEjercicio);
            panel1.Controls.Add(txtTiempo);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(668, 435);
            panel1.TabIndex = 0;
            // 
            // BotonRegisMarca
            // 
            BotonRegisMarca.Location = new Point(413, 275);
            BotonRegisMarca.Name = "BotonRegisMarca";
            BotonRegisMarca.Size = new Size(191, 41);
            BotonRegisMarca.TabIndex = 15;
            BotonRegisMarca.Text = "Registrar Marca";
            BotonRegisMarca.UseVisualStyleBackColor = true;
            BotonRegisMarca.Click += BotonGuardar_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(387, 113);
            label6.Name = "label6";
            label6.Size = new Size(38, 15);
            label6.TabIndex = 14;
            label6.Text = "Fecha";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(387, 37);
            label5.Name = "label5";
            label5.Size = new Size(106, 15);
            label5.TabIndex = 13;
            label5.Text = "Tiempo (Opcional)";
            // 
            // txtPeso
            // 
            txtPeso.Location = new Point(35, 194);
            txtPeso.Name = "txtPeso";
            txtPeso.Size = new Size(234, 23);
            txtPeso.TabIndex = 12;
            // 
            // txtKilometros
            // 
            txtKilometros.Location = new Point(35, 254);
            txtKilometros.Name = "txtKilometros";
            txtKilometros.Size = new Size(234, 23);
            txtKilometros.TabIndex = 11;
            // 
            // txtMarca
            // 
            txtMarca.Location = new Point(35, 55);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(234, 23);
            txtMarca.TabIndex = 10;
            // 
            // dateFecha
            // 
            dateFecha.Location = new Point(387, 128);
            dateFecha.Name = "dateFecha";
            dateFecha.Size = new Size(234, 23);
            dateFecha.TabIndex = 9;
            // 
            // comboEjercicio
            // 
            comboEjercicio.FormattingEnabled = true;
            comboEjercicio.Location = new Point(35, 131);
            comboEjercicio.Name = "comboEjercicio";
            comboEjercicio.Size = new Size(234, 23);
            comboEjercicio.TabIndex = 8;
            // 
            // txtTiempo
            // 
            txtTiempo.Location = new Point(387, 55);
            txtTiempo.Name = "txtTiempo";
            txtTiempo.Size = new Size(234, 23);
            txtTiempo.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(35, 113);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 6;
            label4.Text = "Ejercicio";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 176);
            label3.Name = "label3";
            label3.Size = new Size(91, 15);
            label3.TabIndex = 4;
            label3.Text = "Peso (Opcional)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 236);
            label2.Name = "label2";
            label2.Size = new Size(123, 15);
            label2.TabIndex = 2;
            label2.Text = "Kilometros (Opcional)";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 37);
            label1.Name = "label1";
            label1.Size = new Size(117, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre de tu marca";
            // 
            // FormularioNuevaMarca
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(668, 435);
            Controls.Add(panel1);
            Name = "FormularioNuevaMarca";
            Text = "FormularioNuevaMarca";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DateTimePicker dateFecha;
        private ComboBox comboEjercicio;
        private TextBox txtTiempo;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtPeso;
        private TextBox txtKilometros;
        private TextBox txtMarca;
        private Button BotonRegisMarca;
        private Label label6;
        private Label label5;
    }
}