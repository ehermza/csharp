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
    public partial class frmListRecarga : Form
    {  
        private Label lbgral;
        private String dtinicio, dtfinal;
        private String introLabel;
        private frmCalendario ofrmCalendary = null;
        private const string strinit = "Fecha Inicio: ";
        private const string strfinal= "Fecha Final: ";
        private char blPERiOdO;

        public frmListRecarga()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            String strdt = DateTime.Today.ToString("yyyy-MM-dd");

            dtinicio = strdt;
            lbFechaInit.Text = strinit;
            lbFechaInit.Text += CambiarFormato(strdt);

            dtfinal = strdt;
            lbFechaFin.Text = strfinal;
            lbFechaFin.Text += CambiarFormato(strdt);
        }
        private String CambiarFormato(string strfecha)
        {
            String[] l = strfecha.Split('-');
            return
                String.Format("{0}/{1}/{2}", l[2], l[1], l[0]);
        }
        /* 
         * Generar Eventos al elegir fecha en el calendario.
         * */
        private void MC_DateChanged(object sender, System.Windows.Forms.DateRangeEventArgs e)
        {   /* 
             * Mostrar fecha elegida por usuario a traves de un label, en frmCalendario (dd/mm/yyyy)
             * */
            String strdt = (e.Start.ToString("yyyy-MM-dd"));
            lbgral.Text = introLabel;
            lbgral.Text += CambiarFormato(strdt);
            if (blPERiOdO == 'F') {
                dtfinal = (strdt);  // para mysql.
                return;
            }
            dtinicio = (strdt);     // para mysql.
        }

        private void SetEventCalendar(MonthCalendar MC)
        {
            MC.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.MC_DateChanged);
        }
        /* 
         * Evento al presionar btOK de frmCalendario
         * */
        private void CerrarCaldrio(object sender, FormClosingEventArgs e)
        {
            this.ofrmCalendary = null;
        }

        private void MostrarCaldrio()
        {
            if (this.ofrmCalendary != null)
                return;     // salir!

            this.ofrmCalendary = new frmCalendario();
            foreach (Control CTRL in this.ofrmCalendary.Controls)
            {
                if (CTRL is MonthCalendar) {
                    SetEventCalendar((MonthCalendar)CTRL);
                }
            }
            // Al cerrar calendario se pierde referencia -> this.ofrmCalendary = null;
            this.ofrmCalendary.FormClosing +=
                new System.Windows.Forms.FormClosingEventHandler(this.CerrarCaldrio);

            this.ofrmCalendary.Show();
        }

        private void btCalendarFin_Click(object sender, EventArgs e)
        {
            lbgral = lbFechaFin;    
            introLabel = strfinal;
            blPERiOdO = 'F';
            MostrarCaldrio();
        }

        private void btCalendarInit_Click(object sender, EventArgs e)
        {
            lbgral = lbFechaInit;
            introLabel = strinit;
            blPERiOdO = 'i';
            MostrarCaldrio();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
//        private clsMysqlConexion objmysql;

        private void btBuscar_Click(object sender, EventArgs e)
        {
            clsMysqlConexion objmysql = new clsMysqlConexion();
            String atributos = "fechayhora,id_linea,id_tarjeta,credito";
            String cdgo_t = (CBOX1.Checked) ? tbcdgo.Text : "";
            DataTable dt = objmysql.BuscarActividadTbl(atributos, dtinicio, dtfinal, cdgo_t, rbt1.Checked, rbt2.Checked);

            DataRow[] dr = dt.Select();
            decimal fltTotal = 0;
            for (int i = 0; i < dr.Length; i++)
            {
                fltTotal+= Convert.ToDecimal(dr[i]["credito"]);
            }
            TBOX1.Text = fltTotal.ToString();

            dtgv.DataSource = dt;
        }

        private void CBOX1_CheckedChanged(object sender, EventArgs e)
        {
            tbcdgo.Enabled = (CBOX1.Checked);
        }

    }
}
