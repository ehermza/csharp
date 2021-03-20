using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

/*
 * @author: ehermza
 *    date: 25 de julio de 2014.-
 *    proyecto CtrldeCredito -Autolavado.
 */

namespace CtrldeCredito
{
    public class clsVerifCampos
    {

        public clsVerifCampos()
        {
        }

        public String RevCtresNumber(String texto)
        {
            if ("".Equals(texto)) 
                return "";

            return (new Regex(@"^[0-9]+$").IsMatch(texto)) ? "" : "Sólo caracteres numéricos.";
        }

        public String RevDocNumber(String texto)
        {
            if ("".Equals(texto)) 
                return "[obligatorio] Debe ingresar N° Documento.";

            return (new Regex(@"^[0-9]+$").IsMatch(texto)) ? "" : "Sólo caracteres numéricos.";
        }

        public String RevisarCorreo(String str_email)
        {
            if ("".Equals(str_email))  
                    return "";

            Regex regex = new Regex(@"^(?("")(""[^""]+?""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9]{2,17}))$");

            return regex.IsMatch(str_email) ? "" : "E-mail inválido.";
        }

        public String RevisarPatente(String patente)
        {
            if ("".Equals(patente)) 
                return "";

            Regex regex = new Regex(@"^[A-Z]{3}[0-9]{3}$");

            return regex.IsMatch(patente) ? "" : "Patente inválida. Ej: ABC123";
            
        }

        public String RevCtresNombre(string texto)
        {
            if ("".Equals(texto))
            {
                return "[obligatorio] Debe ingresar Apellido y Nombre del Cliente.";
            }
            Regex regex = new Regex(@"^[^ ][a-zA-Z ]+[^ ]$");

            return (regex.IsMatch(texto))? "": "Prohibido ingresar números y/o caracteres especiales.";
        }

    }
}
