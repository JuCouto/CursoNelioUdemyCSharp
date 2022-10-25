using System.IO;

string path = @"c:\Nelio\file1.txt";

// Forma mais longa de fazer a instanciação e o bloco,
/* FileStream fs = null;
StreamReader sr = null;

try
{
    // Abrir arquivo para acesso. Instanciando os dois
    // fs = new FileStream(path, FileMode.Open);
    // sr = new StreamReader(fs);

    // Instanciando pelo File. O código fica menor
    sr = File.OpenText(path);

    while (!sr.EndOfStream)
    {
        string line = sr.ReadLine();
        Console.WriteLine(line);
    }
}
catch (IOException e)
{
    Console.WriteLine("An error accurred");
    Console.WriteLine(e.Message);
}
// É necessário fechar o recurso manualmente, pois é um recurso externo 
finally
{
    if (sr != null) sr.Close();
    if (fs != null) fs.Close();
}*/

// Forma mais resumida de fazer.
try
{
    using (StreamReader sr = File.OpenText(path))
    {
        while (!sr.EndOfStream)
        {
            string line = sr.ReadLine();
            Console.WriteLine(line);
        }
    }
}
catch (IOException e)
{
    Console.WriteLine("An error ocurred");
    Console.WriteLine(e.Message);
}