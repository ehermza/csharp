using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CtrldeCredito
{
    class clsCdgoTarjeta
    {
        private clsEjecutor objCliente;
        private App formLectTarjeta;
        private frmAddCredito objfrmAddCredito;

        public clsCdgoTarjeta(App form)
        {
            this.formLectTarjeta = form;
        }
/*
        private String getCdgoTarjeta(byte[] LogoDataBy)
        {
            String datos = "";
            bool blGetDts = false;
            foreach (byte l in LogoDataBy)
            {
                if (blGetDts && l > 31)
                {   // Recolectando info del flujo datos (cdgo tarjeta)                       
                    datos += Convert.ToChar(l);
                }
                // charbyte= 02 /Comienzo de trama.
                if (l == 2) blGetDts = true;
                // charbyte= 13 /Final de trama (CF)
                else if (l == 13)
                    blGetDts = false;
            }
            return datos;
        }

        private string getCdgoDecimal(string Dts)
        {
            // Dts= Cdgo tarjeta en formato hexadecimal(string)
            // Se debe pasar a formato decimal.
            // Dts viene con encabezado "0500" que se debe descartar
            //  ...para luego procesar el resto.
 
            string cdgohex = getCdgoTarjeta(ASCIIEncoding.ASCII.GetBytes(Dts));
            string CdgoTarjeta = cdgohex.Substring("0500".Length);

            int size = CdgoTarjeta.Length - 1;
            long CdgoInt32 = 0;
            byte cant = 0;
            foreach (char l in CdgoTarjeta)
            {
                string hex = "0x0" + l;
                int valor = Convert.ToInt32(hex, 16);
                CdgoInt32 += valor * (long)Math.Pow(16, size - cant++);
                //MessageBox.Show(valor.ToString());
            }
            //MessageBox.Show(CdgoInt32.ToString());
            return CdgoInt32.ToString();
        }
*/
        private System.Windows.Forms.DialogResult MsjeBoxNoExisteTarj(string tCdgoTarjeta)
        {
            string ALERT_OK = String.Format(
                "La tarjeta {0} no se encuentra registrada en la Base de datos. \n¿Desea darle de alta ahora?", tCdgoTarjeta);
            return
                System.Windows.Forms.MessageBox.Show(ALERT_OK, "ATENCION",
                    System.Windows.Forms.MessageBoxButtons.YesNo, System.Windows.Forms.MessageBoxIcon.Information);
        }

        public void VerDtsCliente(string Cdgo)    // from TimerReaderCard_Tick()
        {
            /* Se obtiene datos del cliente desde base datos, 
             *  Si CdgoTarjeta no esta registrado en tbl usuario: 
             *    se abrirá form para llenar datos del trabajador.
             *  Sino se abrirá form para recarga de crédito.
             * */
            objCliente = new clsEjecutor(Cdgo);
            objCliente.SetDtsBaseDatos();
            bool blExisteCte = objCliente.getExisteCte();

            if (!blExisteCte)
            {   // Tarj NO esta registrado en base datos. Preguntar al admin si quiere darle de alta. 
                if (MsjeBoxNoExisteTarj(Cdgo) == System.Windows.Forms.DialogResult.No)
                    return;
                // blExisteCte(false) tds los Campos quedan habilitados para modificar!
                frmCliente ofrmCliente = new frmCliente(objCliente, false);
                ofrmCliente.Show();	// 
                return;
            }
            objfrmAddCredito = new frmAddCredito(objCliente);
            objfrmAddCredito.Show();
        }
/*
        public void AbrirFormCliente(string Dts)
        {
            string cdgo = getCdgoDecimal(Dts);
            VerDtsCliente(cdgo);
        }
        */
    }
}
