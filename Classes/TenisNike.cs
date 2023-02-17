namespace Tenis.classe
{
    public class TenisNike : Tenis
    {
        public TenisNike
        (
            string marca
            ,int tamanho
            ,string modelo
            ,double valor
        )
        :
        base
        (
            marca, tamanho, modelo
        )
        {
            this.Valor = valor;
        }
        public double Valor {get ; set ;}
        public override void CalcularValor()
        {
            Console.WriteLine($"O Valor do Tenis é {this.Valor - this.Tamanho}");
        }
    }
}