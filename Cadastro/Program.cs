using System;

namespace Cadastro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Faça o cadastro");
            Console.WriteLine(" ");
            Pessoa p1 = new Pessoa();

            Console.Write("Digite seu nome: ");
            p1.Nome = Console.ReadLine();

            Console.Write("Digite seu idade: ");
            p1.Idade = int.Parse(Console.ReadLine());

            Console.Write("Digite seu Sexo: ");
            p1.Sexo = char.Parse(Console.ReadLine());

            Console.WriteLine("=== Dados a serem cadastrados ===");

            Console.WriteLine($"Nome {p1.Nome} \n idade {p1.Idade} \n sexo {p1.Sexo} \n Deseja confirma ?");
            Console.WriteLine(" ");
            Console.Write("1 - SIM / 2 - NÃO");
            int p = int.Parse(Console.ReadLine());

            /*Este programa não foi testado previa mente então por favor aguarde a atualização*/
        }
    }
}