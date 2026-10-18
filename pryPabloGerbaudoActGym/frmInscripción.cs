using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Numerics;
using System.Text;
using System.Windows.Forms;

namespace pryPabloGerbaudoActGym
{
    public partial class frmInscripción : Form
    {

        const int MUSCULACION = 15000;
        const int FUNCIONAL = 18000;
        const int NATACION = 22000;
        const int CASILLERO = 3000;
        const decimal DESCUENTO_MENOR = 0.25m;
        const decimal DESCUENTO_MAYOR = 0.30m;
        const decimal DESCUENTO_ESTUDIANTE = 0.15m;
        const decimal DESCUENTO_EFECTIVO = 0.10m;
        const decimal RECARGO_CUOTA3 = 0.10m;
        const decimal RECARGO_CUOTA6 = 0.20m;
        string nom, edad, planes, turno, meses, pago, estudiante, casillero, mensaje;
        string Socios = "Socios.txt";
        int Edad, Meses, Cuotas;
        decimal Total, SubTotal, Desc_Edad, Recargo_Pago, Desc_Pago, Desc;
        SOCIO NuevoSocio = new SOCIO();
        public struct SOCIO
        {
            public string nom;
            public int Edad;
            public string estudiante;
            public string planes;
            public string turno;
            public int Meses;
            public string casillero;
            public string pago;
            public decimal Desc;
            public decimal total;
        }


        public frmInscripción()
        {
            InitializeComponent();

            cmbPlanes.Items.Add("Musculación");
            cmbPlanes.Items.Add("Funcional");
            cmbPlanes.Items.Add("Natación");

            cmbTurno.Items.Add("Mañana");
            cmbTurno.Items.Add("Tarde");
            cmbTurno.Items.Add("Noche");

            cmbPago.Items.Add(1);
            cmbPago.Items.Add(3);
            cmbPago.Items.Add(6);

        }

        private void EstadoInicial()
        {
            txtNom.Clear();
            txtEdad.Clear();
            txtMeses.Clear();
            txtMeses.Text = "1";
            cmbPlanes.SelectedIndex = 0;
            cmbTurno.SelectedIndex = 0;
            cmbTurno.Enabled = false;
            cmbPago.SelectedIndex = 0;
            chkCasillero.Checked = false;
            chkEstudiante.Checked = false;
            rbEfectivo.Checked = true;
            rbTarjeta.Checked = false;
            btnCalcular.Enabled = false;
            txtMeses.Enabled = false;
            txtNom.Focus();
            Edad = 0;
            Meses = 0;
            Total = 0;
            SubTotal = 0;
            Desc_Edad = 0;
            Desc_Pago = 0;
            Recargo_Pago = 0;
            Desc = 0;
            estudiante = "";
            casillero = "";

        }

