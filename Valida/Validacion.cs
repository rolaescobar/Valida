using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Valida
{
    public class Validacion
    {
       public static bool validarCorreo(string correo)
        {
            //INVESTIGAR  EXPRESION REGULAR PARA VALIDAR CORREOS
            //string patronCorreo = @"Expresion regular para validar correos";
            //return Regex.IsMatch(correo, patronCorreo);

            return true;
        }

        public static bool validarNickname(string nickname) 
        { 
           return nickname.Length <=15 && nickname == nickname.ToLower();
        }
    }
}
