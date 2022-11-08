using DesafioPOO.Models;
// IMPLEMENTADO!!!!TODO: Realizar os testes com as classes Nokia e IphoneCLS

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "957845621", modelo: "G21", imei: "358959456212398", memoria: 128 );
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Instagram");

Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone(numero: "87756841", modelo: "Iphone 10XS", imei: "357863259514523", memoria: 128);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Waze");
