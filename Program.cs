using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "123456", modelo: "C3", imei: "11111", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Uber");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone(numero: "1654321", modelo: "14", imei: "2222", memoria: 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("WhatsApp");

Console.ReadKey();