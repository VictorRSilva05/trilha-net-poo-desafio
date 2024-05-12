using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone


internal class Program
{
    static void Main(string[] args)
    {


        Iphone iphone = new Iphone("3456789", "14 Pro", "55767687", 8, "victor@icloud.com");
        Nokia nokia = new Nokia("43897879", "Lumia", "2323423434", 2, "victor@gmail.com");

        Console.WriteLine(iphone.Numero
         + "\n" + iphone.IMEI
         + "\n" + iphone.Memoria
         + "\n" + iphone.Modelo);

        iphone.Numero = "666666";

        Console.WriteLine("\nNúmero do iPhone atualizado " + iphone.Numero);

        iphone.Ligar();
        iphone.ReceberLigacao();
        iphone.InstalarAplicativo("Angry Birds");

        Console.WriteLine();

        Console.WriteLine(nokia.Numero
            + "\n" + nokia.IMEI
            + "\n" + nokia.Memoria
            + "\n" + nokia.Modelo);

        nokia.Numero = "7777777";

        Console.WriteLine("\nNúmero do Nokia atualizado " + nokia.Numero);

        nokia.Ligar();
        nokia.ReceberLigacao();
        nokia.InstalarAplicativo("Asphalt 7");


    }
}
