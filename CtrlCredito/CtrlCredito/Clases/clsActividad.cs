using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CtrldeCredito
{
    public class clsActividad
    {
        private frmActividad FORM;
        private clsMysqlConexion obj_mysql = new clsMysqlConexion();

//        private long TimeStamp;
        private string fechayhora;  // format(yy/MM/dd HH:mm:ss)
        private string idtarjeta;   // CdgoTarjeta 
        private string tarea;       // rbCDR (caldera)
        private int idlinea;        // 1,2,3,4...
        private int sgdos;          // tiempo que dura una actividad.
        private float debito;       // $ se descuenta cdo ejerce actividad.
        private float credito;      // $ cuando cliente hace recarga de tarj.

        public clsActividad()
        {
            FORM = new frmActividad();
            FORM.SetClase(this);
            FORM.Show();
        }

        public void setAtributos(string _tarjeta, string _tarea, int _linea, decimal _minutos, float dbto=0, float cdto=0)
        {
//            DateTime dt = DateTime.Now;

            this.fechayhora = DateTime.Now.ToString(@"yy/MM/dd HH:mm:ss");
            this.idtarjeta  = _tarjeta;
            this.tarea      = _tarea;
            this.idlinea    = _linea;
            this.sgdos      = Convert.ToInt16(_minutos* 60);  
            this.debito     = dbto;
            this.credito    = cdto;
        }

        public int InsertToDataBase()
        {
            String dts_formulario =
                String.Format("\"{0}\",\"{1}\",{2},\"{3}\", {4}, {5}, {6}",
                    this.fechayhora, this.tarea, this.idlinea, this.idtarjeta, this.sgdos, this.debito, this.credito);
//            Console.WriteLine(dt_myformat);
            string listvar = "fechayhora, str_tarea, id_linea, id_tarjeta, int_sgdos, debito, credito";
            return
                obj_mysql.InsertarDatos("actividad", listvar, dts_formulario);
        }

        public void SetCdgoTarjeta(string cdgo)
        {
            Console.WriteLine(cdgo);
        }
    }
}
