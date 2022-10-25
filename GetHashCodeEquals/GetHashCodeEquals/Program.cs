using System;
using GetHashCodeEquals.Entities;

Client c1 = new Client { Name = "Maria", Email = "maria@gmail.com" };
Client c2 = new Client { Name = "Maria", Email = "maria@gmail.com" };

Console.WriteLine(c1.Equals(c2));
Console.WriteLine(c1 == c2);
Console.WriteLine(c1.GetHashCode());
Console.WriteLine(c2.GetHashCode());