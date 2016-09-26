using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.tabuleiro
{
    class posicao{
        public int linha { get; set; }
        public int coluna { get; set; }

        public posicao(int linha, int coluna)
        {
            this.linha = linha;
            this.coluna = coluna;
        }

        public override string ToString()
        {
            return linha
            +","
            + coluna;
        }
    }
}
