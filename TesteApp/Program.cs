using System;
using System.Collections.Generic;
using System.Threading;

namespace TesteApp
{
    class Program
    {

        private static List<Produto> produtos = new List<Produto>();

        static void Main(string[] args)
        {
            Console.WriteLine("Teste de função");

            Thread.Sleep(1000);


            Opc();
        }
        static void Opc()
        {
            Console.WriteLine("Classes, Objetos e Escopos de Visibilidade");

            string comando = "S";

            do
            {
                //Exibir Menu
                Console.Clear();
                Console.WriteLine("Escolha um produto");
                Console.WriteLine("1 - Cadstra Produtos");
                Console.WriteLine("2 - Ver lista de produtos");
                Console.WriteLine("S - Sair");

                //leitura do comando do usuario
                Console.Write("Opção desejada: ");
                comando = Console.ReadKey().KeyChar.ToString().ToUpper();

                switch (comando)
                {
                    case "1":
                        Console.Write("\nNome do Produto: ");
                        string nome = Console.ReadLine();
                        Console.Write("Preço do produto: ");
                        string preco = Console.ReadLine();
                        Produto novoProduto = new Produto(nome, Convert.ToDouble(preco));
                        produtos.Add(novoProduto);
                        Console.WriteLine("Produto adicionado com sucesso");

                        Console.ReadKey();

                        Opc();

                        break;

                    case "2":
                        if (produtos.Count > 0)
                        {
                            Console.WriteLine("\nListagem de produtos");
                            foreach (Produto p in produtos)
                            {
                                Console.WriteLine(p.ObterTexto());
                            }
                            Console.WriteLine("Precione qualquer tecla para prosseguir...");
                            Console.ReadKey();
                        }
                        else
                            Console.WriteLine("\nNão há produtos cadastrados!");
                        Console.ReadKey();

                        Opc();
                        break;
                    case "S":
                        Console.WriteLine("\nObrigado por usar o programa");
                        break;
                    default:
                        Console.WriteLine("Opção invalida tente novamente");
                        Console.ReadKey();

                        Opc();
                        break;
                }


            } while (false);
        }


    }
}