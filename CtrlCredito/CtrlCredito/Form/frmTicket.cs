using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace CtrldeCredito
{
    public partial class frmTicket : Form
    {
//        private clsActividad oActividad = new clsActividad();   
//        private clsEjecutor objCliente;
        private string portname;

        private string dtCdgo_t;
        private string dtDocNumber;
        private string dtPatente;
        private float dtImporte;
        private float dtSaldo;

        public frmTicket(clsEjecutor objCliente, float _importe, float _saldo)
        {
            InitializeComponent();
            rbtPorts();
            this.portname = "COM3";
            this.dtCdgo_t = objCliente.Id;
            this.dtDocNumber= objCliente.DNI;
            this.dtPatente  = objCliente.Patente;
            this.dtImporte  = _importe;
            this.dtSaldo    = _saldo;            
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void enviarCharacter(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            byte[] Crter = new byte[1];
            Crter[0] = Convert.ToByte(e.KeyChar);
            SenderSerialPort.Write(Crter, 0, Crter.Length);
            Thread.Sleep(31);
        }
        /*
        private int ticks = 0;
        private String Cadena = "";
         * * */

        private void btOK_Click(object sender, EventArgs e)
        {
            this.ticks = 0;
            this.Cadena = getline();
            this.timer1.Enabled = true;
        }

        private void SendCterFinal(int cterfinal)
        {
            byte[] Crter = new byte[1];
            Crter[0] = Convert.ToByte(cterfinal);
            SenderSerialPort.Write(Crter, 0, Crter.Length);
        }

        public string getcrter()
        {
            return "";
        }
        public string getline()
        {
            String lt =  "******* AUTOLAVADO 1040 *******\n";
                   lt += "-------------------------------\n";
                lt += DateTime.Now.ToString(@"dd/MM/yyyy HH:mm");
                lt += "\nTARJETA: " + this.dtCdgo_t;
                lt += "\nDNI: " + this.dtDocNumber;
                lt += "\nDominio: " + this.dtPatente;
                lt += "\nCarga: $" + this.dtImporte + ",00.-";
                lt += "\nSaldo Actual: $" + this.dtSaldo + ",00.-";
                lt += "\n-------------------------------";
                lt += "\n/** Este comprobante no \nsirve como factura **/";
                lt += "\n\n\n";
            return lt;
        }
        private int ticks;
        private string Cadena;

        private void timer1_Tick(object sender, EventArgs e)
        {
            // enviando crter por crter a través de cmd SenderSerialPort
            if (this.ticks < this.Cadena.Length)
            {
                byte[] Crter = new byte[1];
                Crter[0] = Convert.ToByte(Cadena[this.ticks]);
                SenderSerialPort.Write(Crter, 0, Crter.Length);
                this.ticks++;
                return;         
            }
//            SendCterFinal(10);
            timer1.Enabled = false;
        }
        
        private void button1_Click(object sender, EventArgs e)
        {            
            try
            {
                this.SenderSerialPort.PortName = this.portname;
                if (!SenderSerialPort.IsOpen)
                    SenderSerialPort.Open();
                btOK.Enabled = true;
            }
            catch (System.IO.IOException lt)
            {
                btOK.Enabled = false;
                MessageBox.Show(lt.Message);
            }
        }

        private void rbtPorts() 
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is RadioButton) {   
                    RadioButton rbtn = (RadioButton)ctrl;
                    rbtn.Click += new System.EventHandler(this.rbt_Clicked);
                }
            }
        }

        private void rbt_Clicked(object sender, EventArgs e)
        {
            SenderSerialPort.Close();

            btOK.Enabled = false;
            RadioButton rbt = (RadioButton)sender;
            this.portname = rbt.Name;
//            MessageBox.Show(rbt.Name);
        }

    }
}
