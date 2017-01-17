using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestoria.nominas
{
    class InterfazNomina
    {
        public static int solicitaHoras()
        {
            string entrada=null;
            int salida=0;

            Console.Write("Ingresa las horas trabajadas");
            entrada = Console.ReadLine();

            Int32.TryParse(entrada, out salida);

            return salida;
            
        }


        public static void solicitaEurosHora()
        {

        }

        public static string solicitarSalarioBruto()
        {
            string salario=null;

            Console.WriteLine("Introduce salario bruto");
            salario=Console.ReadLine();

            return salario;
        }
    }
}
