namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
        public string GoogleCloud {  get; set; }
        public Nokia(string numero, string modelo, string iMEI, int memoria,string googlecloud) : base(numero, modelo, iMEI, memoria)
        {
            GoogleCloud = googlecloud;
        }

        // TODO: Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine("A Play Store está instalando o aplicativo " + nomeApp);
        }
    }
}