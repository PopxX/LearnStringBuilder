using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StringBuilderEx.Entitites;


namespace StringBuilderEx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Coments c1 = new Coments("Have a nice trip");
            Coments c2 = new Coments("Wow that's awesome!");

            Post p1 = new Post(
                DateTime.Parse("21/06/2018 13:05:44"),
                "Traveling to New Zeland",
                "I'm going to visit this wonderful country!",
                12
                );
            p1.AddComent(c1);
            p1.AddComent(c2);


            Coments c3 = new Coments("Good night");
            Coments c4 = new Coments("May the Force be with you");

            Post p2 = new Post(
                DateTime.Parse("28/07/2018 23:14:19"),
                "Good night guys",
                "See you tomorrow",
                5
                );
            p2.AddComent(c3);
            p2.AddComent(c4);

            Console.WriteLine(p1);
            Console.WriteLine(p2);




        }
    }
}
