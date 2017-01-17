using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestoria.empresas
{
    class InterfazEmpresa
    {

        public static void introducirNombreTrabajador()
        {
            Console.Clear();
            Console.WriteLine("Introduce el nombre del trabajador");
        }

        //Función que nos devuelve si se cumle que el nombre esté comprendido entre 2 y 20 caracteres
        public static bool compruebaNombre(ref string nombre)
        {
            bool esCorrecto = false;
            string aux;

            aux = Console.ReadLine();
            if (aux.Length >= 2 && aux.Length <= 20)
            {
                aux = nombre;
                esCorrecto = true;
            }

            return esCorrecto;
        }


        public static void menuEmpresa()
        {
            //Console.Clear();
            Console.WriteLine("-----------------Menú Empresa-------------------");
            Console.WriteLine(" 1. Añadir trabajador");
            Console.WriteLine(" 2. Eliminar trabajador");
            Console.WriteLine(" 3. Modificar trabajador");
            Console.WriteLine(" 4. Listar trabajadores");
            Console.WriteLine(" 5. Salir"); 
        }

        

    }
}
