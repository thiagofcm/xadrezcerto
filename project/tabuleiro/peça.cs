using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.tabuleiro
{
    class peça{
        public posicao posicao { get; set; }
        public tabuleiro tab { get; protected set; }
        public cor cor { get; set; }
        public int qteMovimentos { get; protected set; }


        public peça(posicao posicao, tabuleiro tab, cor cor){
            this.posicao = posicao;
            this.tab = tab;
            this.cor = cor;
            this.qteMovimentos = 0; 

        }
    }
}
