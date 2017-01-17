using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gestoria.principal;
using Gestoria.trabajadores;

namespace Gestoria.empresas
{
    public class ControladorEmpresa
    {
        

        public static void controlador()
        {
            ClaseTrabajador[] plantilla = null;
            ClaseTrabajador trabajador = new ClaseTrabajador();
            string nombre = null;
            bool salir = false;
            byte opcion = 0;                        //va a contener el número de opción del menú elegido
            
            do
            {
                InterfazEmpresa.menuEmpresa();

                if (InterfazPrincipal.LeerOpcion(ref opcion))
                {
                    switch (opcion)
                    {
                        case 1:     //metodo de Agregar trabajador
                            if(controlNombreTrabajador(out nombre))
                            {
                                //ClaseEmpresa.agregarTrabajador(int posicionLista);
                            }

                            break;
                        case 2:     //metodo de eliminar trabajador
                            ClaseEmpresa.eliminarTrabajador(trabajador);
                            break;
                        case 3:     //metodo de modificar trabajador
                            ClaseEmpresa.listarTrabajadores(plantilla);                          
                            break;
                        case 4:     //metodo de listar trabajadores
                            ClaseEmpresa.editarTrabajador(trabajador);
                            break;
                        case 5:
                            salir = true;
                            break;
                    }
                }
                 
            } while (!salir);
        }


        public static bool controlNombreTrabajador(out string nombre)
        {
            bool verificador = false;
            string elNombre=null;
            nombre = null;
            
            do
            {
                InterfazEmpresa.introducirNombreTrabajador();

                if (InterfazEmpresa.compruebaNombre(ref elNombre))
                {
                    nombre = elNombre;
                    verificador = true;
                }

            } while (!verificador);
            return verificador;
        }
    
    }
}
