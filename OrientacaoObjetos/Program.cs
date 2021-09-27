using System;
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
                    else if (aula == 45)
                    {
                        Console.Write("Qual exercício você quer executar? ");
                        int exercicio = int.Parse(Console.ReadLine());
                        Console.WriteLine();

                        if (exercicio == 1)
                            Secao04.aula45Exercicio01();
                        else if (exercicio == 2)
                            Secao04.aula45Exercicio02();
                        else if (exercicio == 3)
                            Secao04.aula45Exercicio03();

                        Console.WriteLine();
                    }
                    else if (aula == 48)
                    {
                        Console.WriteLine("Essa aula possui apenas um exercício...");
                        Console.WriteLine();

                        Secao04.aula48();
                        Console.WriteLine();
                    }
                    else if (aula == 60)
                    {
                        Console.WriteLine("Essa aula possui apenas um exercício...");
                        Console.WriteLine();

                        Secao05.aula60();
                        Console.WriteLine();
                    }
                    else if (aula == 71)
                    {
                        Console.WriteLine("Essa aula possui apenas um exercício...");
                        Console.WriteLine();

                        Secao06.aula71();
                        Console.WriteLine();
                    }

                    else if (aula == 78)
                    {
                        Console.WriteLine("Essa aula possui apenas um exercício...");
                        Console.WriteLine();

                        Secao06.aula78();
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
