using Tabuleiro;
using xadrez;

namespace ChessSharp
{
    class Program
    {
        private static void Main(string[] args)
        {
            TabuleiroJogo tab = new TabuleiroJogo(8, 8);

            tab.ColocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
            tab.ColocarPeca(new Torre(tab, Cor.Preta), new Posicao(1, 3));
            tab.ColocarPeca(new Rei(tab, Cor.Preta), new Posicao(2, 4));


            Tela.ImprimirTabuleiro(tab);


            Console.ReadLine();
        }
    }
}