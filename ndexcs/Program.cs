using System;

namespace ndexcs
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno[] novoAluno = new Aluno[8];
            int contadorAluno = 0, contadorSala = 0;
            Sala[] salas = new Sala [8];
            bool sair = false;
            do {
            Console.Clear();
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
                if(contadorAluno > 4){
                Aluno a = new Aluno();
                System.Console.WriteLine("digite o nome do abençoado");
                a.Nome = Console.ReadLine();
                System.Console.WriteLine("digite a data de nascimento");
                a.dataNascimento = DateTime.Parse(Console.ReadLine());
                a.curso = Console.ReadLine();
                System.Console.WriteLine("digite o número da sala");
                a.numeroSala = int.Parse(Console.ReadLine());
                novoAluno[contadorAluno] = a;
                contadorAluno++;}

                System.Console.WriteLine("vc se cadastrou com sucesso");
                break;
                case 2: 
                Sala s = new Sala();
                System.Console.WriteLine("digite a sala");
                s.numeroSala= int.Parse(Console.ReadLine());
                System.Console.WriteLine("digite a capacidade total");
                s.capacidadeTotal = int.Parse(Console.ReadLine());
                s.capacidadeAtual = s.capacidadeTotal;
                s.alunos = new string [s.capacidadeTotal];



                string[]alunos = new string [s.capacidadeTotal];
                salas[contadorSala] = s;
                contadorSala++; 
                System.Console.WriteLine("vc se cadastrou com sucesso");
                break;
                case 3: 
                System.Console.WriteLine("digite o nome do abençoado");
                string nomeA = Console.ReadLine();
                System.Console.WriteLine("agora digite a sala q ele vai");
                int salaAluno = int.Parse(Console.ReadLine());
                break;
                
                case 4:
                System.Console.WriteLine("");
                break;

                case 5:
                foreach (var item in salas)
                {
                    if (item != null){
                    System.Console.WriteLine("--------------------------");
                    System.Console.WriteLine($"Número da sala{item.numeroSala}");
                    System.Console.WriteLine($"vagas disponíveis{item.capacidadeAtual}");
                    System.Console.WriteLine("--------------------------");}
                }
                break;

                case 6:
                foreach (var item in novoAluno)
                {
                    if (item != null){
                    System.Console.WriteLine("--------------------------");
                    System.Console.WriteLine($"Número da sala{item.Nome}");
                    System.Console.WriteLine($"vagas disponíveis{item.curso}");

                    System.Console.WriteLine("--------------------------");}
                }
                break;
            }
            }// fim do
            while ()
            
        }
    }
}
