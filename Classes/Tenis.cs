namespace Tenis.classe
{
    public abstract class Tenis
    {
        public Tenis(string marca, int tamanho, string modelo)
        {
            this.Marca = marca;
            this.Tamanho = tamanho;
            this.Modelo = modelo;
        }
        public string Marca { get; protected set; }
        public int Tamanho { get; protected set; }
        public string Modelo { get; protected set; }

        public abstract void CalcularValor();
        
    }
}