using DesafioPOO.Models;

class Program
{
    static void Main()
    {
        Console.Clear();
        
        // Criando instâncias das classes Nokia e Iphone
        Nokia nokia = new Nokia("123456789", "Nokia 3310", "IMEI12345", 64);
        Iphone iphone = new Iphone("987654321", "iPhone 13", "IMEI67890", 128);

        // Testando os métodos
        nokia.Ligar();
        nokia.InstalarAplicativo("WhatsApp");
        nokia.ReceberLigacao();

        Console.WriteLine("\n");

        iphone.Ligar();
        iphone.InstalarAplicativo("Instagram");
        iphone.ReceberLigacao();

    }
}
