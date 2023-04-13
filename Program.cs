using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista1ex11
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double expoente;
            double basee;
            double resultado;
            
            Console.WriteLine("digite o valor da base");
            basee = double.Parse(Console.ReadLine());

            Console.WriteLine("digite o valor do expoente");
            expoente = double.Parse(Console.ReadLine());

            resultado = Math.Pow(basee,expoente) ;


            Console.WriteLine("resultado é: "+resultado);

        }
    }
}
