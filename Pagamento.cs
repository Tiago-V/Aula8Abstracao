using System;

namespace Aula_08_Abstração
{
    public class Pagamento
    {
        public DateTime data { get; set; }
        public float valor { get; set; }
        
        public string Pagar(){
            return "Pagamento efetuado";
        }
        public string CancelarPagamento(){
            return "Pagamento cancelado";
        }

    }
}