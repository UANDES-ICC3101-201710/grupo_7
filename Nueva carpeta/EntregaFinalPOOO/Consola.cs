using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntregaFinalPOOO
{

    public static class Consola
    {
        public static string ReadInput(string message)
        {
            Console.Write(message);
            return Console.ReadLine();
        }

        public static void WriteOutput(string message)
        {
            Console.WriteLine(message);
        }
    }

}

