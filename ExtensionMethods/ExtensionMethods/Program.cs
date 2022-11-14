
using ExtensionMethods.Extension;

DateTime dt = new DateTime(2018, 11, 16, 8, 10, 45);
Console.WriteLine(dt.ElapsedTime());

// Exemplo 2 gerar recorte em uma string
String s1 = "Good morning dear students!";
Console.WriteLine(s1.Cut(10));