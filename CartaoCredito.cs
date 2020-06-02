namespace Aula_08_Abstração
{
    public class CartaoCredito : Cartao
    {
        public float limite { get; set; }
        public float AumentarLimite(float limiteAtual, float acrescimo){
            return limiteAtual + acrescimo;
        }
        public string bloquear(){
            return "Cartão bloqueado";
        }

    }
}