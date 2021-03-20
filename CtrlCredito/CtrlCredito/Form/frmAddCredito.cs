using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;

namespace CtrldeCredito
{
    public partial class frmAddCredito : Form
    {
        private clsEjecutor objCliente;
//        private string CdgoTarjeta;
        private float Cdto_Pesos = 0;  // credito ,importe ingresado!
        private byte press = 0;

        public frmAddCredito(clsEjecutor _cliente)
        {
            InitializeComponent();

            this.objCliente = _cliente;
            lblCdgoTarjeta.Text = this.objCliente.Id;

        }

        private void tbSetCredito_KeyPress(object sender, KeyPressEventArgs e)
        {
            int kpress= Convert.ToByte(e.KeyChar);

            if (!(kpress >= 48 && kpress <= 57))
                return;     // salir!
            if (press == 3)
                return;     // salir!

            press++;
            int jl= kpress- 48;
            Cdto_Pesos = (Cdto_Pesos != 0) ? jl + (Cdto_Pesos * 10) : jl;
            lbOutput.Text = (Cdto_Pesos ).ToString("000.00");
//            lbOutput.Text = (Cdto_Pesos *0.01).ToString("00.00");        //ctvos!
        }

        private void InsertarCredito(float importe, clsEjecutor objCliente)
        {
            float sldo = objCliente.setCredito(importe);
            frmTicket fTicket = new frmTicket(objCliente, importe, sldo);
            fTicket.Show();
/*
            clsActividad oActividad = new clsActividad();
            oActividad.setAtributos(objCliente.Id, "CDT", 0, 0);
            oActividad.InsertToDataBase();

            Console.WriteLine("SALDO ACTUAL: $"+ sldo);
//            Close();
 * */
        }

        private DialogResult MsjeBoxConfirmar(string idtjeta, float importe)
        {
            string ALERT_OK = String.Format(
                "Está apunto de recargar ${0} a la tarjeta N° {1}.\n¿Desea Confirmar la Operación?", 
                    importe, idtjeta);
            return
                MessageBox.Show(ALERT_OK, "ATENCION",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information);
        }

        private DialogResult MsjeBoxImprimir()
        {
            string ALERT_OK = String.Format("Deseas imprimir ticket?");
            return
                MessageBox.Show(ALERT_OK, "ATENCION",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information);
        }

        private void btOK_Click(object sender, EventArgs e)
        {
            String CdgoTarjeta = this.objCliente.Id;
            if (Cdto_Pesos == 0) {
                Close(); return;
            }
            // FALTARIA AGREGAR ALGUNOS IF

            if (MsjeBoxConfirmar(CdgoTarjeta, this.Cdto_Pesos) == DialogResult.No)
            {
                return; // salir!
            }
            InsertarCredito(this.Cdto_Pesos, objCliente);
            /*
            objprint = new frmEnviarDtsPrint();
            if (MsjeBoxImprimir() == DialogResult.Yes) {
                objprint.Show();
                return;
            }
            */
            if (objCliente.getExisteCte()) {
                Close(); return; // Cliente registrado anteriormente en base datos!
            }
            VerDtsCliente(CdgoTarjeta);
            Close(); 
        }

        private void btSetImporte_Click(object sender, EventArgs e)
        {
            Cdto_Pesos = press = 0;
            lbOutput.Text = "000,00";            
        }

        private DialogResult  MsjeBoxNoExisteTarj(string tCdgoTarjeta)
        {
            string ALERT_OK = String.Format(
                "La tarjeta {0} no se encuentra registrada en la Base de datos. \n¿Desea ingresar los datos ahora?", tCdgoTarjeta);
            return 
                MessageBox.Show(ALERT_OK, "ATENCION",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information);
        }

        private void VerDtsCliente(String CdgoTarjeta)
        {
            //clsEjecutor objCliente = new clsEjecutor(this.CdgoTarjeta);
            bool blExisteCte = objCliente.getExisteCte();

            if (!blExisteCte)
            {   /*  Cliente NO esta registrado en base datos.   */
                if (MsjeBoxNoExisteTarj(CdgoTarjeta) == DialogResult.No)
                    return;
                /* blExisteCte(false) tds los Campos quedan habilitados para modificar! */
            }
            frmCliente ofrmCliente = new frmCliente(objCliente, blExisteCte);
            ofrmCliente.Show();	/*  MUESTRA FORMULARIO CON DATOS DEL EJECUTOR ELEGIDO POR el admin. */
            //this.Hide();
        }

        private void btDtsCliente_Click(object sender, EventArgs e)
        {
            VerDtsCliente(this.objCliente.Id);
        }

    }
}
