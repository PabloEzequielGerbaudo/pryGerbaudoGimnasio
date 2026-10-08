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
            cmbPlanes = new ComboBox();
            cmbTurno = new ComboBox();
            txtEdad = new TextBox();
            txtNom = new TextBox();
            txtMeses = new TextBox();
            chkCasillero = new CheckBox();
            chkEstudiante = new CheckBox();
            cmbPago = new ComboBox();
            rbEfectivo = new RadioButton();
            rbTarjeta = new RadioButton();
            grpPago = new GroupBox();
            btnCalcular = new Button();
            btnLimpiar = new Button();
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
            lblPago.TabIndex = 8;
            lblPago.Text = "Formas de pago:";
            // 
            // cmbPlanes
            // 
            cmbPlanes.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPlanes.Enabled = false;
            cmbPlanes.FormattingEnabled = true;
            cmbPlanes.Location = new Point(100, 122);
            cmbPlanes.Name = "cmbPlanes";
            cmbPlanes.Size = new Size(116, 23);
            cmbPlanes.TabIndex = 4;
            cmbPlanes.SelectedIndexChanged += cmbPlanes_SelectedIndexChanged;
            cmbPlanes.Click += cmbPlanes_Click;
            // 
            // cmbTurno
            // 
            cmbTurno.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTurno.Enabled = false;
            cmbTurno.FormattingEnabled = true;
            cmbTurno.Location = new Point(99, 153);
            cmbTurno.Name = "cmbTurno";
            cmbTurno.Size = new Size(116, 23);
            cmbTurno.TabIndex = 5;
            cmbTurno.SelectedIndexChanged += cmbTurno_SelectedIndexChanged;
            // 
            // txtEdad
            // 
            txtEdad.Enabled = false;
            txtEdad.Location = new Point(83, 93);
            txtEdad.MaxLength = 3;
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(37, 23);
            txtEdad.TabIndex = 2;
            txtEdad.Click += txtEdad_Click_1;
            txtEdad.TextChanged += txtEdad_TextChanged;
            txtEdad.KeyPress += txtEdad_KeyPress;
            // 
            // txtNom
            // 
            txtNom.CharacterCasing = CharacterCasing.Upper;
            txtNom.Location = new Point(119, 64);
            txtNom.MaxLength = 30;
            txtNom.Name = "txtNom";
            txtNom.Size = new Size(97, 23);
            txtNom.TabIndex = 1;
            txtNom.TextChanged += txtNom_TextChanged;
            txtNom.KeyPress += txtNom_KeyPress;
            // 
            // txtMeses
            // 
            txtMeses.Enabled = false;
            txtMeses.Location = new Point(99, 180);
            txtMeses.MaxLength = 2;
            txtMeses.Name = "txtMeses";
            txtMeses.Size = new Size(37, 23);
            txtMeses.TabIndex = 6;
            txtMeses.TextChanged += txtMeses_TextChanged;
            // 
            // chkCasillero
            // 
            chkCasillero.AutoSize = true;
            chkCasillero.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chkCasillero.Location = new Point(38, 209);
            chkCasillero.Name = "chkCasillero";
            chkCasillero.Size = new Size(91, 25);
            chkCasillero.TabIndex = 7;
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
            chkEstudiante.TabIndex = 3;
            chkEstudiante.Text = "Estudiante";
            chkEstudiante.UseVisualStyleBackColor = true;
            // 
            // cmbPago
            // 
            cmbPago.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPago.Enabled = false;
            cmbPago.FormattingEnabled = true;
            cmbPago.Location = new Point(112, 64);
            cmbPago.Name = "cmbPago";
            cmbPago.Size = new Size(116, 23);
            cmbPago.TabIndex = 2;
            cmbPago.SelectedIndexChanged += cmbPago_SelectedIndexChanged;
            // 
            // rbEfectivo
            // 
            rbEfectivo.AutoSize = true;
            rbEfectivo.Checked = true;
            rbEfectivo.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            rbEfectivo.Location = new Point(10, 22);
            rbEfectivo.Name = "rbEfectivo";
            rbEfectivo.Size = new Size(87, 25);
            rbEfectivo.TabIndex = 0;
            rbEfectivo.TabStop = true;
            rbEfectivo.Text = "Efectivo";
            rbEfectivo.UseVisualStyleBackColor = true;
            rbEfectivo.CheckedChanged += rbEfectivo_CheckedChanged;
            // 
            // rbTarjeta
            // 
            rbTarjeta.AutoSize = true;
            rbTarjeta.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            rbTarjeta.Location = new Point(112, 22);
            rbTarjeta.Name = "rbTarjeta";
            rbTarjeta.Size = new Size(76, 25);
            rbTarjeta.TabIndex = 1;
            rbTarjeta.Text = "Tarjeta";
            rbTarjeta.UseVisualStyleBackColor = true;
            rbTarjeta.CheckedChanged += rbTarjeta_CheckedChanged;
            // 
            // grpPago
            // 
            grpPago.Controls.Add(rbEfectivo);
            grpPago.Controls.Add(rbTarjeta);
            grpPago.Controls.Add(cmbPago);
            grpPago.Location = new Point(177, 219);
            grpPago.Name = "grpPago";
            grpPago.Size = new Size(241, 116);
            grpPago.TabIndex = 9;
            grpPago.TabStop = false;
            // 
            // btnCalcular
            // 
            btnCalcular.Enabled = false;
            btnCalcular.Location = new Point(346, 376);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(148, 43);
            btnCalcular.TabIndex = 10;
            btnCalcular.Text = "&Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Enabled = false;
            btnLimpiar.Location = new Point(1, 376);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(148, 43);
            btnLimpiar.TabIndex = 11;
            btnLimpiar.Text = "&Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // frmInscripción
            // 
            AcceptButton = btnCalcular;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(518, 453);
            Controls.Add(btnLimpiar);
            Controls.Add(btnCalcular);
            Controls.Add(grpPago);
            Controls.Add(chkEstudiante);
            Controls.Add(chkCasillero);
            Controls.Add(txtMeses);
            Controls.Add(txtNom);
            Controls.Add(txtEdad);
            Controls.Add(cmbTurno);
            Controls.Add(cmbPlanes);
            Controls.Add(lblPago);
            Controls.Add(lblMeses);
            Controls.Add(lblTurno);
            Controls.Add(lblPlanes);
            Controls.Add(lblEdad);
            Controls.Add(lblNombre);
            Controls.Add(lblTitulo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmInscripción";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gimnasio Siglo-Inscripción";
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
        private ComboBox cmbPlanes;
        private ComboBox cmbTurno;
        private TextBox txtEdad;
        private TextBox txtNom;
        private TextBox txtMeses;
        private CheckBox chkCasillero;
        private CheckBox chkEstudiante;
        private ComboBox cmbPago;
        private RadioButton rbEfectivo;
        private RadioButton rbTarjeta;
        private GroupBox grpPago;
        private Button btnCalcular;
        private Button btnLimpiar;
    }
}