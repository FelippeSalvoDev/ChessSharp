using Tabuleiro;

namespace ChessSharp
{
    class Program
    {
        private static void Main(string[] args)
        {
            TabuleiroJogo tab = new TabuleiroJogo(8, 8);

            tab.ColocarPeca("T", new Posicao(0, 0));
            tab.ColocarPeca("T", new Posicao(1, 3));
            tab.ColocarPeca("T", new Posicao(2, 4));


            Tela.ImprimirTabuleiro(tab);


            Console.ReadLine();
        }
    }
}