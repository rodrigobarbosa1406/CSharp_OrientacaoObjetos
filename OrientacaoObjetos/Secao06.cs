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

        public static void aula80()
        {
            Console.Write("Informe um número que representará a quantidade de linhas e colunas da matriz: ");
            int n = int.Parse(Console.ReadLine());

            int[,] matriz = new int[n, n];

            Console.WriteLine("Agora informe os valores de cada dimensão da matriz separados por espaço:");

            for (int i = 0; i < n; i++)
            {
                string[] valores = Console.ReadLine().Split(' ');

                for (int j = 0; j < n; j++)
                {
                    matriz[i, j] = int.Parse(valores[j]);
                }
            }

            Console.Write("Diagonal principal:");
            string diagonal;

            for (int i = 0; i < n; i++)
            {
                Console.Write(matriz[i, i] + " ");
            }

            Console.WriteLine();

            int negativos = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (matriz[i, j] < 0)
                    {
                        negativos++;
                    }
                }
            }

            Console.Write("Números negativos: " + negativos);
        }

        public static void aula81()
        {
            Console.Write("Informe as dimensões X e Y da matriz separadas por espaço: ");
            string[] valores = Console.ReadLine().Split(' ');
            int x = int.Parse(valores[0]);
            int y = int.Parse(valores[1]);

            int[,] matriz = new int[x, y];

            Console.WriteLine();
            Console.WriteLine("Agora informe os valores de cada dimensão separados por espaço:");

            for (int i = 0; i < x; i++)
            {
                string[] dados = Console.ReadLine().Split(' ');

                for (int j = 0; j < y; j++)
                {
                    matriz[i, j] = int.Parse(dados[j]);
                }
            }

            Console.WriteLine();
            Console.Write("Informe um valor que deverá ser procurado na matriz: ");
            int valor = int.Parse(Console.ReadLine());

            Console.WriteLine();

            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    if (matriz[i, j] == valor)
                    {
                        Console.WriteLine("Posição " + i + "," + j);

                        if (j > 0) 
                            Console.WriteLine("Esquerda: " + matriz[i,(j-1)]);
                        
                        if (i > 0)
                            Console.WriteLine("Acima:    " + matriz[(i-1),j]);
                        
                        if (j < (matriz.GetLength(1) - 1))
                            Console.WriteLine("Direita:  " + matriz[i,(j+1)]);
                        
                        if (i < (matriz.GetLength(0) - 1))
                            Console.WriteLine("Abaixo:   " + matriz[(i+1),j]);

                        Console.WriteLine();
                    }
                }
            }
        }
    }
}
