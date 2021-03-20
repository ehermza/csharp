using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
/*
 * @author: ehermza
 *    date: 18 de julio de 2014.
 *    proyecto Ctrl de Credito Autolavado.-
 *		FORMULARIO PARA INSERTAR/ MODIFICAR DATOS DEL EJECUTOR.
 */

namespace CtrldeCredito
{
    public partial class frmCliente : Form
    {
        private clsVerifCampos verifcampos = new clsVerifCampos();

        private const string ALERT_EXIST = "El usuario ya existe en la base de datos.\n Intente ingresando un username distinto.";
        private const string ALERT_OK = "El usuario se ingresó exitosamente a la Base de Datos";

        private clsEjecutor objCliente;
        private bool blExisteCte;
        private string strCamposError = "ND";

        public frmCliente(clsEjecutor _Cliente, bool blReadOnly)
        {	/* MUESTRA FORMULARIO CON LOS DATOS CORRESPONDIENTES 
				AL EJECUTOR (INDICADO EN EL 2d ARGUMENTO.) PARA MODIFICARLOS */
            InitializeComponent();
            btModificar.Enabled = blReadOnly;
            btOK.Enabled = false;       // Se habilita recien al llenar los campos obligatorios.

            this.objCliente = _Cliente;
            this.blExisteCte = blReadOnly;
//            this.ofrmAddcredito = _frmParent;     // quitar!
//            tbId_tarjeta.Enabled = false;

            tbDocNumber.Text = objCliente.DNI;
            tbDomicilio.Text = objCliente.Domicilio;
            tbNombre.Text   = objCliente.Nombre;
            tbPatente.Text  = objCliente.Patente;
            tbCelular.Text  = objCliente.Celular;
            tbTelefono.Text = objCliente.Telefono;
            tbFbk.Text      = objCliente.Fbk;
            tbEmail.Text    = objCliente.Email;
//            lbel13.Text = "$ ";
            lbel13.Text = objCliente.Saldo.ToString("0.00");

            foreach (Control oControls in this.Controls)
            {
                if (oControls is TextBox) {
                    TextBox tb = oControls as TextBox;
                    tb.ReadOnly = blReadOnly;
                }
            }
            tbTarjeta.ReadOnly = true;
            tbTarjeta.Text = objCliente.Id;
        }

        private DialogResult MsgBoxTransferSaldo(string tCdgoTarjeta, float saldo)
        {
            string dt = "El DNI {0}\n ya está asociada a la tarjeta N° {1}\n y tiene un saldo de ${2}."; 
                dt+= "\n ¿Desea transferir dicho saldo a la nueva tarjeta?";
                string ALERT_OK = String.Format(dt, tbDocNumber.Text, tCdgoTarjeta, saldo);
                
            return
                MessageBox.Show(ALERT_OK, "ATENCION",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information);
        }

        private int DarAltaTarjeta()
        {       // 27/AGO2014
            String cdgo_t = objCliente.getCoincidencia();
            if (cdgo_t.Length == 0)
            {
                // No existe otra tarjeta en bdts con el dni ingresado en form
                return objCliente.Insertar("0.00");
            }
            /*  dt en formato "CdgoTarjeta#SaldoActual" 
             *  dt!= "" si hay otra tarjeta con mismo DNI en la bdts. */
            clsEjecutor objCliente_t = new clsEjecutor(cdgo_t);
                        objCliente_t.SetDtsBaseDatos();
            float sldo = objCliente_t.Saldo;

            DialogResult drlt = MsgBoxTransferSaldo(cdgo_t, sldo);
            if (drlt == System.Windows.Forms.DialogResult.Yes)
            {   /* El admin. quiere transferir saldo de la tarj. anterior 
                    *  y Bloquearla. */
                objCliente_t.BlockTarjeta();
                return
                    objCliente.Insertar(sldo.ToString());
//                    continuar...
//                  
            }
            return objCliente.Insertar("0.00");
        }

