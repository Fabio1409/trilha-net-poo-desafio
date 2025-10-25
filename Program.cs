using DesafioPOO.Models;

Iphone iphone = new Iphone("123456789", "iPhone 17", "IMEI123456789", "256GB");
Nokia nokia = new Nokia("987654321", "Nokia 3310", "IMEI987654321", "16GB");
iphone.Ligar();
nokia.ReceberLigacao();
iphone.InstalarAplicativo("WhatsApp");
nokia.InstalarAplicativo("Snake");
nokia.InstalarAplicativo("Facebook");
iphone.InstalarAplicativo("Instagram");


