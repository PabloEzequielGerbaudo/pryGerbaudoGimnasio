namespace pryLantieriSP4
{
    partial class frmMilanga
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            dgvVentas = new DataGridView();
            btnValidar = new Button();
            btnMozoDia = new Button();
            lblMozo = new Label();
            txtMozo = new TextBox();
            lblImporteMozo = new Label();
            txtImporteMozo = new TextBox();
            btnTotales = new Button();
            lblTotalGeneral = new Label();
            txtTotalGeneral = new TextBox();
            lblComidas = new Label();
            txtComidas = new TextBox();
            lblSinAlcohol = new Label();
            txtSinAlcohol = new TextBox();
            lblConAlcohol = new Label();
            txtConAlcohol = new TextBox();
            lblPostres = new Label();
            txtPostres = new TextBox();
            btnCerrar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvVentas).BeginInit();
            SuspendLayout();
            //
            // dgvVentas
            //
            dgvVentas.Location = new Point(12, 12);
            dgvVentas.Name = "dgvVentas";
            dgvVentas.Size = new Size(756, 190);
            dgvVentas.TabIndex = 0;
            //
            // btnValidar
            //
            btnValidar.Location = new Point(12, 214);
            btnValidar.Name = "btnValidar";
            btnValidar.Size = new Size(150, 36);
            btnValidar.TabIndex = 1;
            btnValidar.Text = "Validar Datos";
            btnValidar.UseVisualStyleBackColor = true;
            btnValidar.Click += btnValidar_Click;
            //
            // btnMozoDia
            //
            btnMozoDia.Location = new Point(12, 275);
            btnMozoDia.Name = "btnMozoDia";
            btnMozoDia.Size = new Size(150, 36);
            btnMozoDia.TabIndex = 2;
            btnMozoDia.Text = "Mozo del día";
            btnMozoDia.UseVisualStyleBackColor = true;
            btnMozoDia.Click += btnMozoDia_Click;
            //
            // lblMozo
            //
            lblMozo.AutoSize = true;
            lblMozo.Location = new Point(180, 285);
            lblMozo.Name = "lblMozo";
            lblMozo.Size = new Size(41, 15);
            lblMozo.TabIndex = 3;
            lblMozo.Text = "Mozo:";
            //
            // txtMozo
            //
            txtMozo.Location = new Point(230, 282);
            txtMozo.Name = "txtMozo";
            txtMozo.ReadOnly = true;
            txtMozo.Size = new Size(160, 23);
            txtMozo.TabStop = false;
            //
            // lblImporteMozo
            //
            lblImporteMozo.AutoSize = true;
            lblImporteMozo.Location = new Point(410, 285);
            lblImporteMozo.Name = "lblImporteMozo";
            lblImporteMozo.Size = new Size(54, 15);
            lblImporteMozo.TabIndex = 4;
            lblImporteMozo.Text = "Importe:";
            //
            // txtImporteMozo
            //
            txtImporteMozo.Location = new Point(470, 282);
            txtImporteMozo.Name = "txtImporteMozo";
            txtImporteMozo.ReadOnly = true;
            txtImporteMozo.Size = new Size(140, 23);
            txtImporteMozo.TabStop = false;
            txtImporteMozo.TextAlign = HorizontalAlignment.Right;
            //
            // btnTotales
            //
            btnTotales.Location = new Point(12, 350);
            btnTotales.Name = "btnTotales";
            btnTotales.Size = new Size(150, 36);
            btnTotales.TabIndex = 5;
            btnTotales.Text = "Totales";
            btnTotales.UseVisualStyleBackColor = true;
            btnTotales.Click += btnTotales_Click;
            //
            // lblTotalGeneral
            //
            lblTotalGeneral.AutoSize = true;
            lblTotalGeneral.Location = new Point(180, 327);
            lblTotalGeneral.Name = "lblTotalGeneral";
            lblTotalGeneral.Size = new Size(79, 15);
            lblTotalGeneral.Text = "Total general";
            //
            // txtTotalGeneral
            //
            txtTotalGeneral.Location = new Point(180, 355);
            txtTotalGeneral.Name = "txtTotalGeneral";
            txtTotalGeneral.ReadOnly = true;
            txtTotalGeneral.Size = new Size(110, 23);
            txtTotalGeneral.TabStop = false;
            txtTotalGeneral.TextAlign = HorizontalAlignment.Right;
            //
            // lblComidas
            //
            lblComidas.AutoSize = true;
            lblComidas.Location = new Point(298, 327);
            lblComidas.Name = "lblComidas";
            lblComidas.Size = new Size(55, 15);
            lblComidas.Text = "Comidas";
            //
            // txtComidas
            //
            txtComidas.Location = new Point(298, 355);
            txtComidas.Name = "txtComidas";
            txtComidas.ReadOnly = true;
            txtComidas.Size = new Size(110, 23);
            txtComidas.TabStop = false;
            txtComidas.TextAlign = HorizontalAlignment.Right;
            //
            // lblSinAlcohol
            //
            lblSinAlcohol.AutoSize = true;
            lblSinAlcohol.Location = new Point(416, 327);
            lblSinAlcohol.Name = "lblSinAlcohol";
            lblSinAlcohol.Size = new Size(97, 15);
            lblSinAlcohol.Text = "Beb. sin alcohol";
            //
            // txtSinAlcohol
            //
            txtSinAlcohol.Location = new Point(416, 355);
            txtSinAlcohol.Name = "txtSinAlcohol";
            txtSinAlcohol.ReadOnly = true;
            txtSinAlcohol.Size = new Size(110, 23);
            txtSinAlcohol.TabStop = false;
            txtSinAlcohol.TextAlign = HorizontalAlignment.Right;
            //
            // lblConAlcohol
            //
            lblConAlcohol.AutoSize = true;
            lblConAlcohol.Location = new Point(534, 327);
            lblConAlcohol.Name = "lblConAlcohol";
            lblConAlcohol.Size = new Size(99, 15);
            lblConAlcohol.Text = "Beb. con alcohol";
            //
            // txtConAlcohol
            //
            txtConAlcohol.Location = new Point(534, 355);
            txtConAlcohol.Name = "txtConAlcohol";
            txtConAlcohol.ReadOnly = true;
            txtConAlcohol.Size = new Size(110, 23);
            txtConAlcohol.TabStop = false;
            txtConAlcohol.TextAlign = HorizontalAlignment.Right;
            //
            // lblPostres
            //
            lblPostres.AutoSize = true;
            lblPostres.Location = new Point(652, 327);
            lblPostres.Name = "lblPostres";
            lblPostres.Size = new Size(46, 15);
            lblPostres.Text = "Postres";
            //
            // txtPostres
            //
            txtPostres.Location = new Point(652, 355);
            txtPostres.Name = "txtPostres";
            txtPostres.ReadOnly = true;
            txtPostres.Size = new Size(110, 23);
            txtPostres.TabStop = false;
            txtPostres.TextAlign = HorizontalAlignment.Right;
            //
            // btnCerrar
            //
            btnCerrar.Location = new Point(618, 418);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(150, 36);
            btnCerrar.TabIndex = 6;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            //
            // frmMilanga
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(780, 466);
            Controls.Add(dgvVentas);
            Controls.Add(btnValidar);
            Controls.Add(btnMozoDia);
            Controls.Add(lblMozo);
            Controls.Add(txtMozo);
            Controls.Add(lblImporteMozo);
            Controls.Add(txtImporteMozo);
            Controls.Add(btnTotales);
            Controls.Add(lblTotalGeneral);
            Controls.Add(txtTotalGeneral);
            Controls.Add(lblComidas);
            Controls.Add(txtComidas);
            Controls.Add(lblSinAlcohol);
            Controls.Add(txtSinAlcohol);
            Controls.Add(lblConAlcohol);
            Controls.Add(txtConAlcohol);
            Controls.Add(lblPostres);
            Controls.Add(txtPostres);
            Controls.Add(btnCerrar);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "frmMilanga";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bar La Milanga - Ventas diarias";
            ((System.ComponentModel.ISupportInitialize)dgvVentas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvVentas;
        private Button btnValidar;
        private Button btnMozoDia;
        private Label lblMozo;
        private TextBox txtMozo;
        private Label lblImporteMozo;
        private TextBox txtImporteMozo;
        private Button btnTotales;
        private Label lblTotalGeneral;
        private TextBox txtTotalGeneral;
        private Label lblComidas;
        private TextBox txtComidas;
        private Label lblSinAlcohol;
        private TextBox txtSinAlcohol;
        private Label lblConAlcohol;
        private TextBox txtConAlcohol;
        private Label lblPostres;
        private TextBox txtPostres;
        private Button btnCerrar;
    }
}