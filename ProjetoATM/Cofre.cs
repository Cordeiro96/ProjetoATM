using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoATM
{
    public class Cofre
    {
        private List<Gaveta> gavetas;

        public Cofre()
        {
            gavetas = new List<Gaveta>();
            gavetas.Add(new Gaveta(100));
            gavetas.Add(new Gaveta(50));
            gavetas.Add(new Gaveta(25));
            gavetas.Add(new Gaveta(10));
            gavetas.Add(new Gaveta(5));
            gavetas.Add(new Gaveta(2));
        }

        private Gaveta BuscaGaveta(decimal valor)
        {
            foreach(Gaveta gaveta in gavetas)
            {
                if (gaveta.valor == valor)
                    return gaveta;
            }
            return null;
        }

        public void Retirar(Nota nota)
        {
            Gaveta gaveta = BuscaGaveta(nota.valor);
            if (gaveta != null)
            {
                gaveta.Retirar();
            }
        }

        public void Incluir(Nota nota)
        {
            Gaveta gaveta = BuscaGaveta(nota.valor);
            if (gaveta != null)
            {
                gaveta.Incluir(nota);
            }
        }

        public int QuantidadeGaveta(decimal valor)
        {
            Gaveta gaveta = BuscaGaveta(valor);
            if (gaveta != null)
                return gaveta.Quantidade();
            return 0;
        }

        public decimal ValorGaveta(decimal valor)
        {
            Gaveta gaveta = BuscaGaveta(valor);
            if (gaveta != null)
                return gaveta.Valor();
            return 0;
        }
    }
}
