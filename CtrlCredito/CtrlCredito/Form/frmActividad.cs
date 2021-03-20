using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CtrldeCredito
{
    public partial class frmActividad : Form
    {
        private clsActividad ObjActividad;

        public frmActividad()
        {
            InitializeComponent();
        }

        public void SetClase(clsActividad _clase)
        {
            ObjActividad = _clase;
        }

        private string getRbtnValor()
        {
            foreach (Control octrl in this.Controls)
            {
                if (octrl is RadioButton) {
                    RadioButton rdbtn = octrl as RadioButton;
                    if (rdbtn.Checked) {
                        return (rdbtn.Name).ToString();
                    }
                }
            }
            return "";
        }

        private void btOK_Click(object sender, EventArgs e)
        {
            if (lbId_tarjeta.SelectedItem == null) {
                MessageBox.Show("Ingresar Tarjeta");
                return; // salir!
            }
            ObjActividad.setAtributos(
                lbId_tarjeta.SelectedItem.ToString(),
                getRbtnValor(), 
                Convert.ToInt16(lbLinea.Value), 
                lbMinutos.Value
            );
            ObjActividad.InsertToDataBase();

        }

    }
}
