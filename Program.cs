using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

System.Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia(numero: "123456", modelo: "Aquele la", imei: "1233333", memoria: 64);  
nokia.Ligar();
nokia.InstalarAplicativo("Wpp");
System.Console.WriteLine(nokia.Numero);



System.Console.WriteLine("Smartphone Iphone");
Smartphone iphone = new Nokia(numero: "123456", modelo: "Aquele la", imei: "1233333", memoria: 64);  
iphone.Ligar();
System.Console.WriteLine(iphone.Numero);
iphone.InstalarAplicativo("telegram");
