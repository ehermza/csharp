using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Collections;
using System.Data;
//using System.Windows.Forms;

/*
 * @author: ehermza
 *    date: 17 de julio de 2014.
 *    proyecto CtrldeCredito -Autolavado.
 */

namespace CtrldeCredito
{
    public class clsMysqlConexion
    {
        // Declaramos las variables:
        public static MySqlConnection MySqlCnn = new MySqlConnection();
        public static MySqlCommand MySqlCmd = new MySqlCommand();
//        public static MySqlDataReader MySqlReader;
        public static string CadenaDeConexion = "Server=localhost;Port=3306;Database=autolavado;Uid=root;Password=";

        public clsMysqlConexion()
        {            
            Conectar();
        }

        static void Conectar()
        {
            try {
                MySqlCnn.ConnectionString = CadenaDeConexion;
            }
            catch (Exception ex) {
                Console.WriteLine(ex);
            }
        }

        public void Desconectar() {
            MySqlCnn.Close();
//            Console.WriteLine("\nConexión finalizada");
        }

        private String getmysqlLugar(bool blterm, bool bladmin)
        {
            if (bladmin == blterm)
                return "";      // admin. optó por no filtrar búsqueda. 
            if (bladmin == true)
                return " AND `id_linea` LIKE '0'";
            return " AND `id_linea` NOT LIKE '0'";
        }
        private DataTable dt;

        public DataTable BuscarActividadTbl(String varnames, String dt_init, String dt_final, String cdgotarjeta, bool blterm, bool bladmin)
        {
            //float totalingr = 0;
            String tl = "SELECT {0} FROM `actividad`";
                tl += " WHERE str_tarea LIKE 'CDT'";        // Actividad requerida: recarga de credito.
                tl += getmysqlLugar(blterm, bladmin);       // filtrar lugar donde se hizo recarga: terminal/ pc admin.
                tl += (cdgotarjeta != "") ? " AND id_tarjeta LIKE '{3}'" : "";
                tl += " AND UNIX_TIMESTAMP(`fechayhora`)";  // rango de fechas. Desde/ Hasta.
                tl += " BETWEEN UNIX_TIMESTAMP('{1} 00:00:00') AND UNIX_TIMESTAMP('{2} 23:59:59')";
                
            String SENTENCIA = String.Format(tl, varnames, dt_init, dt_final, cdgotarjeta);
            //Console.WriteLine(SENTENCIA);
            try
            {
                if (MySqlCnn.State == ConnectionState.Closed){
                    MySqlCnn.Open();
                }
                // Establecemos cuál será la conexión
                MySqlCmd.Connection = MySqlCnn;
                MySqlCmd.CommandText = SENTENCIA;
                MySqlDataAdapter adaptador = new MySqlDataAdapter(MySqlCmd);
                dt = new DataTable();
                adaptador.Fill(dt);
                //dtgv.DataSource = dt;
                MySqlCnn.Close();
            }
            catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }
            return dt;
        }    

