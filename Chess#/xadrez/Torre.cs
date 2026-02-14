using Tabuleiro;

namespace xadrez
{
    class Torre : Peca
    {
        public Torre(TabuleiroJogo tab, Cor cor) : base(tab, cor)
        {

        }

        public override string ToString()
        {
            return "T";
        }
    }
}