        private void btOK_Click(object sender, EventArgs e)
        {	/*  27ago-2014.
			CONFIRMAR DATOS INGRESADOS EN FORMULARIO PARA INGRESAR/ MODIFICAR EN BASE DATOS */
            objCliente.setAtributos(
//                tbId_tarjeta.Text,
                tbNombre.Text, 
                tbDomicilio.Text, 
                tbCelular.Text, 
                tbTelefono.Text, 
                tbEmail.Text, 
                tbFbk.Text, 
                tbDocNumber.Text,
                tbPatente.Text, 
                '0', -1
            );	// clsEjecutor -ln.30
            int jl = (this.blExisteCte) ? objCliente.Modificar() : DarAltaTarjeta();

            if (jl == -1)
            {     // Error al intentar ingresar datos a mysql.
                MessageBox.Show(ALERT_EXIST, "ADVERTENCIA",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;     // algo salió mal!
            }
            DialogResult dr = MessageBox.Show(ALERT_OK, "Nuevo Ejecutor insertado",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (dr == DialogResult.OK)
            {
                GotoMain();
            }
        }

        private void GotoMain() {
            this.Close();
        }

        private void btCancel_Click(object sender, EventArgs e) {
            GotoMain();
        }

        private void btAddCredito_Click(object sender, EventArgs e)
        {
            frmClaveAdmin oClaveAdmin = new frmClaveAdmin(this);
            oClaveAdmin.Show();
        }

        private void GenerarNuevoCdgo()
        {
            Random rnd = new Random();
            String keygen = "";
            for (var i = 0; i < 7; i++)
            {
                int byte_dgt = rnd.Next(48, 58);
                keygen += Convert.ToChar(byte_dgt);
            }
            tbTarjeta.Text = keygen;
        }

        public void CtrlClaveAdmin(string pwdAdmin)     // from frmClaveAdmin.cs
        {
            if (!"admin".Equals(pwdAdmin))
            {   // msje textox clave mal ingresada!
                string msjebox = "Clave Inconrrecta! Intente Nuevamente.";
                DialogResult dr = MessageBox.Show(msjebox, "",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;     // salir!
            }
            foreach (Control octrl in this.Controls)
            {   // habilitar todos los campos de txt.
                if (octrl is TextBox) {
                    TextBox tb = octrl as TextBox;
                    tb.ReadOnly = false;
                }
            }
            tbTarjeta.ReadOnly = true;
            tbPatente.ReadOnly = true;
            tbDocNumber.ReadOnly = true;
            btModificar.Enabled = false;
        }
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void ReportarError(char letra)
        {
            if (strCamposError.IndexOf(letra)!= -1) {
                return;
            }
            strCamposError += letra;
            btOK.Enabled = false;
//            Console.WriteLine("strCamposError: " + strCamposError);
        }

        private void QuitarError(char letra)
        {
            if (strCamposError.IndexOf(letra) == -1) {
                return;
            }
            String[] arraystr = strCamposError.Split(letra);
            strCamposError = string.Concat(arraystr);

            if("".Equals(strCamposError))
                btOK.Enabled = true;
//            Console.WriteLine("strCamposError: " + strCamposError);
        }

        private void MostrarAdvertencia(String ErrorMsgBox, TextBox tbox, char l)
        {
            tbox.BackColor = (ErrorMsgBox.Length != 0) ? Color.MistyRose : Color.White;
            if ("".Equals(ErrorMsgBox))
            {
                QuitarError(l);
                EP1.SetError(tbox, String.Empty);
                return;         // salir!
            }
            ReportarError(l);
            EP1.SetError(tbox, ErrorMsgBox);            
        }

        private void tbPatente_TextChanged(object sender, EventArgs e)
        {
            string ErrorMsgBox = verifcampos.RevisarPatente(tbPatente.Text);
            MostrarAdvertencia(ErrorMsgBox, tbPatente, 'P');
        }

        private void tbNombre_TextChanged(object sender, EventArgs e)
        {
            string ErrorMsgBox = verifcampos.RevCtresNombre(tbNombre.Text);
            MostrarAdvertencia(ErrorMsgBox, tbNombre, 'N');
        }

        private void tbEmail_TextChanged(object sender, EventArgs e)
        {
            string ErrorMsgBox = verifcampos.RevisarCorreo(tbEmail.Text);
            MostrarAdvertencia(ErrorMsgBox, tbEmail, 'E');
        }

        private void tbDocNumber_TextChanged(object sender, EventArgs e)
        {
            string ErrorMsgBox = verifcampos.RevDocNumber(tbDocNumber.Text);
            MostrarAdvertencia(ErrorMsgBox, tbDocNumber, 'D');
        }

        private void tbCelular_TextChanged(object sender, EventArgs e)
        {
            string ErrorMsgBox = verifcampos.RevCtresNumber(tbCelular.Text);
            MostrarAdvertencia(ErrorMsgBox, tbCelular, 'C');
        }

        private void tbTelefono_TextChanged(object sender, EventArgs e)
        {
            string ErrorMsgBox = verifcampos.RevCtresNumber(tbTelefono.Text);
            MostrarAdvertencia(ErrorMsgBox, tbTelefono, 'T');
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }


    }
}