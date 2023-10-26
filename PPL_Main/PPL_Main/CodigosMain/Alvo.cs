using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPL_Main
{
    class Alvo
    {

        //Delcrando atributos
        private string IDAlvo;
        private double VelocidadeInicial;
        private double VelocidadeFinal;
        private float ValorAngulo;
        public double VelocidadeGravidade = 9.80;

        //Gerando encapsulamento para os atributos necessários
        public double VelocidadeInicialAlvo
        {
            get { return VelocidadeInicial; }
            set { VelocidadeInicial = value; }
        }

        public double VelocidadeFinalAlvo
        {
            get { return VelocidadeFinal; }
            set { VelocidadeFinal = value; }
        }

        public float ValorAnguloAlvo
        {
            get { return ValorAngulo; }
            set { ValorAngulo = value; }
        }


    }
}
