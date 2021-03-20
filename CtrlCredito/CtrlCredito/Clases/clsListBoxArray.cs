using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * @author: ehermza
 *    date: 04 de diciembre de 2013.
 *    proyecto Agroconnect
 */

namespace CtrldeCredito
{

    public class clsListBoxArray
    {
        private int idClave;        // key numerico
        private string myClave;     // key string
        private string myNombre;    // valor que muestra por listbox.

        public clsListBoxArray(string strLongName, string strClave)
        {
            this.myClave = strClave;
            this.myNombre= strLongName;
        }

        public clsListBoxArray(string strLongName, int idkey)
        {
            this.idClave= idkey;
            this.myNombre = strLongName;
        }

        public string strClave {
            get {
                return myClave;
            }
        }

        public string strNombre {
            get {
                return myNombre;
            }
        }

        public int intClave {
            get
            {
                return this.idClave;
            }
        }

    }
}
