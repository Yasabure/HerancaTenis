using Tenis.classe;
internal class Program
{
    private static void Main(string[] args)
    {
        TenisNike tenis = new TenisNike
        (
            marca: "Nike",
            tamanho: 42,
            modelo: "Esportivo",
            valor: 430.00
        );
        tenis.CalcularValor();
    }

}