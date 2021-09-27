using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace OrientacaoObjetos {
    class FuncionarioLista {
        public int Id { get; private set; }
        public string Nome { get; set; }
        public double Salario { get; private set; }

        public FuncionarioLista()
        {
        }

        public FuncionarioLista(int id)
        {
            Id = id;
        }

        public FuncionarioLista(int id, string nome, double salario) : this(id)
        {
            Nome = nome;
            Salario = salario;
        }

        public void AumentarSalario(double percentual)
        {
            Salario += (Salario * (percentual / 100));
        }

        public override string ToString()
        {
            return Id
                + ", "
                + Nome
                + ", "
                + Salario.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
