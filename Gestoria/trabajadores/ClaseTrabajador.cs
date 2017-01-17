using Gestoria.nominas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gestoria.principal;


namespace Gestoria.trabajadores
{
    class ClaseTrabajador
    {
        public string nombre;
        public string apellidos;
        private string _NIF;
        private ClaseNomina[] _nominas;    //nomina del mes.


        //Constructor
        public ClaseTrabajador()
        {
            nombre = null;
            apellidos = null;
            _NIF = null;
            _nominas = null;
        }



        //desarrollo propiedad NIF
        public string NIF
        {
            get
            {
                if (_NIF == null)
                {
                    throw new Exception("NIF no establecido");
                }
                return _NIF;
            }
            set
            {
                string mensaje = "";
                byte tipoerror = 0;
                int digitos = 0;
                if (value.Length != 9)
                {
                    tipoerror = 1;          //Longitud incorrecta
                }
                if (tipoerror == 0)
                {
                    if (Int32.TryParse(value.Substring(0, 8), out digitos))
                    {
                        if (!char.IsLetter(value.ToUpper()[8]))
                        {
                            tipoerror = 2;
                        }
                    }
                    else
                    {
                        tipoerror = 2;
                    }
                }
                if (tipoerror == 0)
                {
                    //Validez dni
                }
                switch (tipoerror)
                {
                    case 1:
                        mensaje = "formato incorrecto";
                        break;

                    case 2:
                        mensaje = "formato incorrecto";
                        break;
                }
                if (tipoerror != 0)
                {
                    throw new Exception("El nif introducido no es válido");
                }
                _NIF = value;
            }
        }
   

        public static byte ComprobarNIF(string nif)
        {
            byte codigoError = 0;
            int digitos = 0;

            if(nif.Length != 9)
            {
                codigoError = 1;            //Longitud incorrecta
            }
            if (codigoError == 0)
            {
                if(Int32.TryParse(nif.Substring(0,8),out digitos))
                {
                    if (!char.IsLetter(nif.ToUpper()[8]))
                    {
                        codigoError = 2;    //formato incorrecto
                    }
                }
                else
                {
                    codigoError = 2;        //formato incorrecto
                }
            }
            if (codigoError == 0)
            {
                //comprobacion validar DNI
            }
            return codigoError;
        }


        public ClaseNomina[] nominas
        {
            get
            {
                if (_nominas == null)
                {
                    throw new Exception("El empleado no tiene nóminas");
                }
                return _nominas;
            }
            set
            {
                
            }
        }


        //Métodos de gestion de estructura de datos
        public static bool AgregarNomina(ClaseNomina []lasNominas, ClaseNomina nomina)
        {
            bool nominaAgregada = false;
            ClaseNomina[] copia = null;

            if (lasNominas == null)
            {
                lasNominas = new ClaseNomina[1];
            }
            else
            {
                if (lasNominas.Length <= 5)
                {
                    copia = new nominas.ClaseNomina[lasNominas.Length];
                    lasNominas.CopyTo(copia, 0);
                    lasNominas = new ClaseNomina[lasNominas.Length + 1];
                    copia.CopyTo(lasNominas, 0);
                    copia = null;
                }
                else
                {
                    throw new Exception("El trabajador tiene ya todas las nóminas del mes");
                }

                lasNominas[lasNominas.Length - 1] = nomina;
                nominaAgregada = true;
            }
            return nominaAgregada;
        }

        
        //Mátodo de eliminación de nómina
        public static bool EliminarNomina(ClaseNomina [] lasNominas, ClaseTrabajador trabajador)
        {
            bool nominaEliminada = false;
            ClaseNomina[] copia = null;
            int contador = 0;
            string nombreIntroducido = null;


            if(lasNominas == null)
            {
                throw new Exception("El trabajador no tiene ninguna nómina");
            }
            else
            {
                nombreIntroducido = InterfazTrabajador.nombreTrabajador();      //Nombre introducido por la interfaz

                if (InterfazTrabajador.comprobarNombre(nombreIntroducido))      //comprobamos el nombre que se introduce por la interfaz de usuario
                {        

                    for(int i=0; i<lasNominas.Length;i++)
                    {
                        if (InterfazNomina.solicitarSalarioBruto().Equals(lasNominas[i].salarioBruto))
                        {
                            copia = new ClaseNomina[lasNominas.Length - 1];

                            for(int j=0; j<lasNominas.Length; j++)
                            {
                                if (!lasNominas[j].salarioBruto.Equals(nombreIntroducido))
                                {
                                    copia[contador] = lasNominas[j];
                                    contador++;
                                }
                            }

                            lasNominas = new ClaseNomina[copia.Length];
                            copia.CopyTo(lasNominas, 0);
                            nominaEliminada = true;
                            copia = null;
                        }
                    }
                }
            }

            return nominaEliminada;
        }


        public static void listarNominas(ClaseNomina [] lista)
        {
            if (lista != null)
            {
                foreach (ClaseNomina nom in lista)
                {
                    InterfazPrincipal.imprimirString("Salario Bruto: " + nom.salarioBruto.ToString());
                }
            }
            
        }


        public static void editarNominas(ClaseNomina nomina)
        {

        }

    }
}
