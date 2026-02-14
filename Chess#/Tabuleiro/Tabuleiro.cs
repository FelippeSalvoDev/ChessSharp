namespace Tabuleiro
{
    class TabuleiroJogo
    {
        public int linhas {  get; set; }
        public int colunas { get; set; }
        private Peca[,] pecas;

        public TabuleiroJogo(int linhas, int colunas)
        {
            this.linhas = linhas;
            this.colunas = colunas;
            pecas = new Peca[linhas,colunas];
        }
    }
}
