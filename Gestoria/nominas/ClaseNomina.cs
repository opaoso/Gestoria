using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gestoria.principal;


namespace Gestoria.nominas
{
    public class ClaseNomina
    {
        private float _eurosHora;
        private int _horas;
        private int _horasExtra;
        private float _salarioBase;
        private float _salarioExtra;
        private float _impuestos;


        //Desarrollo de la propiedad _horas
        public int horas
        {
            get
            {
                if (horas == 0)
                {
                    throw new Exception("Horas trabajadas no establecidas");    //si entra en la excepción no se ejecuta el return
                }
                return _horas;
            }
            set
            {
                if (value > 0)
                {
                    _horas = value;
                }
                else
                {
                    //excepcion
                    throw new Exception("Horas incorrectas");
                }
            }
        }

        //Propiedad _eurosHora
        public float eurosHora
        {
            get
            {
                if (_eurosHora == 0)
                {
                    throw new Exception("Euros/hora no establecidos");
                }
                return _eurosHora;
            }
            set
            {
                if (value > 0)
                {
                    _eurosHora = value;
                }
                else
                {
                    throw new Exception("Euros/hora incorrectos");
                }
            }
        }

        //Propiedad _horasExtra
        public int horasExtra
        {
            get
            {
                return _horasExtra;
            }
        }


        //Cálculo del salario Bruto. Cada propiedad se encarga de controlar sus datos
        public void CalcularBruto(int jornada, float incrementoExtra)
        {
            if(jornada <= 0 || incrementoExtra <= 0)                        //controlamos que los argumentos que se introduzcan sean < 0
            {
                throw new Exception("Argumentos incorrectos");
            }

            if (horas > jornada)                                            //utilizamos las propiedades para el control
            {
                _horasExtra = horas - jornada;
                _salarioBase = jornada * eurosHora;
                _salarioExtra = _horasExtra * eurosHora * incrementoExtra;  //horasExtra no está controlado aún
            }
            else
            {
                _salarioBase = horas * horasExtra;
            }
        }


        //Desarrollo de la propiedad _salarioBase
        public float salarioBase
        {
            get
            {
                if (_salarioBase == 0)
                {
                    throw new Exception("Salario base no establecido");
                }
                return _salarioBase;
            }
        }


        //Desarrollo de la propiedad _salarioExtra
        public float salarioExtra
        {
            get
            {
                if (_salarioBase == 0)
                {
                    throw new Exception("Salario base no establecido");
                }
                return _salarioExtra;
            }
        }



        //Creamos la propiedad salarioBruto. Las excepciones se controlan con las propiedades salarioBase y salarioExtra
        public float salarioBruto
        {
            get
            {
                float bruto;
                bruto = salarioBase + salarioExtra;
                return bruto;
            }
        }


        //Función del cálculo de los impuestos que creamos
        public void CalcularImpuestos(float porcentaje)
        {
            if(porcentaje < 0 || porcentaje > 1)      //controlamos que sea positivo el argumento
            {
                throw new Exception("Retención incorrecta");
            }
            _impuestos = salarioBruto * porcentaje;
        }


        //Desarrollo de la propiedad _impuestos y dependiendo de la función CalcularImpuestos
        public float impuestos
        {
            get
            {
                if(_salarioBase == 0)
                {
                    throw new Exception("Salario base no establecido");
                }
                return _impuestos;
            }
        }



        //Función de cálculo del salario neto
        public float SalarioNeto
        {
            get
            {
                return (salarioBruto - impuestos);
            }
        }



        //-----------------------Constructores--------------------------------
        public ClaseNomina(int horasTrabajadas, float eurosH)
        :this(){ 
            horas = horasTrabajadas;                        //aplicamos la propiedad horas para la validación
            eurosHora = eurosH;                             //aplicamos la propiedad eurosHora para la validación
        }


        public ClaseNomina() { }                           //constructor vacío




        public static void listarNominas(ClaseNomina [] nominas)
        {
            foreach(ClaseNomina array in nominas)
            {
                InterfazPrincipal.imprimirString("Número de horas: " + array.horas + " EurosHora: " + array.eurosHora+ "Salario bruto: "+array.salarioBruto);
            }
        }        
    }
}
