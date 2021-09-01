using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace OrientacaoObjetos {
    class Aluno {
        public string Nome;
        public double NotaPrimeiroTrimestre;
        public double NotaSegundoTrimestre;
        public double NotaTerceiroTrimestre;

        public double NotaFinal()
        {
            return NotaPrimeiroTrimestre + NotaSegundoTrimestre + NotaTerceiroTrimestre;
        }

        public string Situacao()
        {
            string situacao;

            if (NotaFinal() >= 60)
            {
                situacao = "APROVADO";
            } else
            {
                situacao = "REPROVADO";
            }

            return situacao;
        }

        public double PontosFaltantes()
        {
            return 60.0 - NotaFinal();
        }

        public override string ToString()
        {
            string texto;
            
            texto = $"NOTA FINAL = {NotaFinal().ToString("F2", CultureInfo.InvariantCulture)}" +
                $"\n{Situacao()}";

            if (Situacao() == "REPROVADO")
            {
                texto += $"\nFALTARAM {PontosFaltantes().ToString("F2", CultureInfo.InvariantCulture)} PONTOS";
            }

            return texto;
        }
    }
}
