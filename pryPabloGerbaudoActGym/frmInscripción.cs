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
        const int DESCUENTO = 10;
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
        int Edad, Meses, Total;

        private void txtNom_TextChanged(object sender, EventArgs e)
        {
            nom = txtNom.Text;
        }

        private void txtEdad_TextChanged(object sender, EventArgs e)
        {

            edad = txtEdad.Text;
             if (txtEdad.Text != "")
             {
                    Edad = Convert.ToInt32(edad);
             }
            
           
        }

        private void cmbPlane_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbPlane.SelectedItem)
            {
                case "Musculación":
                    Total = Total + MUSCULACION;
                    break;
                case "Funcional":
                    Total = Total + FUNCIONAL;
                    break;
                case "Natación":
                    Total = Total + NATACION;
                    break;
            }
        }

        private void cmbTurno_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch ()
        }

        private void txtMeses_TextChanged(object sender, EventArgs e)
        {
            meses = txtMeses.Text;
            Meses = Convert.ToInt32(meses);
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
    }
}
