using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gestoria.empresas;
using Gestoria.principal;
using Gestoria.grupoEmpresas;

namespace Gestoria
{
    public class Program
    {
        ClaseEmpresa laEmpresa = new ClaseEmpresa();

        public static void Main(string[] args)
        {                
            ControladorPrincipal.controlador();                     
        }
    }
}
