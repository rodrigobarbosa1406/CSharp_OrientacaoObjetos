﻿using System;
using System.Globalization;

namespace OrientacaoObjetos {
    class Program {
        static void Main(string[] args)
        {
            int aula = 99;

            while (aula > 0)
            {
                Console.Write("Qual aula você quer acessar? Para encerrar digite zero...");
                aula = int.Parse(Console.ReadLine());

                if (aula > 0)
                {
                    if (aula == 40)
                    {
                        Console.Write("Qual exercício você quer executar? ");
                        int exercicio = int.Parse(Console.ReadLine());
                        Console.WriteLine();

                        if (exercicio == 1)
                            Secao04.aula40Exercicio01();
                        else if (exercicio == 2)
                            Secao04.aula40Exercicio02();

                        Console.WriteLine();
                    }
                    else
                    {
                        Console.Write("Aula inválida! ");
                        Console.WriteLine();
                    }
                }
                else
                {
                    Console.WriteLine();
                    Console.Write("Programa finalizado... ");
                }

                Console.WriteLine();
            }
        }
    }
}