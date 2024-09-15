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
           
            string patronCorreo = @"^[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,}$";
            return Regex.IsMatch(correo, patronCorreo);

           
        }

        public static bool validarNickname(string nickname) 
        { 
           return nickname.Length <=15 && nickname == nickname.ToLower();
        }
    }
}
