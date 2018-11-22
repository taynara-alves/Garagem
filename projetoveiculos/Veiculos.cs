using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetoveiculos
{
    class Veiculos
    {
        private List<Veiculo> veiculos = new List<Veiculo>();

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

        public void incluir(Veiculo veiculo)
        {
            Veiculos.Add(veiculo);
        }

        public void Add()
        {
            for (int i = 1; i <= 8; i++)
            {
                Veiculo veiculo = new Veiculo(i, "", ("" + i));
                incluir(veiculo);
            }
        }
    }
}
