using System;
using System.Globalization;
using System.Collections.Generic;
using System.Text;

namespace OrientacaoObjetos {
    class Secao04 {
        public static void aula40Exercicio01()
        {
            Pessoa X = new Pessoa();
            Pessoa Y = new Pessoa();

            Console.WriteLine("Dados da primeira pessoa");
            Console.Write("Nome: ");
            X.Nome = Console.ReadLine();

            Console.Write("Idade: ");
            X.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("Dados da segunda pessoa");
            Console.Write("Nome: ");
            Y.Nome = Console.ReadLine();

            Console.Write("Idade: ");
            Y.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine();

            if (X.Idade > Y.Idade)
            {
                Console.WriteLine("Pessoa mais velha: " + X.Nome);
            }
            else if (Y.Idade > X.Idade)
            {
                Console.WriteLine("Pessoa mais velha: " + Y.Nome);
            }
            else if (X.Idade == Y.Idade)
            {
                Console.WriteLine(X.Nome + " e " + Y.Nome + " tem a mesma idade");
            }
        }

        public static void aula40Exercicio02()
        {
            Funcionario X = new Funcionario();
            Funcionario Y = new Funcionario();

            Console.WriteLine("Dados do primeiro funcionário");
            Console.Write("Nome: ");
            X.Nome = Console.ReadLine();

            Console.Write("Salário: ");
            X.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();

            Console.WriteLine("Dados da segunda pessoa");
            Console.Write("Nome: ");
            Y.Nome = Console.ReadLine();

            Console.Write("Salário: ");
            Y.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();

            double salarioMedio = (X.Salario + Y.Salario) / 2;

            Console.WriteLine($"Salário médio: R$ {salarioMedio.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
