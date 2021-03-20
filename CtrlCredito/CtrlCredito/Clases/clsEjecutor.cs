using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
//using System.Text.RegularExpressions;


/*
 * @author: ehermza
 *    date: 17 de julio de 2014.
 *    proyecto CtrldeCredito -Autolavado
 */

namespace CtrldeCredito
{
    public class clsEjecutor 
    {
        private clsMysqlConexion objmysql = new clsMysqlConexion();

        private string CdgoTarjeta;
        private string nombre;
        private string domicilio;
        private string celular;
        private string telefono;
        private string email;
        private string fbk_uname;
        private string documento;
        private string patente;
        private char blocked;
        private float saldo_actual;
        private bool blCteExiste;

        public clsEjecutor(String _idt)
        {
            this.CdgoTarjeta = _idt;
        }

        public void SetDtsBaseDatos()
        {
            // Llenar this con datos obtenidos de mysql, si no esta registrado: return -1;
            this.blCteExiste = (objmysql.getEjecutor(this) != -1);
        }

        public void setAtributos(
            String _nombre, String _domicilio, String _cel, String _telef,  String _email, String _fbk, String _dni, String _pte, char _blBlock, float _saldo)
        {
//            this.CdgoTarjeta= _idt;
            this.nombre     = _nombre;
            this.domicilio  = _domicilio;
            this.celular    = _cel;
            this.telefono   = _telef;
            this.email      = _email;
            this.fbk_uname  = _fbk;
            this.documento  = _dni;
            this.patente    = _pte;
            this.blocked    = _blBlock;
            this.saldo_actual = _saldo;
        }

        public int Modificar()
        {
            String listvar = "id_tarjeta,nombre,domicilio,celular,telefono,email,fbk";  // valores modificar desde formulario.-
            String valores = String.Format(
                "{0},{1},{2},{3},{4},{5},{6}",
                this.CdgoTarjeta,    // {0}
                this.nombre,        // {1}
                this.domicilio,     // {2}
                this.celular,       // {3}
                this.telefono,      // {4}
                this.email,         // {5}
                this.fbk_uname
                );
            return objmysql.Modificar("Usuario", listvar, valores, "id_tarjeta", this.CdgoTarjeta);
        }
/*
        public int Eliminar()
        {
            return objmysql.OcultarObj("Usuario", "id_tarjeta", this.CdgoTarjeta);
        }
        */
        public int Insertar(string StrSaldo)
        {
            String listvar = "id_tarjeta,nombre,domicilio,celular,telefono,email,fbk,dni,patente,blocked,saldo_actual";
            String valores = String.Format(
                "\"{0}\",\"{1}\",\"{2}\",\"{3}\",\"{4}\",\"{5}\",\"{6}\",\"{7}\",\"{8}\", 0, \"{9}\"",
                this.CdgoTarjeta,    // {0}
                this.nombre,        // {1}
                this.domicilio,     // {2}
                this.celular,       // {3}
                this.telefono,      // {4}
                this.email,         // {5}
                this.fbk_uname,     // {6}
                this.documento,     // {7}  no puede modificar.
                this.patente,       // {8}  no puede modificar.
                StrSaldo
//                this.blocked,       
//                this.saldo_actual   // {9}  no puede modificar.

                );

            return objmysql.InsertarDatos("Usuario", listvar, valores);
        }

        public void BlockTarjeta()
        {
            string listvar= "blocked,saldo_actual";
            string dts = "b,0.00";
            objmysql.Modificar("usuario", listvar, dts, "id_tarjeta", this.CdgoTarjeta);
        }
//        private string fechayhora;  // format(yy/MM/dd HH:mm:ss)

        public float setCredito(float cdto_pesos)   // from frmAddCredito:InsertarCredito(float, clsEjecutor)
        {
            float sldo = this.Saldo + cdto_pesos;

//            objmysql.setCredito(sldo, this.id_tarjeta);

            clsActividad oActividad = new clsActividad();
            oActividad.setAtributos(this.CdgoTarjeta, "CDT", 0, 0, 0, cdto_pesos);

            oActividad.InsertToDataBase();

            objmysql.Modificar("usuario", "saldo_actual", sldo.ToString(), "id_tarjeta", this.CdgoTarjeta);            
//            objmysql.InsertarDatos("actividad", "", "");

            return sldo;
        }

        public string getCoincidencia()     // from frmCliente.DarAltaTarjeta()
        {
            return
                objmysql.getCoincidencia(this.documento);
        }

        public string Id
        {
            get { return this.CdgoTarjeta; }
        }
        public string Nombre
        {
            get { return this.nombre; }
        }

        public string Domicilio
        {
            get { return this.domicilio; }
        }
        public string Celular
        {
            get { return this.celular; }
        }
        public string Telefono
        {
            get { return this.telefono; }
        }
        public string Email
        {
            get { return this.email; }
        }
        public string Fbk
        {
            get { return this.fbk_uname; }
        }
        public string DNI
        {
            get { return this.documento; }
        }
        public string Patente
        {
            get { return this.patente; }
        }
        public float Saldo
        {
            get { return this.saldo_actual; }
        }
        public bool getExisteCte()
        {
            return this.blCteExiste; 
        }

    }
}

