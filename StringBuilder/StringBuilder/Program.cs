
using StringBuilderExercicio.Entities;

Comment comment1 = new Comment("Have a nice trip!!");
Comment comment2 = new Comment("Wow that's awesome!");
Post p1 = new Post(
    DateTime.Parse("21/06/2018 13:05:44"),
    "Travelling to new Zeland",
    "I'm going to visit this wonderfull country!",
    12
    );
p1.AddComment(comment1);
p1.AddComment(comment2);

Post p2 = new Post(
    DateTime.Parse("28/07/2018 13:05:44"),
    "Good night",
    "See you soon!",
    12
    );

p2.AddComment(comment1);
p2.AddComment(comment2);

Console.WriteLine(p1);
Console.WriteLine(p2);