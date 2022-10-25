using System.Collections.Generic;

string path = @"c:\Nelio";


try
{
    // Listar pastas.
    IEnumerable<string> folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
    Console.WriteLine("Folders");
    foreach (string s in folders)
    {
        Console.WriteLine(s);
    }

    // Listar Arquivos.
    IEnumerable<string> files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
    Console.WriteLine("Files");
    foreach (string s in files)
    {
        Console.WriteLine(s);
    }

    // Criar nova pasta no diretório.
    Directory.CreateDirectory(path + "\\newfolder");
}
catch (IOException e)
{
    Console.WriteLine("An error accurred");
    Console.WriteLine(e.Message);
}

// Classe Path.
string pathExemplo = @"c:\Nelio\file1.txt";

Console.WriteLine("GetDirectoryName: " + Path.GetDirectoryName(pathExemplo));
Console.WriteLine("DirectorySeparatorChar: " + Path.DirectorySeparatorChar);
Console.WriteLine("PathSeparator: " + Path.PathSeparator);
Console.WriteLine("GetFileName: " + Path.GetFileName(pathExemplo));
Console.WriteLine("GetFileNameWithoutExtension: " + Path.GetFileNameWithoutExtension(pathExemplo));
Console.WriteLine("GetExtension: " + Path.GetExtension(pathExemplo));
Console.WriteLine("GetFullPath: " + Path.GetFullPath(pathExemplo));
