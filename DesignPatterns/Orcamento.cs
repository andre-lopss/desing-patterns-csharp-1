﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class Orcamento
    {
        public IList<Item> Itens { get; private set; }
        public double Valor { get; private set; }

        public Orcamento(double valor)
        {
            Valor = valor;
            this.Itens = new List<Item>();
        }

        public void AdicionaItem(Item item)
        {
            Itens.Add(item);
        }
    }
}
