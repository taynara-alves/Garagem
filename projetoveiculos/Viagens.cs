using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetoveiculos
{
    class Viagens
    {
        private Queue<Viagem> viagens = new Queue<Viagem>();

        public void incluir(Viagem viagem)
        {
            viagens.Enqueue(viagem);
        }
    }
}
