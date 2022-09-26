using System;
using StringBuilderDemo.Entities;

namespace StringBuilderDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Comment c1 = new Comment("Have a nice trip");
            Comment c2 = new Comment("Wow tha's awesome!");
            Post p1 = new Post(

                "Traveling to New Zealand",
                 12,
                DateTime.Parse("21/06/2018 13:05:44"),
                "I'm going to visit this wonderful country!");
            p1.AddComment(c1);
            p1.AddComment(c2);


            Comment c3 = new Comment("Good Night");
            Comment c4 = new Comment("May the Force be with you");
            Post p2 = new Post(

                "Good night guys",
                 5,
                DateTime.Parse("28/07/2018 23:14:19"),
                "See you tomorrow");
            p2.AddComment(c3);
            p2.AddComment(c4);

            Console.WriteLine(p1);
            Console.WriteLine(p2);
        }
    }
}
