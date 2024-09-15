
using Valida;

Console.WriteLine("*****************************************");
Console.WriteLine("****** INGRESAR CORREO ELECTRONICO ******");
string correo = Console.ReadLine();

Console.WriteLine("******************************************");
Console.WriteLine("****** INGRESE SU NICKNAME ******");
string nickname = Console.ReadLine();

Usuario usuario = new Usuario(correo,nickname);

// validacion de correo
    if (usuario.validarCorreo())
    {
        Console.WriteLine("CORREO  VALIDO");
    }
    else
    {

        Console.WriteLine("CORREO NO VALIDO");
    }

//validacion de  nickname
    if (usuario.validarNickname())
    {

        Console.WriteLine("NICKNAME  VALIDO.");
    }
    else
    { 
     Console.WriteLine("NICKNAME NO VALIDO. DEBE TENER MENOS DE 15 CARACTERES Y ESTAR EN MINUSCULAS");

    }


