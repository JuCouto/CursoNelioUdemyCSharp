using ExercicioConjuntos.Entities;
using System.IO;
using System;
using System.Collections.Generic;

HashSet<LogRecord> set = new HashSet<LogRecord>();

Console.Write("Enter file full path: ");
string path = Console.ReadLine();
try
{
    using (StreamReader sr = File.OpenText(path))
    {
        while (!sr.EndOfStream)
        {
            string[] line = sr.ReadLine().Split(' ');
            string name = line[0];
            DateTime instant = DateTime.Parse(line[1]);
            // Usando a sintaxe com { pq não fiz construtor na classe LogRecord.
            set.Add(new LogRecord { UserName= name, Instant = instant});
            
        }
        Console.WriteLine("Total users: " + set.Count);
    }
}
catch (IOException e)
{
    Console.WriteLine(e.Message);
}