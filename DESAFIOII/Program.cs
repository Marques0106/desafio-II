using System;

namespace DESAFIOII
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                int qt = int.Parse(Console.ReadLine());
                // TODO: Crie as outras condições necessárias para a resolução do desafio:
                for (int i = 0; i < qt; i++)
                {

                    string entrada = Console.ReadLine();//insere o valor com espaço
                    string[] v = entrada.Split(' ');//cria um vetor que recebe o split da entrada
                    string a = v[0];//separa o vetor em duas partes
                    string b = v[1];

                    int inicio = a.Length - b.Length;//trava  o inicio da contagem de caracter
                    int qtdCaracteres = b.Length;//tamanho do valor inserido para var b

                    if (b.Length > a.Length)
                    {
                        Console.WriteLine("nao encaixa");
                    }
                    else if (String.Equals(a.Substring(inicio, qtdCaracteres), b) == true)
                    {
                        Console.WriteLine("encaixa");
                    }
                    else
                    {
                        Console.WriteLine("nao encaixa");
                    }

                }
            }

        }
    }
}