using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetoveiculos
{
    class Veiculo
    {
        private int lotacao;
        private string placa;
        private string nomedomotorista;

        public Veiculo( int lotacao, string placa, string nomedoMotorista)
        {
            this.Nomedomotorista = nomedoMotorista;
            this.lotacao = lotacao;
            this.Placa = placa;
        }

        public Veiculo()
        {
            nomedomotorista = "";
            lotacao = 0;
            Placa = "";
        }

        public int Lotacao { get { return Lotacao; } }

        public string Placa
        {
            get
            {
                return placa;
            }

            set
            {
                placa = value;
            }
        }

        public string Nomedomotorista
        {
            get
            {
                return nomedomotorista;
            }

            set
            {
                nomedomotorista = value;
            }
        }
    }
}
