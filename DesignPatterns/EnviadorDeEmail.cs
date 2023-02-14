using System;

namespace DesignPatterns
{
    public class EnviadorDeEmail : IAcaoAposGerarNota
    {
        public void Executa(NotaFiscal nf)
        {
            Console.WriteLine("Simulando envio de email...");
        }
    }
}
