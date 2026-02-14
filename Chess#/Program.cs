using Tabuleiro;


namespace ChessSharp
{
    class Program
    {
        private static void Main(string[] args)
        {
            TabuleiroJogo tab = new TabuleiroJogo(8, 8);

            Tela.ImprimirTabuleiro(tab);


            Console.ReadLine();
        }
    }
}