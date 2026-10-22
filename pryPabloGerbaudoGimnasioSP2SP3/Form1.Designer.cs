namespace pryPabloGerbaudoGimnasioSP2SP3;

partial class Form1
{
    private System.ComponentModel.IContainer components = null;
    private GroupBox grpDatos;
    private GroupBox grpPago;
    private Label lblTitulo, lblNombre, lblEdad, lblPlan, lblTurno, lblMeses, lblCuotas;
    private TextBox txtNombre, txtEdad, txtMeses;
    private CheckBox chkEstudiante, chkCasillero;
    private ComboBox cboPlan, cboTurno, cboCuotas;
    private RadioButton rbtEfectivo, rbtTarjeta;
    private Button btnCalcular, btnLimpiar;

    protected override void Dispose(bool disposing)
    {
        if (disposing && components != null) components.Dispose();
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        components = new System.ComponentModel.Container();
        grpDatos = new GroupBox(); grpPago = new GroupBox();
        lblTitulo = new Label(); lblNombre = new Label(); lblEdad = new Label();
        lblPlan = new Label(); lblTurno = new Label(); lblMeses = new Label(); lblCuotas = new Label();
        txtNombre = new TextBox(); txtEdad = new TextBox(); txtMeses = new TextBox();
        chkEstudiante = new CheckBox(); chkCasillero = new CheckBox();
        cboPlan = new ComboBox(); cboTurno = new ComboBox(); cboCuotas = new ComboBox();
        rbtEfectivo = new RadioButton(); rbtTarjeta = new RadioButton();
        btnCalcular = new Button(); btnLimpiar = new Button();
        grpDatos.SuspendLayout(); grpPago.SuspendLayout(); SuspendLayout();

        lblTitulo.AutoSize = true; lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
        lblTitulo.Location = new Point(24, 18); lblTitulo.Text = "Gimnasio Siglo - Inscripción";
        ConfigurarEtiqueta(lblNombre, "Nombre:", 30, 75); ConfigurarEtiqueta(lblEdad, "Edad:", 30, 115);
        ConfigurarEtiqueta(lblPlan, "Plan:", 30, 155); ConfigurarEtiqueta(lblTurno, "Turno:", 30, 195);
        ConfigurarEtiqueta(lblMeses, "Meses:", 30, 235);
        ConfigurarTexto(txtNombre, 130, 72, 230); txtNombre.MaxLength = 30;
        ConfigurarTexto(txtEdad, 130, 112, 70); txtEdad.MaxLength = 3;
        ConfigurarTexto(txtMeses, 130, 232, 70); txtMeses.MaxLength = 2;
        ConfigurarCombo(cboPlan, 130, 152, new[] { "Musculación", "Funcional", "Natación" });
        ConfigurarCombo(cboTurno, 130, 192, new[] { "Mañana", "Tarde", "Noche" });
        chkEstudiante.AutoSize = true; chkEstudiante.Location = new Point(250, 112); chkEstudiante.Text = "Estudiante";
        chkCasillero.AutoSize = true; chkCasillero.Location = new Point(250, 232); chkCasillero.Text = "Casillero ($ 3.000/mes)";

        grpDatos.Text = "Datos personales y plan"; grpDatos.Location = new Point(20, 58); grpDatos.Size = new Size(390, 290);
        grpDatos.Controls.AddRange(new Control[] { lblNombre, lblEdad, lblPlan, lblTurno, lblMeses, txtNombre, txtEdad, txtMeses, cboPlan, cboTurno, chkEstudiante, chkCasillero });
        grpPago.Text = "Forma de pago"; grpPago.Location = new Point(430, 58); grpPago.Size = new Size(300, 180);
        rbtEfectivo.AutoSize = true; rbtEfectivo.Location = new Point(25, 38); rbtEfectivo.Text = "Efectivo";
        rbtTarjeta.AutoSize = true; rbtTarjeta.Location = new Point(25, 72); rbtTarjeta.Text = "Tarjeta";
        ConfigurarEtiqueta(lblCuotas, "Cuotas:", 25, 112); ConfigurarCombo(cboCuotas, 95, 109, new[] { "1", "3", "6" });
        grpPago.Controls.AddRange(new Control[] { rbtEfectivo, rbtTarjeta, lblCuotas, cboCuotas });
        btnCalcular.Location = new Point(430, 270); btnCalcular.Size = new Size(125, 42); btnCalcular.Text = "&Calcular"; btnCalcular.Enabled = false;
        btnLimpiar.Location = new Point(575, 270); btnLimpiar.Size = new Size(125, 42); btnLimpiar.Text = "&Limpiar";

        AutoScaleMode = AutoScaleMode.Font; ClientSize = new Size(760, 370); Controls.AddRange(new Control[] { lblTitulo, grpDatos, grpPago, btnCalcular, btnLimpiar });
        AcceptButton = btnCalcular; FormBorderStyle = FormBorderStyle.FixedSingle; MaximizeBox = false;
        StartPosition = FormStartPosition.CenterScreen; Text = "Gimnasio Siglo - Inscripción";
        Load += Form1_Load; btnLimpiar.Click += btnLimpiar_Click; btnCalcular.Click += btnCalcular_Click;
        txtNombre.KeyPress += txtNombre_KeyPress; txtEdad.KeyPress += SoloDigitos_KeyPress; txtMeses.KeyPress += SoloDigitos_KeyPress;
        txtNombre.TextChanged += Campos_TextChanged; txtEdad.TextChanged += Campos_TextChanged; txtMeses.TextChanged += Campos_TextChanged;
        rbtTarjeta.CheckedChanged += rbtTarjeta_CheckedChanged;
        grpDatos.ResumeLayout(false); grpDatos.PerformLayout(); grpPago.ResumeLayout(false); grpPago.PerformLayout(); ResumeLayout(false); PerformLayout();
    }

    private static void ConfigurarEtiqueta(Label label, string text, int x, int y) { label.AutoSize = true; label.Location = new Point(x, y); label.Text = text; }
    private static void ConfigurarTexto(TextBox textBox, int x, int y, int width) { textBox.Location = new Point(x, y); textBox.Size = new Size(width, 23); }
    private static void ConfigurarCombo(ComboBox combo, int x, int y, string[] items) { combo.DropDownStyle = ComboBoxStyle.DropDownList; combo.Items.AddRange(items); combo.Location = new Point(x, y); combo.Size = new Size(150, 23); }
}
