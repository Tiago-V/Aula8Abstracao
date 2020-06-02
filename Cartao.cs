namespace Aula_08_Abstração
{
    public class Cartao : Pagamento
    {
        public int numero { get; set; }
        public string bandeira { get; set; }
        public string titular { get; set; }
        public string cvc { get; set; }
        public string token { get; set; }
        public bool validarToken(){
            if(token != null){

                return true;

            }

            return false;

        }
    }
}
