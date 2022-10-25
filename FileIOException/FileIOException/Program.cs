using System.IO;

// O uso do @ é para evitar usar duas contra-barras no endereço
string sourcePath = @"c:\Nelio\file1.txt";

string targetPath = @"c:\Nelio\file2.txt";

try
{
    FileInfo fileInfo = new FileInfo(sourcePath);
    fileInfo.CopyTo(targetPath);
    string[] lines = File.ReadAllLines(sourcePath);
    foreach(string line in lines)
    {
        Console.WriteLine(line);
    }
}
catch(IOException e)
{
    Console.WriteLine("An error ocurred");
    Console.WriteLine(e.Message);
}