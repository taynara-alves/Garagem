using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetoveiculos
{
    class Garagem
    {
        private int id;
        private string local;
        private List<Veiculo> veiculos = new List<Veiculo>();

        public string Local
        {
            get
            {
                return local;
            }

            set
            {
                local = value;
            }
        }

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        internal List<Veiculo> Veiculos
        {
            get
            {
                return veiculos;
            }

            set
            {
                veiculos = value;
            }
        }

        public int qtDeVeiculo()
        {
            return Veiculos.Count;
        }

        public int potencialDeTransporte()
        {
            int i = 0;
            foreach (Veiculo veiculo in Veiculos)
            {
                i += veiculo.Lotacao;
            }
            return i;
        }
    }
}
