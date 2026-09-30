namespace pryPabloGerbaudoActGym
{
    partial class frmInscripción
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
            lblTitulo = new Label();
            lblNombre = new Label();
            lblEdad = new Label();
            lblPlanes = new Label();
            lblTurno = new Label();
            lblMeses = new Label();
            lblPago = new Label();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            comboBox3 = new ComboBox();
            textBox1 = new TextBox();
            rbEfectivo = new RadioButton();
            rbTarjeta = new RadioButton();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            chkCasillero = new CheckBox();
            chkEstudiante = new CheckBox();
            grpPago = new GroupBox();
            grpPago.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(169, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(155, 37);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Inscripción";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblNombre.Location = new Point(38, 64);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(75, 21);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre:";
            // 
            // lblEdad
            // 
            lblEdad.AutoSize = true;
            lblEdad.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblEdad.Location = new Point(38, 93);
            lblEdad.Name = "lblEdad";
            lblEdad.Size = new Size(50, 21);
            lblEdad.TabIndex = 2;
            lblEdad.Text = "Edad:";
            // 
            // lblPlanes
            // 
            lblPlanes.AutoSize = true;
            lblPlanes.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblPlanes.Location = new Point(38, 122);
            lblPlanes.Name = "lblPlanes";
            lblPlanes.Size = new Size(60, 21);
            lblPlanes.TabIndex = 3;
            lblPlanes.Text = "Planes:";
            // 
            // lblTurno
            // 
            lblTurno.AutoSize = true;
            lblTurno.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblTurno.Location = new Point(37, 151);
            lblTurno.Name = "lblTurno";
            lblTurno.Size = new Size(56, 21);
            lblTurno.TabIndex = 4;
            lblTurno.Text = "Turno:";
            // 
            // lblMeses
            // 
            lblMeses.AutoSize = true;
            lblMeses.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblMeses.Location = new Point(37, 180);
            lblMeses.Name = "lblMeses";
            lblMeses.Size = new Size(61, 21);
            lblMeses.TabIndex = 5;
            lblMeses.Text = "Meses:";
            // 
            // lblPago
            // 
            lblPago.AutoSize = true;
            lblPago.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblPago.Location = new Point(38, 238);
            lblPago.Name = "lblPago";
            lblPago.Size = new Size(132, 21);
            lblPago.TabIndex = 7;
            lblPago.Text = "Formas de pago:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(100, 122);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(116, 23);
            comboBox1.TabIndex = 8;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(99, 153);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(116, 23);
            comboBox2.TabIndex = 9;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(102, 54);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(116, 23);
            comboBox3.TabIndex = 10;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(83, 93);
            textBox1.MaxLength = 3;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(37, 23);
            textBox1.TabIndex = 11;
            // 
            // rbEfectivo
            // 
            rbEfectivo.AutoSize = true;
            rbEfectivo.Location = new Point(2, 19);
            rbEfectivo.Name = "rbEfectivo";
            rbEfectivo.Size = new Size(67, 19);
            rbEfectivo.TabIndex = 12;
            rbEfectivo.TabStop = true;
            rbEfectivo.Text = "Efectivo";
            rbEfectivo.UseVisualStyleBackColor = true;
            // 
            // rbTarjeta
            // 
            rbTarjeta.AutoSize = true;
            rbTarjeta.Location = new Point(102, 19);
            rbTarjeta.Name = "rbTarjeta";
            rbTarjeta.Size = new Size(60, 19);
            rbTarjeta.TabIndex = 13;
            rbTarjeta.TabStop = true;
            rbTarjeta.Text = "Tarjeta";
            rbTarjeta.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(119, 64);
            textBox2.MaxLength = 32;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(97, 23);
            textBox2.TabIndex = 15;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(99, 180);
            textBox3.MaxLength = 2;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(37, 23);
            textBox3.TabIndex = 16;
            // 
            // chkCasillero
            // 
            chkCasillero.AutoSize = true;
            chkCasillero.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chkCasillero.Location = new Point(38, 209);
            chkCasillero.Name = "chkCasillero";
            chkCasillero.Size = new Size(91, 25);
            chkCasillero.TabIndex = 17;
            chkCasillero.Text = "Casillero";
            chkCasillero.UseVisualStyleBackColor = true;
            // 
            // chkEstudiante
            // 
            chkEstudiante.AutoSize = true;
            chkEstudiante.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chkEstudiante.Location = new Point(149, 90);
            chkEstudiante.Name = "chkEstudiante";
            chkEstudiante.Size = new Size(105, 25);
            chkEstudiante.TabIndex = 18;
            chkEstudiante.Text = "Estudiante";
            chkEstudiante.UseVisualStyleBackColor = true;
            // 
            // grpPago
            // 
            grpPago.Controls.Add(rbTarjeta);
            grpPago.Controls.Add(rbEfectivo);
            grpPago.Controls.Add(comboBox3);
            grpPago.Location = new Point(174, 222);
            grpPago.Name = "grpPago";
            grpPago.Size = new Size(229, 95);
            grpPago.TabIndex = 19;
            grpPago.TabStop = false;
            // 
            // frmInscripción
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(518, 584);
            Controls.Add(grpPago);
            Controls.Add(chkEstudiante);
            Controls.Add(chkCasillero);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(lblPago);
            Controls.Add(lblMeses);
            Controls.Add(lblTurno);
            Controls.Add(lblPlanes);
            Controls.Add(lblEdad);
            Controls.Add(lblNombre);
            Controls.Add(lblTitulo);
            Name = "frmInscripción";
            Text = "frmGimnasioSiglo";
            grpPago.ResumeLayout(false);
            grpPago.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblNombre;
        private Label lblEdad;
        private Label lblPlanes;
        private Label lblTurno;
        private Label lblMeses;
        private Label lblPago;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
        private TextBox textBox1;
        private RadioButton rbEfectivo;
        private RadioButton rbTarjeta;
        private TextBox textBox2;
        private TextBox textBox3;
        private CheckBox chkCasillero;
        private CheckBox chkEstudiante;
        private GroupBox grpPago;
    }
}