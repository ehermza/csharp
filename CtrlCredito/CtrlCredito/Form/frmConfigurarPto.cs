using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
//using CtrlCredito.Clases;

namespace CtrldeCredito
{
    public partial class frmConfigurarPto: Form
    {
        //private clsCdgoTarjeta objCdgoTarjeta;
        private SerialPort SPortObject;
        private clsPortConfig objConfig;
        private string portname;
        private App frmApp;

        /**************************************
         * Flujo datos que llega a través de puerto COM3
         *  formato de trama seria: 
         *      '02/CDGOHEXADECIMAL/13/10/03'
         **************************************/

        public frmConfigurarPto(App form)
        {
            InitializeComponent();
            frmApp = form;
            lbCartel.Text = "Puerto No Encontrado";
            lbCartel.ForeColor = Color.Red;
            lbl1.Text = "Elija puerto y presione <Verificar>";
            btGuardar.Enabled = false;
            //SPortObject.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(RecibirCtres);
            rbtPorts();
        }

        public void SetSerialPort(SerialPort _SystemSerialPort)
        {
            this.SPortObject = _SystemSerialPort;
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
        private string idPort;

        private void Verificar()
        {
            btOK.Enabled = false;
            //MessageBox.Show(btOK.Enabled.ToString());
            idPort = this.portname.Substring("Rbt".Length);  // COM(idPort)
            try
            {
                this.SPortObject.PortName = "COM" + idPort;
                if (!SPortObject.IsOpen){
                    SPortObject.Open();
                }
                btGuardar.Enabled = true;
                lbCartel.Text = "DISPOSITIVO CONECTADO";
                lbCartel.ForeColor = Color.FromArgb(0, 0, 192, 0);
                lbl1.Text = "Presione <Guardar> para confirmar operación.";
            }
            catch (System.IO.IOException lt)
            {
                btGuardar.Enabled = false;
                lbl1.Text = "Elija puerto y presione <Verificar>";
                //lbl1.ForeColor = Color.Red;
                lbCartel.Text = "Puerto No Encontrado";
                lbCartel.ForeColor = Color.Red;

                MessageBox.Show(lt.Message);
            }
        }
        private void btOK_Click(object sender, EventArgs e)
        {
            Verificar();
        }

        private void rbt_Clicked(object sender, EventArgs e)
        {
            SPortObject.Close();
            //btOK.Enabled = false;
            RadioButton rbt = (RadioButton)sender;
            this.portname = rbt.Name;
            btOK.Enabled = true;
        }

        private void rbtPorts()
        {
            foreach (Control ctrl in this.gb1.Controls)
            {
                if (ctrl is RadioButton)
                {
                    RadioButton rbtn = (RadioButton)ctrl;
                    rbtn.Click += new System.EventHandler(this.rbt_Clicked);
                }
            }
        }

        private void Almacenar()
        {
            clsPortConfig objConfig = new clsPortConfig();
            objConfig.Write(idPort, 9600);  //CAMBIAR
            frmApp.InitLectura();
            Close();
        }

        private void btGuardar_Click(object sender, EventArgs e)
        {
            Almacenar();
        }



    }
}
