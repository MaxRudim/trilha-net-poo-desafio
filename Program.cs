using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");

var nokia = new Nokia("123456789", "Nokia 3310", "123456789", 16);

nokia.Ligar();

nokia.InstalarAplicativo("Snake");

Console.WriteLine("\nSmartphone iPhone:");

var iphone = new Iphone("987654321", "iPhone 12", "987654321", 128);

iphone.ReceberLigacao();

iphone.InstalarAplicativo("Instagram");