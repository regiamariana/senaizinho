using System;

namespace ndexcs
{
    public class Sala
    {
        public int numeroSala {get; set;}

        public int capacidadeAtual {get; set;} 

        public int capacidadeTotal {get; set;}

        public string alocarAluno (int capacidadeTotal);

        public string [] alunos {get; set;}

    }
}