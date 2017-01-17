using Gestoria.empresas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gestoria.principal;
using Gestoria.trabajadores;

namespace Gestoria.grupoEmpresas
{

    class ClaseGrupo
    {

        public static bool agregarEmpresa(ref ClaseEmpresa[]grupo, ref ClaseEmpresa empresa)
        {
            bool empresaIntroducida = false;
            ClaseEmpresa[] copia = null;

            if (grupo == null)
            {
                grupo = new ClaseEmpresa[1];
                empresaIntroducida = true;
            }
            else
            {
                copia = new ClaseEmpresa[grupo.Length];
                grupo.CopyTo(copia, 0);
                grupo = new ClaseEmpresa[grupo.Length + 1];
                copia.CopyTo(grupo, 0);
                copia = null;

               
                empresaIntroducida = true;
            }

            grupo[grupo.Length - 1] = empresa;

            return empresaIntroducida;
        }




        public static void consultarEmpresa(ClaseEmpresa [] empresas, ClaseEmpresa empresa)
        {
            if (empresas != null)
            {
                foreach(ClaseEmpresa nombre in empresas)
                {
                    if (nombre.nombreEmpresa  == empresa.nombreEmpresa)
                    {
                        foreach(ClaseTrabajador array in empresa.plantilla)
                        {
                            
                        }
                    }
                }
            }

        }


        public static void listadoEmpresas(ref ClaseEmpresa[] empresas)
        {

            if (empresas != null)
            {
                foreach (ClaseEmpresa emp in empresas)
                {
                    InterfazPrincipal.imprimirString(emp.nombreEmpresa);
                }
            }
            else
            {
                throw new Exception("No hay empresas en la gestoría");
            }
            

        }



        public static bool borrarEmpresa(ref ClaseEmpresa []empresas, string nombreEmpresa)
        {
            bool borrado = false;

            return borrado;
        }
    }
}
