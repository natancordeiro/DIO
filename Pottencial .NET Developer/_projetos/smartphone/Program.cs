using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia: ");
Smartphone nokia = new Nokia("9823532782", "Modelo 22", "111111", 64);
nokia.Ligar();
nokia.InstalarAplicativo("Facebook");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone: ");
Smartphone iphone = new Iphone("984357221", "14pro", "2222222", 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Whatsapp");
