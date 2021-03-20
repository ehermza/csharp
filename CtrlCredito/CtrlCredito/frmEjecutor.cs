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
 *    date: 21 de octubre 2013.
 *    proeycto Agroconnect
 *		FORMULARIO PARA INSERTAR/ MODIFICAR DATOS DEL EJECUTOR
 */

namespace WindowsFormsApplication1
{
    public partial class frmEjecutor : Form
    {
        private const string ALERT_EXIST = "El usuario ya existe en la base de datos.\n Intente ingresando un username distinto.";
        private const string ALERT_OK = "El usuario se ingresó exitosamente a la Base de Datos";

        private clsEjecutor Ejecutor = new clsEjecutor();
        private frmBuscarEjecutor objFormBuscarEj;
        private Boolean blModificar;
//        clsVerifCampos verif = new clsVerifCampos();
//        clsMysqlConexion objmysql = new clsMysqlConexion();

        public frmEjecutor(frmBuscarEjecutor myClassForm)
        {
            // abre formulario: Ingresar Nuevo Ejecutor.
            InitializeComponent();
            blModificar = false;
            objFormBuscarEj = myClassForm;
            cargarlbEmpresa("");        // listbox empresas. 	-ln.60
            cargarlbDocType("");        // listbox doc type.	-ln.83
        }

        public frmEjecutor(frmBuscarEjecutor myClassForm, clsEjecutor oEjecutor)
        {	/* MUESTRA FORMULARIO CON LOS DATOS CORRESPONDIENTES 
				AL EJECUTOR (INDICADO EN EL 2d ARGUMENTO.) PARA MODIFICARLOS */
            InitializeComponent();
            this.blModificar= true;
            objFormBuscarEj = myClassForm;

            tbUsername.Text = oEjecutor.Id;
            tbUsername.Enabled = false;

            tbNombre.Text = oEjecutor.Nombre;
            tbApellido.Text = oEjecutor.Apellido;
            tbLegajo.Text = oEjecutor.Legajo;
            tbDocNumber.Text = oEjecutor.NumberDoc;
            tbTelefono.Text = oEjecutor.Telefono;
            cargarlbDocType(oEjecutor.TypeDoc);		// listbox doc type. -ln.83
            cargarlbEmpresa(oEjecutor.NumberDoc);	// listbox empresas. -ln.60
        }

        private void cargarlbEmpresa(String valor)
        {
            ArrayList listEmpresa;
            if (valor != "")
            {
                listEmpresa = new ArrayList();
                listEmpresa.Add(new clsListBoxArray(valor, ""));
                lbEmpresa.DataSource = listEmpresa;
                lbEmpresa.DisplayMember = "strNombre";
                lbEmpresa.ValueMember = "strNombre";
                return;     // salir!
            }
            listEmpresa = Ejecutor.getlbEmpresa();
            try
            {
                lbEmpresa.DataSource = listEmpresa;
                lbEmpresa.DisplayMember = "strNombre";
                lbEmpresa.ValueMember = "strClave";
            }
            catch (System.ArgumentException e)
            {
            }
        }

        private void cargarlbDocType(String valor)
        {
            ArrayList listaDocType = Ejecutor.getlbDocType(valor);	// clsEjecutor -ln.54

            lbDocType.DataSource = listaDocType;
            lbDocType.DisplayMember = "strNombre";	// atr. de clsListBoxArray
            lbDocType.ValueMember = "strClave";		// atr. de clsListBoxArray
        }

        private void ListBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            this.Text = lbEmpresa.SelectedValue.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btOK_Click(object sender, EventArgs e)
        {	/* 
			CONFIRMAR DATOS INGRESADOS EN FORMULARIO PARA INGRESAR/ MODIFICAR EN BASE DATOS */
            String empresa = "";
            if (lbEmpresa.SelectedIndex != -1) {
                empresa= lbEmpresa.SelectedValue.ToString();
            }
            String doctype = "";
            if (lbDocType.SelectedIndex != -1) {
                doctype = lbDocType.SelectedValue.ToString();
            }
            Ejecutor.setAtributos(
                tbUsername.Text, tbNombre.Text, tbApellido.Text, tbLegajo.Text, empresa, tbDocNumber.Text, doctype, tbTelefono.Text
            );	// clsEjecutor -ln.30

            String msjebox = Ejecutor.RevisarCondicion();	// clsEjecutor -ln.70

            if (msjebox.Length > 0) {
                MessageBox.Show(msjebox, "ATENCION",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;     // salir!
            }

            int jl = (this.blModificar) ? Ejecutor.Modificar() : Ejecutor.Insertar();	// clsEjecutor -ln.100

            if (jl == -1) {     // Error al intentar ingresar datos a mysql.
                MessageBox.Show(ALERT_EXIST, "ADVERTENCIA", 
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;     // algo salió mal!
            }
            DialogResult dr= MessageBox.Show(ALERT_OK, "Nuevo Ejecutor insertado",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (dr == DialogResult.OK) {
                GotoMain();
            }
        }

        private void GotoMain() {
            this.objFormBuscarEj.Show();
            this.Close();
        }

        private void btCancel_Click(object sender, EventArgs e) {
            GotoMain();
        }
    }

}
