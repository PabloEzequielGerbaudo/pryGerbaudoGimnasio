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
        const decimal RECARGO_CUOTA6 = 0.30m;
        string nom, edad, planes, turno, meses, pago;
        int Edad, Meses;
        decimal Total, SubTotal, Desc_Edad, Recargo_Pago, Desc_Pago;


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
            cmbPago.SelectedIndex = -1;
            chkCasillero.Checked = false;
            chkEstudiante.Checked = false;
            rbEfectivo.Checked = true;
            rbTarjeta.Checked = false;
            btnCalcular.Enabled = false;
            txtNom.Focus();
            Edad = 0;
            Meses = 0;
            Total = 0;
            SubTotal = 0;
            Desc_Edad = 0;
            Desc_Pago = 0;
            Recargo_Pago = 0;

        }
        private void frmInscripción_Load(object sender, EventArgs e)
        {
            EstadoInicial();
        }
        private void txtNom_TextChanged(object sender, EventArgs e)
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
        private void txtNom_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txtEdad_TextChanged(object sender, EventArgs e)
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

        private void txtEdad_Click_1(object sender, EventArgs e)
        {

        }
        private void cmbPlanes_Click(object sender, EventArgs e)
        {
            if (Edad < 18)
            {
                edad = "menor";
                if (Edad <= 14)
                {
                    MessageBox.Show("Los menores de 14 años no pueden inscribirse.");
                    cmbPlanes.Enabled = false;
                    txtEdad.Clear();
                    txtEdad.Focus();

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
                    MessageBox.Show("No se puede ingresar más de 12 meses");
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
        private void rbEfectivo_CheckedChanged(object sender, EventArgs e)
        {
            pago = "Efectivo";
        }

        private void rbTarjeta_CheckedChanged(object sender, EventArgs e)
        {
            pago = "Tarjeta";
            if (rbTarjeta.Checked == true)
            {
                cmbPago.Enabled = true;
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
                        SubTotal = SubTotal + (MUSCULACION + CASILLERO) * Meses;
                    }
                    else
                    {
                        SubTotal = SubTotal + (MUSCULACION * Meses);
                    }
                    break;
                case "Funcional":
                    if (chkCasillero.Checked == true)
                    {
                        SubTotal = SubTotal + (FUNCIONAL + CASILLERO) * Meses;
                    }
                    else
                    {
                        SubTotal = SubTotal + (FUNCIONAL * Meses);
                    }

                    break;
                case "Natación":
                    if (chkCasillero.Checked == true)
                    {
                        SubTotal = SubTotal + (NATACION + CASILLERO) * Meses;
                    }
                    else
                    {
                        SubTotal = SubTotal + (NATACION * Meses);
                    }
                    break;
            }
            switch (edad)
            {
                case "menor":
                    Desc_Edad = (SubTotal * DESCUENTO_MENOR);
                    SubTotal = SubTotal - Desc_Edad;
                    break;
                case "mayor":
                    Desc_Edad = (SubTotal * DESCUENTO_MAYOR);
                    SubTotal = SubTotal - Desc_Edad;
                    break;
                default:
                    if (chkEstudiante.Checked == true)
                    {
                        Desc_Edad = (SubTotal * DESCUENTO_ESTUDIANTE);
                        SubTotal = SubTotal - Desc_Edad;
                    }
                    break;
            }

            if (rbEfectivo.Checked == true)
            {
                Desc_Pago = (SubTotal * DESCUENTO_EFECTIVO);
                Total = SubTotal - Desc_Pago;
            }
            else if (rbTarjeta.Checked == true)
            {
                switch (cmbPago.SelectedItem)
                {
                    case 3:
                        Recargo_Pago = (SubTotal * RECARGO_CUOTA3);
                        Total = SubTotal + Recargo_Pago;
                        break;
                    case 6:
                        Recargo_Pago = (SubTotal * RECARGO_CUOTA6);
                        Total = SubTotal + Recargo_Pago;
                        break;
                }
            }
            MessageBox.Show("El total a pagar es: " + Total);
            btnLimpiar.Enabled = true;

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            EstadoInicial();
        }

       
    }
}
