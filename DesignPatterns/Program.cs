using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            IImposto iss = new ISS();
            IImposto icms = new ICMS();
            IImposto iccc = new ICCC();

            Orcamento orcamento = new Orcamento(3000.0);

            CalculadorDeImpostos calculador = new CalculadorDeImpostos();
            //calculador.RealizarCalculo(orcamento, iss);
            //calculador.RealizarCalculo(orcamento, icms);
            calculador.RealizarCalculo(orcamento, iccc);

            Console.ReadKey();
        }
    }
}
