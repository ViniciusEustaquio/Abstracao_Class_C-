using Abstraindo_Celular_POO_C_.Models;

Console.WriteLine("SmartPhone Nokia"); 
Smartphome nokia = new Nokia(numero: 123456, modelo: "Modelo 1", imei: "1111111", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("whatssap");

Console.WriteLine("\n");


Console.WriteLine("SmartPhone iphone");
Smartphome iphone = new Iphone(numero: 123456, modelo: "Modelo 2", imei: "1111111", memoria: 64);
iphone.ReceberLigação();
iphone.InstalarAplicativo("telegram");