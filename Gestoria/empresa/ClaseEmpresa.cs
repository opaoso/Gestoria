using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gestoria.trabajadores;
using Gestoria.principal;

namespace Gestoria.empresas
{
    class ClaseEmpresa
    {
        public string nombreEmpresa;
        private ClaseTrabajador[] _plantilla;


        public ClaseEmpresa()                  //constructor
        {
            plantilla = null;
        }


        //desarrollo de la propiedad _plantilla
        public ClaseTrabajador [] plantilla
        {
            get
            {
                if(_plantilla == null)
                {
                    throw new Exception("La empresa no tiene trabajadores");
                }
                return _plantilla;
            }
            set
            {

            }
        }
  

        //Función de agregar trabajadores
        public static bool agregarTrabajador(int posicionLista)
        {
            bool trabajadorAgregado = false;


            return trabajadorAgregado;
        }

        public static void editarTrabajador(ClaseTrabajador trabajador)
        {
            
        }


        public static bool eliminarTrabajador(ClaseTrabajador trabajador)
        {
            bool trabajadorEliminado = false;

            return trabajadorEliminado;
        }


        public static void listarTrabajadores(ClaseTrabajador[] plantilla)
        {
            foreach(ClaseTrabajador array in plantilla)
            {
                InterfazPrincipal.imprimirString("Nombre: " + array.nombre + " Apellidos: " + array.apellidos + array);
            }

        }
    }
}
