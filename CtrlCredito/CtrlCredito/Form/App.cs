using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;
//using CtrlCredito.Clases;

namespace CtrldeCredito
{
    public partial class App : Form
    {
        //private frmActividad objFrmActividad;
        private frmConfigurarPto objConfigurarPto;
        private frmListRecarga objfrmListRecargas;
        //private clsPortConfig objConfig;

        private clsCdgoTarjeta objCdgoTarjeta;
        private static int SGDOS_MAXIMO = 1;
        private DateTime dt_init;
        private String Dts = "";

        public App()
        {
            InitializeComponent();
            InitLectura();
        }

        public void InitLectura()
        {
            clsPortConfig objConfig = new clsPortConfig();
            Verificar(objConfig.GetPort());
            
            SPortObject.DataReceived += 
                new System.IO.Ports.SerialDataReceivedEventHandler(RecibirCtres);
        }
        
        private void Verificar(string infoport)
        {
            // *** string infoport:= "R,velocidad,puerto" 
            string[] infoArray = infoport.Split(',');
            try
            {
                if (SPortObject.IsOpen) {
                    SPortObject.Close();
                }
                this.SPortObject.PortName = infoArray[2];
                SPortObject.Open();

                rbt2.ForeColor = Color.Black;
                lbl2.Text = "Pasar tarjeta por lectora...";
                lbl2.ForeColor = Color.FromArgb(0, 0, 192, 0);
            }
            catch (System.IO.IOException lt)
            {
                //rbt2.ForeColor = Color.Blue;
                lbl2.ForeColor = Color.Red;
                lbl2.Text = "No detecta lector de tarjeta";
                MessageBox.Show(
                    "El lector de tarjeta no está conectado al puerto configurado. \nEntrar a la opción \"Configurar Pto. Lectora\" para resolver conflicto.",
                        "Error de lectura", MessageBoxButtons.OK,MessageBoxIcon.Asterisk
                      );
            }
        }
        private bool blActividad;

        private void RecibirCtres(object l, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            Dts += this.SPortObject.ReadExisting();
            this.Invoke(new EventHandler(Actualizar));
        }

        private void Actualizar(object objeto, EventArgs e)
        {
            lbSgdos.Text += Dts;
            if (!timer1.Enabled)
            {
                timer1.Enabled = true;
                dt_init = DateTime.Now;
            }
        }

        private void ProcesarCdgo()
        {
            timer1.Enabled = false;
            //SPortObject.Close();
            string cdgo = getCdgoDecimal(Dts);        // CAMBIAR! Insertar en alguna clase.
            Dts = "";
            if (!blActividad)
            {
                this.objCdgoTarjeta = new clsCdgoTarjeta(this);
                this.objCdgoTarjeta.VerDtsCliente(cdgo);
                return;
            }
            this.ObjActividad.SetCdgoTarjeta(cdgo);
        }


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

        private string getCdgoDecimal(string datos)
        {
            // Dts= Cdgo tarjeta en formato hexadecimal(string)
            // Se debe pasar a formato decimal.
            // Dts viene con encabezado "0500" que se debe descartar
            //  ...para luego procesar el resto.

            string cdgohex = getCdgoTarjeta(ASCIIEncoding.ASCII.GetBytes(datos));
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

        private void TimerReaderCard_Tick(object sender, EventArgs e)
        {
            TimeSpan tsInterval = DateTime.Now - dt_init;
            int sgdos = tsInterval.Seconds;

            if (sgdos > SGDOS_MAXIMO)
            {
                ProcesarCdgo();
                return;     //salir!
            }
            // loading barra de progreso... 
            pbar.Value = Convert.ToInt16(sgdos * 100 / SGDOS_MAXIMO);
        }
        private clsActividad ObjActividad;

        private void btAceptar_Click(object sender, EventArgs e)
        {
            if (rbt2.Checked)
            {
                objConfigurarPto = new frmConfigurarPto(this);
                objConfigurarPto.SetSerialPort(SPortObject);
                //objConfigurarPto.SetConfig();
                objConfigurarPto.Show();
            }
            else if (rbt3.Checked)
            {
                ObjActividad= new clsActividad();
                blActividad = true;
            }
            else if (rbt1.Checked)
            {
                objfrmListRecargas = new frmListRecarga();
                objfrmListRecargas.Show();
            }

        }

        void SPortObject_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();    // btn Salir
        }
    }
}
