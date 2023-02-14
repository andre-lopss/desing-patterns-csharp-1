using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class Multiplicador : IAcaoAposGerarNota
    {
        public double Fator { get; private set; }

        public Multiplicador(double fator)
        {
            Fator = fator;
        }

        public void Executa(NotaFiscal nf)
        {
            Console.WriteLine(nf.ValorBruto * Fator);
        }
    }
}
