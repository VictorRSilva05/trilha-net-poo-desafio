namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        public string iCloud { get; set; }
        public Iphone(string numero, string modelo, string iMEI, int memoria, string icloud) : base(numero, modelo, iMEI, memoria)
        {   
            iCloud = icloud;
        }

        // TODO: Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine("A App Store está instalando " + nomeApp);
        }
    }
}