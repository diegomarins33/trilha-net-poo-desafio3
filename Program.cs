using DesafioPOO.Models;

Smartphone n1 = new Nokia("111111111", "Nokia n1", "0909090909", 128);
Smartphone i1 = new Iphone("222222222", "Iphone i1", "080808080", 64);

n1.Ligar();
n1.ReceberLigacao();
n1.InstalarAplicativo("Instagram");
System.Console.WriteLine("---------------");
i1.Ligar();
i1.ReceberLigacao();
i1.InstalarAplicativo("Instagram");
