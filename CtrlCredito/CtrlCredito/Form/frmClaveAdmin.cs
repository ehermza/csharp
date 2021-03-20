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
    public partial class frmClaveAdmin : Form
    {
        private frmCliente oFrmCliente;

        public frmClaveAdmin(frmCliente _frmCliente)
        {
            InitializeComponent();
            this.oFrmCliente = _frmCliente;
        }

        private void frmClaveAdmin_Load(object sender, EventArgs e)
        {
            tb_password.PasswordChar = '*';
        }

        private void btOK_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.oFrmCliente.CtrlClaveAdmin(tb_password.Text);
        }
    }
}
