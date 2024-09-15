using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valida
{
    public class Usuario
    {
        //atributos
        public string correo {  get; set; }
        public string nickname { get; set; }

        //constructor

        public Usuario(string correo,string nickname) 
        { 
            this.correo = correo;
            this.nickname = nickname;   
        
        }

        public bool validarCorreo()
        { 
           return Validacion.validarCorreo(this.correo);
        }

        public bool validarNickname()
        { 
         return Validacion.validarNickname(this.nickname);
        }

    }
}