        public int Modificar(String tblname, String listvar, String datos, String key, String kvalue)
        {
            try
            {
                // Abrimos la conexión
                if (MySqlCnn.State == ConnectionState.Closed){
                    MySqlCnn.Open();
                }
                // Establecemos cuál será la conexión
                MySqlCmd.Connection = MySqlCnn;
                String strquery = String.Format("UPDATE {0} SET ", tblname);
                String strwhere = String.Format(" WHERE {0}='{1}'", key, kvalue);  // al final
                String[] aListCampos = listvar.Split(',');
                String[] aListDatos = datos.Split(',');
                for (int i = 0; i < aListCampos.Length; i++)
                {
                    String jl= (aListDatos.Length - 1 == i) ? strwhere : ", ";
                    strquery += String.Format("{0}='{1}'{2}", aListCampos[i], aListDatos[i], jl);
                }
                /*
                System.Windows.Forms.MessageBox.Show(strquery, "Sentencia MYSQL");       // quitar!!!
                */
                MySqlCmd.CommandText = strquery;
                int l = MySqlCmd.ExecuteNonQuery();
                MySqlCnn.Close();

                return l;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            return -1;
        }

        public int InsertarDatos(String tblname, String listvar, String datos)
        {
            try {
                // Abrimos la conexión
                if (MySqlCnn.State == ConnectionState.Closed) {
                    MySqlCnn.Open();
                }
                // Establecemos cuál será la conexión
                MySqlCmd.Connection = MySqlCnn;
                String tl = String.Format("INSERT INTO {0}({1}) VALUES({2})", tblname, listvar, datos);
                Console.WriteLine(tl);

                MySqlCmd.CommandText = tl;
                int l= MySqlCmd.ExecuteNonQuery();
                MySqlCnn.Close();

                return l;
            }
            catch (Exception ex){
                Console.WriteLine(ex);
            }

            return -1;
        }


        public int getEjecutor(clsEjecutor objCliente)     // modif. 14/AGO2014
        {
            // Obtiene datos del cliente desde base datos y 
            //  llena atributos del objeto objCliente.
            int fbk = -1;
//            clsEjecutor oEjecutor = null;
            try
            {
                // Abrimos la conexión
                if (MySqlCnn.State == ConnectionState.Closed) {
                    MySqlCnn.Open();
                }
                // Establecemos cuál será la conexión
                MySqlCmd.Connection = MySqlCnn;
                MySqlCmd.CommandText = String.Format("SELECT * FROM `usuario` WHERE `id_tarjeta` LIKE '{0}'", objCliente.Id);
                MySqlDataReader rd= MySqlCmd.ExecuteReader();
                while (rd.Read())
                {
                    fbk += 1;
//                    oEjecutor = new clsEjecutor(username);
                    objCliente.setAtributos(
//                        rd.GetString("id_tarjeta"),
                        rd.GetString("nombre"),
                        rd.GetString("domicilio"),
                        rd.GetString("celular"),
                        rd.GetString("telefono"),
                        rd.GetString("email"),
                        rd.GetString("fbk"),
                        rd.GetString("dni"),
                        rd.GetString("patente"),
                        rd.GetChar("blocked"),
                        rd.GetFloat("saldo_actual")
                    );
                    break;
                }                
                MySqlCnn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            return fbk;

        }

        public string getCoincidencia(String docNumber)
        {       /*      
                 * Verificar si existe en bdts otra tarjeta que haya sido 
                 *  registrada con el dni == docNumber
                 *                                              27ago-2014.*/
            string CdgoTarjeta = "";     
            string SENTENCIA = String.Format("SELECT * FROM usuario WHERE dni LIKE \'{0}\' AND blocked LIKE '0' ", docNumber);
            try
            {
                if (MySqlCnn.State == ConnectionState.Closed)
                {
                    MySqlCnn.Open();
                }
                // Establecemos cuál será la conexión
                MySqlCmd.Connection = MySqlCnn;
                MySqlCmd.CommandText = SENTENCIA;
                MySqlDataReader MySqlReader = MySqlCmd.ExecuteReader();

                while (MySqlReader.Read())
                {
                    CdgoTarjeta += MySqlReader["id_tarjeta"].ToString();
                }
                MySqlCnn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return CdgoTarjeta;
        }

        public String getSentencia(String tblname, String varnames, String[] arraydatos)
        {
            String[] atributos = varnames.Split(',');
//            String[] arraydato = datosTextBox.Split(',');

            String SENTENCIA = String.Format("SELECT {0} FROM `{1}` ", varnames, tblname);
            String jl = "";
            for (int i = 0; i < arraydatos.Length; i++)
            {
                String property= atributos[i];              // nombre atributo de tabla ejecutor
                String strTextBox = arraydatos[i];
                if (strTextBox != "")
                {
                    jl += (jl != "") ? "AND " : "WHERE ";
                    jl += String.Format("{0} LIKE '{1}' ", property, strTextBox);
                }
            }
            SENTENCIA += jl;
            SENTENCIA += (jl == "") ? "WHERE blocked= 0" : "AND blocked= 0";

            return SENTENCIA;
        }
        /*
        public void Buscar(String tblname, String varnames, String[] datosTextBox, System.Windows.Forms.DataGridView dtgv)
        {
            String SENTENCIA= getSentencia(tblname, varnames, datosTextBox);
//            System.Windows.Forms.MessageBox.Show(SENTENCIA, "");
//            return;
            try
            {
                if (MySqlCnn.State == ConnectionState.Closed) {
                    MySqlCnn.Open();
                }
                // Establecemos cuál será la conexión
                MySqlCmd.Connection = MySqlCnn;
                MySqlCmd.CommandText = SENTENCIA;
                MySqlDataAdapter adaptador= new MySqlDataAdapter(MySqlCmd);
                DataTable dt = new DataTable();
                adaptador.Fill(dt);
                dtgv.DataSource = dt;
                MySqlCnn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public ArrayList getDatos(String tblname, String clave, String display)
        {
            //List<string> nombres = new List<string>();
            ArrayList array = new ArrayList();
            // Hacemos una conexión apartir del
            // string CadenaDeConexion antes asignado
            try
            {
                // Abrimos la conexión
                if (MySqlCnn.State == ConnectionState.Closed) {
                    MySqlCnn.Open();
                }
                // Establecemos cuál será la conexión
                MySqlCmd.Connection = MySqlCnn;
                MySqlCmd.CommandText = String.Format("SELECT * FROM {0} ", tblname);
                MySqlDataReader MySqlReader = MySqlCmd.ExecuteReader();

                while (MySqlReader.Read())
                {
                    String idempr = MySqlReader[clave].ToString();
                    String nombre = MySqlReader[display].ToString();
                    array.Add(new clsListBoxArray(nombre, idempr));
                }
                MySqlCnn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return array;
        }
        */

    }
}
