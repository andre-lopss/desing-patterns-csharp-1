using System;

namespace DesignPatterns
{
    public class NotaFiscalDao : IAcaoAposGerarNota
    {
        public void Executa(NotaFiscal nf)
        {
            Console.WriteLine("Simulando envio de SMS...");
        }
    }
}
