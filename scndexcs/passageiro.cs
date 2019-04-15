using System;
namespace scndexcs
{
    public class passageiro
    {
        string Nome;
        int numeroPassagem;
        DateTime time;

        public void setNome(string Nome){
             this.Nome = Nome;
        }

        public string getNome(){
            return this.Nome;
        }
    }
}