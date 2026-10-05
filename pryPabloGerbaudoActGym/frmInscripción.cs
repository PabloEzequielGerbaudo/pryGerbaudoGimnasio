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
        const int RECARGO = 10;
        const int RECARGO2 = 20;


        public frmInscripción()
        {
            InitializeComponent();

            cmbPlane.Items.Add("Musculación");
            cmbPlane.Items.Add("Funcional");
            cmbPlane.Items.Add("Natación");

            cmbTurno.Items.Add("Mañana");
            cmbTurno.Items.Add("Tarde");
            cmbTurno.Items.Add("Noche");

            cmbPago.Items.Add(1);
            cmbPago.Items.Add(3);
            cmbPago.Items.Add(6);

        }

        string nom, edad, planes, turno, meses, pago;
        int Edad, Meses;
        decimal Total, SubTotal, Desc_Edad;

        private void txtNom_TextChanged(object sender, EventArgs e)
        {
            nom = txtNom.Text;
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
            }
            if (Edad <18)
            {
                edad = "menor";
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

        private void cmbPlane_SelectedIndexChanged(object sender, EventArgs e)
        {
            planes = cmbPlane.Text;
            
        }

        private void cmbTurno_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtMeses_TextChanged(object sender, EventArgs e)
        {
            meses = txtMeses.Text;
            if (txtMeses.Text !="")
            {
                Meses = Convert.ToInt32(meses);
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
        }

        private void cmbPago_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (pago == "Efectivo")
            {

            }
            else if (pago == "Tarjeta")
            {
                switch (cmbPago.SelectedItem)
                {
                    case 1:

                        break;
                    case 3:

                        break;
                    case 6:

                        break;
                }
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            switch (planes)
            {
                case "Musculación":

                    if (chkCasillero.Checked = true)
                    {
                        SubTotal = SubTotal + (MUSCULACION + CASILLERO) * Meses;
                    }
                    else
                    {
                        SubTotal = SubTotal + (MUSCULACION * Meses);
                    }
                    break;
                case "Funcional":
                    if (chkCasillero.Checked = true)
                    {
                        SubTotal = SubTotal + (FUNCIONAL + CASILLERO) * Meses;
                    }
                    else
                    {
                        SubTotal = SubTotal + (FUNCIONAL * Meses);
                    }
                    
                    break;
                case "Natación":
                    if (chkCasillero.Checked = true)
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
                    Desc_Edad = (SubTotal * DESCUENTO_MENOR) / 100;
                    break;
                case "mayor":
                    Desc_Edad = (SubTotal * DESCUENTO_MAYOR) / 100;
                    break;
                default:
                    if (chkEstudiante.Checked = true)
                    {
                        Desc_Edad = (SubTotal * DESCUENTO_ESTUDIANTE) / 100;
                    }
                    break;
            }
        }
    }
}
