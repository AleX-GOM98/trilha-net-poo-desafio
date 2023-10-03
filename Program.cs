using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Smartphone Nokia: ");
Smartphone nokia = new Nokia(numero: '83442233', modelo: "tijolo", imei: '123445566', memoria: 32);
nokia.Ligar();
nokia.InstalarAplicativo("Instagram");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone: ");
Smartphone iphone = new Iphone(numero: '83442233', modelo: "liso", imei: '123777776', memoria: 62);
iphone.Ligar();
iphone.InstalarAplicativo("tetris");