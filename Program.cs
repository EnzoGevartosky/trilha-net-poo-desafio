using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia: ");
Smartphone nokia = new Nokia(numero: "(31) 98556-3547", modelo: "Tijolão", imei: "123456789", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone iPhone");
Smartphone iPhone = new Iphone(numero: "(31) 12345-6789", modelo: "iCaro", imei: "987654321", memoria: -128);
iPhone.ReceberLigacao();
iPhone.InstalarAplicativo("Discord");