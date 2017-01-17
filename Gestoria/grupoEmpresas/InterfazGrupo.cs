using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gestoria.empresas;


namespace Gestoria.grupoEmpresas
{
    class InterfazGrupo
    {
        

        public static void MenuGrupo()
        {
            //Console.Clear();
            Console.WriteLine("************Menú de Grupo de empresas*************");
            Console.WriteLine(" 1-Nueva Empresa.\n 2-Consulta Empresa.\n 3-Listado Empresas.\n 4-Borrar Empresa.\n 5-Salir");          
        }


        public static string nombreEmpresa(ref ClaseEmpresa empresa)
        {
            string entrada;
            bool ok = false;
            empresa = new ClaseEmpresa();
            empresa.nombreEmpresa=null;

            Console.Clear();
            Console.WriteLine("Introduce el nombre de la empresa");
            entrada=Console.ReadLine();

            if(entrada.Length>=2 && entrada.Length <= 30)
            {
                empresa.nombreEmpresa = entrada;
                ok = true;
            }
            return empresa.nombreEmpresa;       
        }



        public static void empresaAñadida()
        {
            Console.WriteLine("La empresa se ha añadido correctamente");
        }
   
    }
}
