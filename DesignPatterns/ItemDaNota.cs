using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class ItemDaNota
    {
        public ItemDaNota(string nome, double valor)
        {
            Nome = nome;
            Valor = valor;
        }

        public string Nome { get; private set; }
        public double Valor { get; private set; }


    }
}
