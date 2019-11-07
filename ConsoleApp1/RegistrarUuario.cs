using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
namespace ConsoleApp1
{
    public class RegistrarUuario
    {
        Usuarios u = new Usuarios();
        public void Registrar()
        {
            StreamWriter archivo = File.AppendText("archivo.txt");
            Console.WriteLine("Ingrese el Nombre");
            u.Nombre = Console.ReadLine();
            Console.WriteLine("Ingrese el UserName");
            u.UserName = Console.ReadLine();
            Console.WriteLine("Ingrese su contraseña");
            u.Contraseña = Console.ReadLine();
            string usuariox = u.Nombre + ","+ u.UserName +","+ u.Contraseña;
            string mensaje = usuariox;
            archivo.WriteLine(mensaje);
            archivo.Close();
            Console.WriteLine("Usuario registraddo exitosamente");
        }
    }
}
