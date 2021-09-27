using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace OrientacaoObjetos {
    class Secao06 {
        public static void aula71()
        {
            Console.Write("Quantos quartos serão alugados? ");
            int qtdeQuartos = int.Parse(Console.ReadLine());

            Pensionato[] pensionato = new Pensionato[10];

            Console.WriteLine();

            for (int i = 0; i < qtdeQuartos; i++)
            {
                Console.WriteLine("Aluguel #" + (i + 1));

                Console.Write("Nome: ");
                string nome = Console.ReadLine();

                Console.Write("Email: ");
                string email = Console.ReadLine();

                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());

                pensionato[quarto] = new Pensionato { Nome = nome, Email = email };

                Console.WriteLine();
            }

            Console.WriteLine("Quartos ocupados:");

            for (int i = 0; i < 10; i++)
            {
                if (pensionato[i] != null)
                {
                    Console.WriteLine(i + ": " + pensionato[i]);
                }
            }
        }

        public static void aula78()
        {
            Console.Write("Quantos funcionários serão registrados? ");
            int qtdeFunc = int.Parse(Console.ReadLine());

            Console.WriteLine();

            List<FuncionarioLista> funcionarioLista = new List<FuncionarioLista>();

            for (int i = 0; i < qtdeFunc; i++)
            {
                Console.WriteLine("Funcionário #" + (i + 1) + ":");

                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());

                Console.Write("Nome: ");
                string nome = Console.ReadLine();

                Console.Write("Salário: ");
                double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                funcionarioLista.Add(new FuncionarioLista(id, nome, salario));

                Console.WriteLine();
            }

            Console.Write("Informe o id do funcionário que terá o salário aumentado: ");
            int idAumento = int.Parse(Console.ReadLine());

            FuncionarioLista funcBusca = funcionarioLista.Find(item => item.Id == idAumento);

            if (funcBusca == null)
            {
                Console.WriteLine("Não existe nenhum funcionário com o Id " + idAumento + "!");
            }
            else
            {
                Console.Write("Informe o percentual: ");
                double percentual = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                funcBusca.AumentarSalario(percentual);
            }

            Console.WriteLine();

            Console.WriteLine("Lista atualizada de empregados:");

            foreach (FuncionarioLista obj in funcionarioLista)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
