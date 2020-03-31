using System;

namespace ProjetoATM
{
    class Program
    {
        static void Main(string[] args)
        {
            Cofre cofre = new Cofre();

            cofre.Incluir(new Nota(100, "Dolar"));
            cofre.Incluir(new Nota(100, "Dolar"));

            cofre.Incluir(new Nota(50, "Dolar"));
            cofre.Incluir(new Nota(50, "Dolar"));

            cofre.Incluir(new Nota(10, "Dolar"));
            cofre.Incluir(new Nota(10, "Dolar"));
            cofre.Incluir(new Nota(10, "Dolar"));

            cofre.Incluir(new Nota(5, "Dolar"));
            cofre.Incluir(new Nota(5, "Dolar"));

            Console.WriteLine("Quantidade: ");
            Console.WriteLine(cofre.QuantidadeGaveta(10));
            Console.WriteLine("Valor: ");
            Console.WriteLine(cofre.ValorGaveta(10));

            cofre.Retirar(new Nota(10, "Dolar"));
            cofre.Retirar(new Nota(10, "Dolar"));
            cofre.Retirar(new Nota(10, "Dolar"));
            cofre.Retirar(new Nota(10, "Dolar"));
            cofre.Retirar(new Nota(10, "Dolar"));

            Console.WriteLine("Nova Quantidade: ");
            Console.WriteLine(cofre.QuantidadeGaveta(10));

            cofre.Incluir(new Nota(10, "Dolar"));
            cofre.Incluir(new Nota(10, "Dolar"));
            cofre.Incluir(new Nota(10, "Dolar"));
            cofre.Incluir(new Nota(10, "Dolar"));

            Console.WriteLine("Nova Quantidade 2: ");
            Console.WriteLine(cofre.QuantidadeGaveta(10));
            Console.WriteLine("Novo Valor 2: ");
            Console.WriteLine(cofre.ValorGaveta(10));
        }
    }
}
