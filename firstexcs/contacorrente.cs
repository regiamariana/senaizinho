namespace firstexcs
{
    
    public class contacorrente
    {
        
    public string titular;

    public int agencia;
    
    public int numeroConta;

    public double saldo {get; private set;}

    public void Depositar (double valor){
        saldo += valor;
    }

       public bool Sacar (double valor){
        if (valor > saldo){
            return false;
        }else {
            saldo -= valor;
            return true;
        }
    }//fim Sacar
        public double exibirSaldo (){
            return saldo;
        }
        public bool Transferir (double valor, contacorrente contaDestino){
            if(valor > saldo){
                return false;
            }else{
                saldo -= valor;
                return true;
            }
        }
       
    }




}
