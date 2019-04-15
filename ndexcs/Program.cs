using System;

namespace ndexcs
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno[] novoAluno = new Aluno[8];

            System.Console.WriteLine("bem vindo ao Senaizinho!!!");
            System.Console.WriteLine("1 - cadastrar aluno");
            System.Console.WriteLine("2 - cadastrar sala");
            System.Console.WriteLine("3 - alocar aluno");
            System.Console.WriteLine("4 - remover aluno");
            System.Console.WriteLine("5 - verificar salas");
            System.Console.WriteLine("6 - verificar alunos");
            System.Console.WriteLine("0 - sair");
            System.Console.WriteLine("Escolha uma opção: ");
            int respostaUsuario = int.Parse(Console.ReadLine());

            switch (respostaUsuario)
            {
                case 1:
                System.Console.WriteLine("digite o nome do abençoado");
                Aluno novoAluno = new Aluno();
                novoAluno.setnome(Console.ReadLine());
                break;
                case 2: 
                System.Console.WriteLine("digite a sala");
                Sala novaSala = new Sala();
                novaSala.setnumeroSala(Console.ReadLine());
                break;
                case 3: 
                System.Console.WriteLine("digite o nome do abençoado");
                string nomeA = Console.ReadLine();
                System.Console.WriteLine("agora digite a sala q ele vai");
                int salaAluno = int.Parse(Console.ReadLine());
                break;
            }
            
        }
    }
}
