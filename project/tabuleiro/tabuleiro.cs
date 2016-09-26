using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.tabuleiro
{
    class tabuleiro {
        private peça[,] pecas;
        public int linhas { get; set; }
        public int colunas { get; set; }

        public tabuleiro(int linhas, int colunas)
        {
            this.linhas = linhas;
            this.colunas = colunas;
            pecas= new peça[linhas, colunas];
        }
    }
}
