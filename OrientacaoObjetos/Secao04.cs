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

        public static void aula45Exercicio01()
        {
            Triangulo triangulo = new Triangulo();

            Console.Write("Informe a largura do triângulo: ");
            triangulo.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Informe a altura do triângulo: ");
            triangulo.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();

            Console.WriteLine($"ÁREA: {triangulo.Area().ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"PERÍMETRO: {triangulo.Perimetro().ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"DIAGONAL: {triangulo.Diagonal().ToString("F2", CultureInfo.InvariantCulture)}");
        }

        public static void aula45Exercicio02()
        {
            Funcionario funcionario = new Funcionario();

            Console.WriteLine("INFORME OS DADOS DO FUNCIONÁRIO");

            Console.Write("Nome: ");
            funcionario.Nome = Console.ReadLine();

            Console.Write("Salário Bruto: ");
            funcionario.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Imposto: ");
            funcionario.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.WriteLine("Funcionário: " + funcionario);

            Console.WriteLine();
            Console.Write("Digite a porcentagem para aumentar o salário: ");
            funcionario.AumentarSalario(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));

            Console.WriteLine();
            Console.WriteLine("Dados Atualizados:" + funcionario);
        }

        public static void aula45Exercicio03()
        {
            Aluno aluno = new Aluno();

            Console.WriteLine("INFORME OS DADOS DO FUNCIONÁRIO");

            Console.Write("Nome do aluno: ");
            aluno.Nome = Console.ReadLine();

            Console.WriteLine("Digite as três notas do aluno:");
            aluno.NotaPrimeiroTrimestre = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.NotaSegundoTrimestre = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.NotaTerceiroTrimestre = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.WriteLine(aluno);
        }

        public static void aula48()
        {
            Console.Write("Qual é a cotação do dólar? ");
            double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantos dólares você vai comprar? ");
            double quantidade = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();

            Console.WriteLine($"Valor a ser pago em reais: $ {ConversorDeMoeda.CalcularValorEmReais(cotacao, quantidade).ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
