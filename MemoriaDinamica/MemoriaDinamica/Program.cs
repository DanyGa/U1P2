using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoriaDinamica
{
    class Program
    {
      
        static void Main(string[] args)
        {
            Console.Write("Introduzca un Numero Entero: ");
            int numero = Int32.Parse(Console.ReadLine());

            Program p = new Program();

            Console.Write("\nNumero Entero: {0}, en Codigo Binario: ", numero);
            p.imprime_binario(numero);

            Console.ReadLine();
        }
        void imprime_binario(int n)
        {
            if (n >= 2)
            {
                imprime_binario(n / 2);
                Console.Write("{0}", n % 2);
            }
            else
            {
                Console.Write("{0}", n);
            }
        }
    }
}
