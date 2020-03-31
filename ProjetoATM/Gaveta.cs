using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoATM
{
    public class Gaveta
    {
        private List<Nota> notas;
        public decimal valor { get; set; }

        public Gaveta(decimal novoValor)
        {
            notas = new List<Nota>();
            valor = novoValor;
        }

        public int Quantidade()
        {
            return notas.Count;
        }

        public decimal Valor()
        {
            decimal valorTotal = 0;
            foreach(Nota nota in notas)
            {
                valorTotal += nota.valor;
            }
            return valorTotal;
        }

        public void Retirar()
        {
            if (notas.Count > 0)
                notas.RemoveAt(0);
        }

        public void Incluir(Nota nota)
        {
            notas.Add(nota);
        }

    }
}
