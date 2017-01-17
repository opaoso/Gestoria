
using Gestoria.nominas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gestoria.principal;
using Gestoria.empresas;


namespace Gestoria.trabajadores
{
    static class ControladorTrabajador
    {

        public static void controlador()
        {
            bool salir = false;
            byte opcion = 0;
            
            do
            {          
                 InterfazTrabajador.MenuTrabajador();               /**1- Añadir nómina
                                                                     * 2- Eliminar nómina 
                                                                     * 3- Modificar nómina
                                                                     * 4- Listar nóminas
                                                                     * 5- Salir
                                                                     */
                if (InterfazPrincipal.LeerOpcion(ref opcion))       //si opcion es > 0 y <=5, opcionCorrecta=true
                 {  
                    switch (opcion)
                    {
                        case 1:     //metodo de Agregar nomina trabajador
                            //ControladorEmpresa.controlNombreTrabajador();
                            salir = true;
                            break;
                        case 2:     //metodo de eliminar nomina trabajador
                            salir = true;
                            break;
                        case 3:     //metodo de modificar nomina trabajador
                            salir = true;
                            break;
                        case 4:     //metodo de listar nominas del trabajador
                            salir = true;
                            break;
                        case 5:
                            salir = true;
                            break;
                    }
                }

            } while (!salir);
        } 
    }
}