        private void frmInscripción_Load_1(object sender, EventArgs e)
        {
            EstadoInicial();
        }
        private void txtNom_TextChanged_1(object sender, EventArgs e)
        {
            nom = txtNom.Text;
            if (txtNom.Text != "")
            {
                txtEdad.Enabled = true;
            }
            else
            {
                txtEdad.Enabled = false;
            }

        }
        private void txtNom_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txtEdad_TextChanged_1(object sender, EventArgs e)
        {

            edad = txtEdad.Text;
            if (txtEdad.Text != "")
            {
                Edad = Convert.ToInt32(edad);
                cmbPlanes.Enabled = true;
            }
            else
            {
                cmbPlanes.Enabled = false;
            }


        }
        private void txtEdad_Leave(object sender, EventArgs e)
        {
            if (Edad < 18)
            {
                edad = "menor";
                if (Edad <= 14)
                {
                    MessageBox.Show("Los menores de 14 años no pueden inscribirse.", "Edad Mínima",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cmbPlanes.Enabled = false;
                    txtEdad.Clear();
                    btnLimpiar.Enabled = true;

                }
            }
            else
            {
                if (Edad >= 65)
                {
                    edad = "mayor";
                }
            }
        }
        private void chkEstudiante_Leave(object sender, EventArgs e)
        {
            if (chkEstudiante.Checked == true)
            {
                estudiante = "SI";
            }
            else
            {
                estudiante = "NO";
            }
        }

        private void txtEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void cmbPlanes_SelectedIndexChanged(object sender, EventArgs e)
        {
            planes = cmbPlanes.Text;
            if (cmbPlanes.SelectedIndex != -1)
            {
                cmbTurno.Enabled = true;
            }
            else
            {
                cmbTurno.Enabled = false;
            }

        }

        private void cmbTurno_SelectedIndexChanged(object sender, EventArgs e)
        {
            turno = cmbTurno.Text;
            if (cmbTurno.SelectedIndex != -1)
            {
                txtMeses.Enabled = true;
            }
            else
            {
                txtMeses.Enabled = false;
            }
        }

        private void txtMeses_TextChanged(object sender, EventArgs e)
        {
            meses = txtMeses.Text;
            if (txtMeses.Text != "")
            {
                Meses = Convert.ToInt32(meses);
                if (Meses > 12)
                {
                    MessageBox.Show("No se puede ingresar más de 12 meses", "Máximo de Meses",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMeses.Clear();
                    txtMeses.Focus();
                }
            }

            if (txtNom.Text != "")
            {
                if (txtEdad.Text != "")
                {
                    if (txtMeses.Text != "")
                    {
                        btnCalcular.Enabled = true;
                    }
                    else
                    {
                        btnCalcular.Enabled = false;
                    }
                }
                else
                {
                    btnCalcular.Enabled = false;
                }
            }
            else
            {
                btnCalcular.Enabled = false;
            }
        }
        private void txtMeses_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void rbTarjeta_CheckedChanged(object sender, EventArgs e)
        {
            if (rbTarjeta.Checked == true)
            {
                cmbPago.Enabled = true;
                pago = "Tarjeta";
            }
            else
            {
                cmbPago.Enabled = false;
            }
        }

        private void cmbPago_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            switch (planes)
            {
                case "Musculación":

                    if (chkCasillero.Checked == true)
                    {
                        casillero = "SI";
                        SubTotal = SubTotal + (MUSCULACION + CASILLERO) * Meses;
                    }
                    else
                    {
                        casillero = "NO";
                        SubTotal = SubTotal + (MUSCULACION * Meses);
                    }
                    break;
                case "Funcional":
                    if (chkCasillero.Checked == true)
                    {
                        casillero = "SI";
                        SubTotal = SubTotal + (FUNCIONAL + CASILLERO) * Meses;
                    }
                    else
                    {
                        casillero = "NO";
                        SubTotal = SubTotal + (FUNCIONAL * Meses);
                    }

                    break;
                case "Natación":
                    if (chkCasillero.Checked == true)
                    {
                        casillero = "SI";
                        SubTotal = SubTotal + (NATACION + CASILLERO) * Meses;
                    }
                    else
                    {
                        casillero = "NO";
                        SubTotal = SubTotal + (NATACION * Meses);
                    }
                    break;
            }
            Total = SubTotal;
            switch (edad)
            {
                case "menor":
                    Desc_Edad = (Total * DESCUENTO_MENOR);
                    Total = Total - Desc_Edad;
                    Desc = DESCUENTO_MENOR * 100;
                    break;
                case "mayor":
                    Desc_Edad = (Total * DESCUENTO_MAYOR);
                    Total = Total - Desc_Edad;
                    Desc = DESCUENTO_MAYOR * 100;
                    break;
                default:
                    if (chkEstudiante.Checked == true)
                    {
                        Desc_Edad = (Total * DESCUENTO_ESTUDIANTE);
                        Total = Total - Desc_Edad;
                        Desc = DESCUENTO_ESTUDIANTE * 100;
                    }
                    break;
            }
        
            if (rbEfectivo.Checked == true)
            {
                Desc_Pago = (Total * DESCUENTO_EFECTIVO);
                Total = Total - Desc_Pago;
                Desc = Desc + (DESCUENTO_EFECTIVO * 100);
                pago = "Efectivo";
            }
            else if (rbTarjeta.Checked == true)
            {
                pago = "Tarjeta";
                switch (cmbPago.SelectedItem)
                {
                    case 1:
                        Cuotas = 1;
                        break;
                    case 3:
                        Cuotas = 3;
                        Recargo_Pago = (Total * RECARGO_CUOTA3);
                        Total = Total + Recargo_Pago;
                        break;
                    case 6:
                        Cuotas = 6;
                        Recargo_Pago = (Total * RECARGO_CUOTA6);
                        Total = Total + Recargo_Pago;
                        break;
                }
            }
            NuevoSocio.nom = nom;
            NuevoSocio.Edad = Edad;
            NuevoSocio.estudiante = estudiante;
            NuevoSocio.planes = planes;
            NuevoSocio.turno = turno;
            NuevoSocio.Meses = Meses;
            NuevoSocio.casillero = casillero;
            NuevoSocio.pago = pago;
            NuevoSocio.Desc = Desc;
            NuevoSocio.total = Total;
            MessageBox.Show("El total a pagar es: $" + Math.Truncate(Total), "Total de la Inscripción");
            mensaje = "Nombre: " + nom + "\nEdad: " + Edad + "\nEstudiante: " + estudiante + "\nPlan: " + planes + "\nTurno: " + turno + "\nMeses: " + meses + "\nCasillero: " + casillero + "\nForma de pago: " + pago + "\nCuotas: " + Cuotas + "\nSubTotal: $" + Math.Truncate(SubTotal) + "\nDescuento: " + Math.Truncate(Desc) + "%" + "\nTotal: $" + Math.Truncate(Total) + "\n---------------------------------------------------";
            MessageBox.Show(mensaje, "Detalle de Inscripción");
            lstSocios.Items.Add(mensaje);
            StreamWriter Socios = new StreamWriter("Socios.txt", true);
            Socios.WriteLine(mensaje);
            Socios.Close();
            btnCalcular.Enabled = false;
            EstadoInicial();
            btnLimpiar.Enabled = true;

        
        }

       
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
           EstadoInicial();
        }
        private void lstSocios_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstSocios.SelectedItem != null)
            {
                btnConsultar.Enabled = true;
            }
            else
            {
                btnConsultar.Enabled = false;
            }
        }
        private void btnConsultar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(lstSocios.SelectedItem.ToString(), "Detalle de Inscripción");
        }

        private void grpPago_Enter(object sender, EventArgs e)
        {

        }

       
    }
}
