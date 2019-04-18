using System;

namespace ndexcs
{
    public class Sala
    {
        public int numeroSala {get; set;}

        public int capacidadeAtual {get; set;} 

        public int capacidadeTotal {get; set;}

        public string alocarAluno (string nomeAluno){
            if(capacidadeAtual != 0){
            capacidadeAtual--;
            alunos[capacidadeAtual] = nomeAluno;
            return $"aluno {nomeAluno} registrado com sucesso!";
            }else {
                return "não há vagas!";
            }
        }

        public string removerAluno (string nomeAluno){
            for (int i = 0; i < novoAluno.Length; i++)
            {
                if(novoAluno[i] != null && nomeAluno.Equals(novoAluno[i])){
                    novoAluno[i] = null;
                    capacidadeAtual++;
                    return $"vaza fia! {nomeAluno}";

                }

            }return $"infelizmente não expulso";
        }

        public string [] alunos {get; set;}

    }
}