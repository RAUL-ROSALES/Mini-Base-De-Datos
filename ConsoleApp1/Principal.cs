using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Principal
    {
        RegistrarUuario r = new RegistrarUuario();
        public void Bienvenidad()
        {
            Console.WriteLine("Bienvenido a registro de usuarios");
            Menu();
        }
        public void Menu()
        {
            Console.WriteLine("Menu");
            Console.WriteLine("1-.Registrar usuario");
            Opciones();
        }
        public void Opciones()
        {
            Console.WriteLine("Eliga una opcion");
            int opc = Convert.ToInt32(Console.ReadLine());
            switch (opc)
            {
                case 1:
                    r.Registrar();
                    break;
                case 2:
                    break;
            }
        }
    }
}
