namespace Aula_08_Abstração
{
    public class CartaoDebito : Cartao
    {
        public float saldo { get; set; }
        public string transferir(float valor){
            return $"Valor R$ {valor} transferido";
        }
         public string PagarTitulo(){
            return "Título pago com cartão de débito";
        }
    }
}