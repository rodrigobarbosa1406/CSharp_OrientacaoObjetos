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
    }
}
