using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gestoria.grupoEmpresas;

namespace Gestoria.principal
{
    class InterfazPrincipal
    {
        public static void menuPrincipal()
        {
            Console.WriteLine("******************Gestoría******************");  
            Console.WriteLine(" 1-Gestión de Empresas.\n 2-Gestión de Trabajadores.\n 3-Gestión de Nóminas.\n 4-Salir.");
        }

        
        public static bool LeerOpcion(ref byte opcion)              //opcion es el número elegido por teclado
        {
            bool esCorrecto = false;
            string aux;

            aux = Console.ReadLine();
            if (Byte.TryParse(aux, out opcion))
            {
                if (opcion > 0 && opcion <= 5)
                {
                    esCorrecto = true;
                }
            }
            return esCorrecto;
        }
        
        
        public static void imprimirString(string nom)
        {
            Console.WriteLine(nom);
        } 
        
    }
}
