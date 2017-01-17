using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestoria.trabajadores 
{
    static class InterfazTrabajador
    {

        public static void MenuTrabajador()
        {
            Console.Clear();
            Console.WriteLine("------------------Menu trabajador------------");
            Console.WriteLine(" 1. Añadir nómina");
            Console.WriteLine(" 2. Eliminar nómina");
            Console.WriteLine(" 3. Modificar nómina");
            Console.WriteLine(" 4. Listar nóminas");
            Console.WriteLine(" 5. Salir");
        }

        public static string nombreTrabajador()
        {
            string nombre=null;
            Console.WriteLine("Introduce el nombre del trabajador");
            nombre = Console.ReadLine();

            return nombre; 
        }


        public static bool comprobarNombre(string nombre)
        {
            bool ok = true;
            int variable;

            
            for(variable=0; variable<nombre.Length; variable++)
            {
                 if (!Char.IsLetter(nombre[variable]) || nombre.Length ==0)
                 {
                     ok = false;
                 }
            }
            return ok;
        }
    }
}
