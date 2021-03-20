using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * @author: ehermza
 *    date: 29ago-2014
 *    proyecto CtrldeCredito -Autolavado
 */

namespace CtrldeCredito
{
    public partial class frmCalendario : Form
    {

        public frmCalendario()
        {
            InitializeComponent();

            this.MyCalendario.MaxSelectionCount = 1;
            this.MyCalendario.ShowToday = false;
        }
        private void monthCalendar1_DateSelected(object sender, System.Windows.Forms.DateRangeEventArgs e)
        {
        }

        private void monthCalendar1_DateChanged(object sender, System.Windows.Forms.DateRangeEventArgs e)
        {
            // Show the start and end dates in the text box. 
        }

        private void btOK_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
