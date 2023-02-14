using System;

namespace DesignPatterns
{
    public class EnviadorDeSms : IAcaoAposGerarNota
    {
        public void Executa(NotaFiscal nf)
        {
            Console.WriteLine("Simulando salvamento no BD...");
        }
    }
}
