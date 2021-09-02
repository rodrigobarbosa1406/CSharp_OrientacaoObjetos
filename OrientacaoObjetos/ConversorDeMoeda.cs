using System;
using System.Collections.Generic;
using System.Text;

namespace OrientacaoObjetos {
    class ConversorDeMoeda {
        public static double IOF = 1.06;

        public static double CalcularValorEmReais(double cotacaoDolar, double qtdeDolares)
        {
            return (qtdeDolares * cotacaoDolar) * IOF;
        }
    }
}
