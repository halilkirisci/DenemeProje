// See https://aka.ms/new-console-template for more information
using OOP;

Console.WriteLine("Hello, World!");

Matematik m = new Matematik();
Matematik n = new Matematik();

int result = m.Carpma(5, 4);
Console.WriteLine(result);

var x = new Mathh();
x.birinci = 4;
x.ikinci = 5;
Console.WriteLine("birinci:" + x.birinci + " - ikinci:" + x.ikinci);
Console.WriteLine("Toplam:" + x.Toplama() + "- Çıkarma:" + x.Cikarma());

x = new Mathh();
Console.WriteLine("boş iken => birinci:" + x.birinci + " - ikinci:" + x.ikinci);
x = new Mathh(9,5);
Console.WriteLine("dolu iken => birinci:" + x.birinci + " - ikinci:" + x.ikinci);
