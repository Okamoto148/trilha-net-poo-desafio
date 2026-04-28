namespace DesafioPOO.Models
{
    // Herdar da classe abstrata Smartphone
    public class Iphone : Smartphone
    {
        // Construtor que chama o construtor da classe base
        public Iphone(string numero, string modelo, string imei, int memoria) 
            : base(numero, modelo, imei, memoria)
        {
        }

        // Sobrescrever o método InstalarAplicativo
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo {nomeApp} no iPhone...");
        }
    }
}
