using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Nokia nokia = new Nokia(numero: "987654321", modelo: "Nokia 3310", imei: "IMEI987654321", memoria: "16GB");
nokia.Ligar();
nokia.InstalarAplicativo("Snake");
nokia.InstalarAplicativo("WhatsApp");
nokia.InstalarAplicativo("Facebook");

System.Console.WriteLine("********************************************************");


Console.WriteLine("Smartphone Iphone:");
Iphone iphone = new Iphone(numero: "123456789", modelo: "iPhone 17", imei: "IMEI123456789", memoria: "256GB");
iphone.ReceberLigacao();
iphone.InstalarAplicativo("WhatsApp");
iphone.InstalarAplicativo("Instagram");
iphone.InstalarAplicativo("TikTok");


