using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gestoria.grupoEmpresas;
using Gestoria.empresas;
using Gestoria.trabajadores;
using Gestoria.nominas;

//using Gestoria.Principal;

namespace Gestoria.principal
{
    public static class ControladorPrincipal
    {
        
        public static void controlador()
        {
            ClaseEmpresa[] grupo = null;
            ClaseEmpresa empresa = null;
            ClaseTrabajador[] trabajadores;
            bool salir = false;
            byte opcion = 0;

            do
            {
                InterfazPrincipal.menuPrincipal();                          /** -1 Gestión de Empresas
                                                                             *  -2 Gestión de Trabajadores
                                                                             *  -3 Gestión de Nóminas
                                                                             *  -4 Salir
                                                                             */  

                if(InterfazPrincipal.LeerOpcion(ref opcion))
                {
                    salir = true;

                    switch (opcion)
                    {
                        case 1:
                            ControladorGrupo.controlador(grupo, empresa);
                            break;
                        case 2:
                            ControladorEmpresa.controlador();
                            break;
                        case 3:
                            ControladorTrabajador.controlador();
                            break;
                        
                    }
                }

            } while (!salir);
        }

        
    }
}
