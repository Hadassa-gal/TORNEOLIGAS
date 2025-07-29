using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ui;
namespace Helpers
{
    public class Validacion
    {
        public static byte ValiByte()
        {
            byte op = 0;
            if (!byte.TryParse(Console.ReadLine(), out op))
            {
                Acceptordeny.MostrarError("El valor ingresado debe ser un numero valido");
            }
            return op;
        }
    }
    
}