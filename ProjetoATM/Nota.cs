using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoATM
{
    public class Nota
    {
        public decimal valor { get; set; }
        public string moeda { get; set; }

        public Nota(decimal novoValor, string novaMoeda)
        {
            valor = novoValor;
            moeda = novaMoeda;
        }
    }
}
