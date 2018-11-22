using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetoveiculos
{
    class Garagens
    {
        private List<Garagem> garagens = new List<Garagem>();
        private bool jornadaAtiva;

        public void incluir(Garagem garagem)
        {
            garagens.Add(garagem);
        }

        public void iniciarJornada()
        {
            jornadaAtiva = true;
        }
        /*
        public  List<Transporte> encerrarJornada()
        {
            
        }*/
    }
}
