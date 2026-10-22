namespace pryPabloGerbaudoGimnasioSP2SP3;

public partial class Form1 : Form
{
    private const decimal PRECIO_MUSCULACION = 15000m, PRECIO_FUNCIONAL = 18000m, PRECIO_NATACION = 22000m;
    private const decimal PRECIO_CASILLERO = 3000m, DESCUENTO_MENOR = 0.25m, DESCUENTO_MAYOR = 0.30m;
    private const decimal DESCUENTO_ESTUDIANTE = 0.15m, DESCUENTO_EFECTIVO = 0.10m, RECARGO_TRES_CUOTAS = 0.10m, RECARGO_SEIS_CUOTAS = 0.20m;
    private const int EDAD_MINIMA = 14, MESES_MINIMOS = 1, MESES_MAXIMOS = 12;

    public struct SOCIO
    {
        public string Nombre, Categoria, Plan, Horario, FormaPago;
        public int Edad, Meses;
        public decimal Total, ValorCuota;
    }

    public Form1() => InitializeComponent();

    private void Form1_Load(object? sender, EventArgs e) => EstadoInicial();

    private void EstadoInicial()
    {
        txtNombre.Clear(); txtEdad.Clear(); txtMeses.Text = "1";
        chkEstudiante.Checked = false; chkCasillero.Checked = false;
        cboPlan.SelectedIndex = 0; cboTurno.SelectedIndex = 0;
        rbtEfectivo.Checked = true; cboCuotas.SelectedIndex = -1; cboCuotas.Enabled = false;
        btnCalcular.Enabled = false; txtNombre.Focus();
    }

    private void SoloDigitos_KeyPress(object? sender, KeyPressEventArgs e)
    {
        if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back) e.Handled = true;
    }

    private void txtNombre_KeyPress(object? sender, KeyPressEventArgs e)
    {
        if (char.IsLower(e.KeyChar)) e.KeyChar = char.ToUpper(e.KeyChar);
    }

    private void Campos_TextChanged(object? sender, EventArgs e)
    {
        if (txtNombre.Text.Trim() != "" && txtEdad.Text != "" && txtMeses.Text != "") btnCalcular.Enabled = true;
        else btnCalcular.Enabled = false;
    }

    private void rbtTarjeta_CheckedChanged(object? sender, EventArgs e)
    {
        if (rbtTarjeta.Checked) { cboCuotas.Enabled = true; cboCuotas.SelectedIndex = 0; }
        else { cboCuotas.Enabled = false; cboCuotas.SelectedIndex = -1; }
    }

    private void btnLimpiar_Click(object? sender, EventArgs e) => EstadoInicial();

    private void btnCalcular_Click(object? sender, EventArgs e)
    {
        int edad = int.Parse(txtEdad.Text), meses = int.Parse(txtMeses.Text);
        if (edad < EDAD_MINIMA) { MessageBox.Show($"La edad mínima es {EDAD_MINIMA} años.", "Edad mínima", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
        if (meses < MESES_MINIMOS || meses > MESES_MAXIMOS) { MessageBox.Show($"Los meses deben estar entre {MESES_MINIMOS} y {MESES_MAXIMOS}.", "Meses inválidos", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

        string plan = cboPlan.Text; decimal precioMensual;
        switch (plan) { case "Musculación": precioMensual = PRECIO_MUSCULACION; break; case "Funcional": precioMensual = PRECIO_FUNCIONAL; break; case "Natación": precioMensual = PRECIO_NATACION; break; default: MessageBox.Show("Plan inválido."); return; }
        string horario; switch (cboTurno.SelectedIndex) { case 0: horario = "7 a 12 h"; break; case 1: horario = "14 a 18 h"; break; case 2: horario = "18 a 23 h"; break; default: horario = "Sin turno"; break; }
        if (chkCasillero.Checked) precioMensual += PRECIO_CASILLERO;
        decimal subtotal = precioMensual * meses, descuento;
        if (edad < 18) descuento = DESCUENTO_MENOR;
        else if (edad >= 65) descuento = DESCUENTO_MAYOR;
        else if (chkEstudiante.Checked) descuento = DESCUENTO_ESTUDIANTE;
        else descuento = 0m;
        decimal importe = subtotal * (1m - descuento), ajuste; int cuotas = 1;
        if (rbtEfectivo.Checked) ajuste = -DESCUENTO_EFECTIVO;
        else { cuotas = int.Parse(cboCuotas.Text); if (cuotas == 1) ajuste = 0m; else if (cuotas == 3) ajuste = RECARGO_TRES_CUOTAS; else ajuste = RECARGO_SEIS_CUOTAS; }
        decimal total = importe * (1m + ajuste);
        string categoria = edad < 18 ? "Menor" : "Mayor";
        string formaPago = rbtEfectivo.Checked ? "Efectivo" : $"Tarjeta en {cuotas} cuotas";
        decimal valorCuota = rbtEfectivo.Checked ? total : total / cuotas;
        SOCIO socio = new() { Nombre = txtNombre.Text, Edad = edad, Categoria = categoria, Plan = plan, Horario = horario, Meses = meses, FormaPago = formaPago, Total = total, ValorCuota = valorCuota };
        string mensaje = $"Socio: {socio.Nombre}\nEdad: {socio.Edad} ({socio.Categoria})\nPlan: {socio.Plan}\nHorario: {socio.Horario}\nMeses: {socio.Meses}\nForma de pago: {socio.FormaPago}\nTotal: {socio.Total:C2}\nValor de cuota: {socio.ValorCuota:C2}";
        MessageBox.Show(mensaje, "Resumen de inscripción", MessageBoxButtons.OK, MessageBoxIcon.Information); EstadoInicial();
    }
}
