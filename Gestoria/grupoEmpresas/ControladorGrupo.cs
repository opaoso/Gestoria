using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gestoria.empresas;
using Gestoria.principal;

namespace Gestoria.grupoEmpresas
{
    class ControladorGrupo
    {    

        public static void controlador(ClaseEmpresa[] grupo, ClaseEmpresa empresa)
        {
            empresa=null;
            grupo=null;
            bool salir = false;
            byte opcion = 0;
            string nombre = null;

            do
            {

                InterfazGrupo.MenuGrupo();                      /** -1 Nueva empresa
                                                                 *  -2 Consulta empresa
                                                                 *  -3 Listado empresas
                                                                 *  -4 Borrado empresa
                                                                 *  -5 Salir
                                                                 */
                if (InterfazPrincipal.LeerOpcion(ref opcion))
                {
                    

                    switch (opcion)
                    {
                        case 1:

                            
                                InterfazGrupo.nombreEmpresa(ref empresa);
                                if (grupo == null)                                      //en el caso de que no haya empresas
                                {
                                    if (ClaseGrupo.agregarEmpresa(ref grupo, ref empresa))
                                    {
                                        InterfazGrupo.empresaAñadida();
                                    }

                                    ControladorEmpresa.controlador();
                                }
                                else
                                {
                                    if (comprobarQueNoExista(grupo, nombre))        //si hay empresas ya creadas comprobaremos que no exista ninguna con el mismo nombre
                                    {
                                        ClaseGrupo.agregarEmpresa(ref grupo, ref empresa);   //en caso de que no exista la empresa, la añadimos al array de empresas
                                    }
                                    else
                                    {
                                        throw new Exception("La empresa ya existe");
                                    }
                                }

                            
                            break;
                        case 2:

                            break;
                        case 3:
                            ClaseGrupo.listadoEmpresas(ref grupo);
                            break;
                        case 4:
                            
                            break;
                        case 5:
                            salir = true;
                            break;
                    }
                }
            } while (!salir);
        }



        //función que comprueba que no exista una empresa en el array de empresas con el nombre indicado
        public static bool comprobarQueNoExista(ClaseEmpresa [] grupo, string nombre)
        {
            bool noExiste = false;

            foreach(ClaseEmpresa intro in grupo)
            {
                if (intro.nombreEmpresa != nombre)
                {
                    noExiste = true;
                }
            }

            return noExiste;
        }
                
    }
}
