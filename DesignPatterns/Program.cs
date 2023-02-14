using System;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            NotaFiscal nf = new NotaFiscalBuilder()
                .ParaEmpresa("Teste e testa")
                .ComCnpj("20.000.000/0001-20")
                .Com(new ItemDaNota("item 1", 100.0))
                .Com(new ItemDaNota("item 2", 200.0))
                .NaDataAtual()
                .ComObservacoes("Testando uma observação na NF'e")
                .AdicionaAcao(new EnviadorDeEmail())
                .AdicionaAcao(new NotaFiscalDao())
                .AdicionaAcao(new EnviadorDeEmail())
                .AdicionaAcao(new Multiplicador(10))
                .Constroi();

            Console.WriteLine(nf.ValorBruto);
            Console.WriteLine(nf.Impostos);
            Console.WriteLine(nf.DataDeEmissao);
            Console.ReadKey();
        }
    }
}
