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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInscripción));
            btnLimpiar = new Button();
            btnCalcular = new Button();
            grpPago = new GroupBox();
            rbEfectivo = new RadioButton();
            rbTarjeta = new RadioButton();
            cmbPago = new ComboBox();
            lblPago = new Label();
            chkEstudiante = new CheckBox();
            chkCasillero = new CheckBox();
            txtMeses = new TextBox();
            txtNom = new TextBox();
            cmbTurno = new ComboBox();
            cmbPlanes = new ComboBox();
            lblMeses = new Label();
            lblTurno = new Label();
            lblPlanes = new Label();
            lblEdad = new Label();
            lblNombre = new Label();
            lblTitulo = new Label();
            lstSocios = new ListBox();
            btnConsultar = new Button();
            txtEdad = new TextBox();
            grpPago.SuspendLayout();
            SuspendLayout();
            // 
            // btnLimpiar
            // 
            btnLimpiar.Enabled = false;
            btnLimpiar.Location = new Point(6, 309);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(122, 43);
            btnLimpiar.TabIndex = 14;
            btnLimpiar.Text = "&Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnCalcular
            // 
            btnCalcular.Enabled = false;
            btnCalcular.Location = new Point(163, 309);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(128, 43);
            btnCalcular.TabIndex = 15;
            btnCalcular.Text = "&Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // grpPago
            // 
            grpPago.Controls.Add(rbEfectivo);
            grpPago.Controls.Add(rbTarjeta);
            grpPago.Controls.Add(cmbPago);
            grpPago.Controls.Add(lblPago);
            grpPago.Location = new Point(50, 190);
            grpPago.Name = "grpPago";
            grpPago.Size = new Size(241, 113);
            grpPago.TabIndex = 13;
            grpPago.TabStop = false;
            grpPago.Enter += grpPago_Enter;
            // 
            // rbEfectivo
            // 
            rbEfectivo.AutoSize = true;
            rbEfectivo.Checked = true;
            rbEfectivo.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            rbEfectivo.Location = new Point(12, 51);
            rbEfectivo.Name = "rbEfectivo";
            rbEfectivo.Size = new Size(87, 25);
            rbEfectivo.TabIndex = 1;
            rbEfectivo.TabStop = true;
            rbEfectivo.Text = "Efectivo";
            rbEfectivo.UseVisualStyleBackColor = true;
            // 
            // rbTarjeta
            // 
            rbTarjeta.AutoSize = true;
            rbTarjeta.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            rbTarjeta.Location = new Point(112, 51);
            rbTarjeta.Name = "rbTarjeta";
            rbTarjeta.Size = new Size(76, 25);
            rbTarjeta.TabIndex = 2;
            rbTarjeta.Text = "Tarjeta";
            rbTarjeta.UseVisualStyleBackColor = true;
            rbTarjeta.CheckedChanged += rbTarjeta_CheckedChanged;
            // 
            // cmbPago
            // 
            cmbPago.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPago.Enabled = false;
            cmbPago.FormattingEnabled = true;
            cmbPago.Location = new Point(112, 83);
            cmbPago.Name = "cmbPago";
            cmbPago.Size = new Size(116, 23);
            cmbPago.TabIndex = 3;
            cmbPago.SelectedIndexChanged += cmbPago_SelectedIndexChanged;
            // 
            // lblPago
            // 
            lblPago.AutoSize = true;
            lblPago.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblPago.Location = new Point(0, 19);
            lblPago.Name = "lblPago";
            lblPago.Size = new Size(132, 21);
            lblPago.TabIndex = 0;
            lblPago.Text = "Formas de pago:";
            // 
            // chkEstudiante
            // 
            chkEstudiante.AutoSize = true;
            chkEstudiante.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chkEstudiante.Location = new Point(177, 76);
            chkEstudiante.Name = "chkEstudiante";
            chkEstudiante.Size = new Size(105, 25);
            chkEstudiante.TabIndex = 5;
            chkEstudiante.Text = "Estudiante";
            chkEstudiante.UseVisualStyleBackColor = true;
            chkEstudiante.Leave += chkEstudiante_Leave;
            // 
            // chkCasillero
            // 
            chkCasillero.AutoSize = true;
            chkCasillero.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chkCasillero.Location = new Point(178, 167);
            chkCasillero.Name = "chkCasillero";
            chkCasillero.Size = new Size(91, 25);
            chkCasillero.TabIndex = 12;
            chkCasillero.Text = "Casillero";
            chkCasillero.UseVisualStyleBackColor = true;
            // 
            // txtMeses
            // 
            txtMeses.Enabled = false;
            txtMeses.Location = new Point(133, 165);
            txtMeses.MaxLength = 2;
            txtMeses.Name = "txtMeses";
            txtMeses.Size = new Size(37, 23);
            txtMeses.TabIndex = 11;
            txtMeses.TextChanged += txtMeses_TextChanged;
            txtMeses.KeyPress += txtMeses_KeyPress;
            // 
            // txtNom
            // 
            txtNom.CharacterCasing = CharacterCasing.Upper;
            txtNom.Location = new Point(134, 47);
            txtNom.MaxLength = 30;
            txtNom.Name = "txtNom";
            txtNom.Size = new Size(97, 23);
            txtNom.TabIndex = 2;
            txtNom.TextChanged += txtNom_TextChanged_1;
            txtNom.KeyPress += txtNom_KeyPress_1;
            // 
            // cmbTurno
            // 
            cmbTurno.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTurno.Enabled = false;
            cmbTurno.FormattingEnabled = true;
            cmbTurno.Location = new Point(133, 138);
            cmbTurno.Name = "cmbTurno";
            cmbTurno.Size = new Size(116, 23);
            cmbTurno.TabIndex = 9;
            cmbTurno.SelectedIndexChanged += cmbTurno_SelectedIndexChanged;
            // 
            // cmbPlanes
            // 
            cmbPlanes.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPlanes.Enabled = false;
            cmbPlanes.FormattingEnabled = true;
            cmbPlanes.Location = new Point(134, 107);
            cmbPlanes.Name = "cmbPlanes";
            cmbPlanes.Size = new Size(116, 23);
            cmbPlanes.TabIndex = 7;
            cmbPlanes.SelectedIndexChanged += cmbPlanes_SelectedIndexChanged;
            // 
            // lblMeses
            // 
            lblMeses.AutoSize = true;
            lblMeses.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblMeses.Location = new Point(52, 163);
            lblMeses.Name = "lblMeses";
            lblMeses.Size = new Size(61, 21);
            lblMeses.TabIndex = 10;
            lblMeses.Text = "Meses:";
            // 
            // lblTurno
            // 
            lblTurno.AutoSize = true;
            lblTurno.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblTurno.Location = new Point(52, 134);
            lblTurno.Name = "lblTurno";
            lblTurno.Size = new Size(56, 21);
            lblTurno.TabIndex = 8;
            lblTurno.Text = "Turno:";
            // 
            // lblPlanes
            // 
            lblPlanes.AutoSize = true;
            lblPlanes.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblPlanes.Location = new Point(53, 105);
            lblPlanes.Name = "lblPlanes";
            lblPlanes.Size = new Size(60, 21);
            lblPlanes.TabIndex = 6;
            lblPlanes.Text = "Planes:";
            // 
            // lblEdad
            // 
            lblEdad.AutoSize = true;
            lblEdad.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblEdad.Location = new Point(53, 76);
            lblEdad.Name = "lblEdad";
            lblEdad.Size = new Size(50, 21);
            lblEdad.TabIndex = 3;
            lblEdad.Text = "Edad:";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblNombre.Location = new Point(53, 47);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(75, 21);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre:";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(83, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(155, 37);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Inscripción";
            // 
            // lstSocios
            // 
            lstSocios.FormattingEnabled = true;
            lstSocios.Location = new Point(-2, 358);
            lstSocios.Name = "lstSocios";
            lstSocios.Size = new Size(322, 94);
            lstSocios.TabIndex = 16;
            lstSocios.SelectedIndexChanged += lstSocios_SelectedIndexChanged;
            // 
            // btnConsultar
            // 
            btnConsultar.Enabled = false;
            btnConsultar.Location = new Point(94, 458);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(115, 44);
            btnConsultar.TabIndex = 17;
            btnConsultar.Text = "&Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // txtEdad
            // 
            txtEdad.CharacterCasing = CharacterCasing.Upper;
            txtEdad.Enabled = false;
            txtEdad.Location = new Point(133, 78);
            txtEdad.MaxLength = 30;
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(37, 23);
            txtEdad.TabIndex = 4;
            txtEdad.TextChanged += txtEdad_TextChanged_1;
            txtEdad.KeyPress += txtEdad_KeyPress;
            txtEdad.Leave += txtEdad_Leave;
            // 
            // frmInscripción
            // 
            AcceptButton = btnCalcular;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(318, 509);
            Controls.Add(txtEdad);
            Controls.Add(btnConsultar);
            Controls.Add(lstSocios);
            Controls.Add(btnLimpiar);
            Controls.Add(btnCalcular);
            Controls.Add(grpPago);
            Controls.Add(chkEstudiante);
            Controls.Add(chkCasillero);
            Controls.Add(txtMeses);
            Controls.Add(txtNom);
            Controls.Add(cmbTurno);
            Controls.Add(cmbPlanes);
            Controls.Add(lblMeses);
            Controls.Add(lblTurno);
            Controls.Add(lblPlanes);
            Controls.Add(lblEdad);
            Controls.Add(lblNombre);
            Controls.Add(lblTitulo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmInscripción";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gimnasio Siglo-Inscripción";
            Load += frmInscripción_Load_1;
            grpPago.ResumeLayout(false);
            grpPago.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLimpiar;
        private Button btnCalcular;
        private GroupBox grpPago;
        private RadioButton rbEfectivo;
        private RadioButton rbTarjeta;
        private ComboBox cmbPago;
        private Label lblPago;
        private CheckBox chkEstudiante;
        private CheckBox chkCasillero;
        private TextBox txtMeses;
        private TextBox txtNom;
        private ComboBox cmbTurno;
        private ComboBox cmbPlanes;
        private Label lblMeses;
        private Label lblTurno;
        private Label lblPlanes;
        private Label lblEdad;
        private Label lblNombre;
        private Label lblTitulo;
        private ListBox lstSocios;
        private Button btnConsultar;
        private TextBox txtEdad;
    }
}