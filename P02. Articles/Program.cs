using System;
using System.Linq;

namespace P02._Articles
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(", ").ToList();
            int number = int.Parse(Console.ReadLine());
            var article = new Article
            {
                Title = input[0],
                Content = input[1],
                Author = input[2]        
            
            };
            for (int i = 0; i < number; i++)
            {
                var newInput = Console.ReadLine().Split(':').Select(s => s.Trim()).ToList();
                if (newInput[0] == "Edit")
                {
                    article.Content = newInput[1];
                }
                else if (newInput[0] == "ChangeAuthor")
                {
                    article.Author = newInput[1];
                }
                else if (newInput[0] == "Rename")
                {
                    article.Title = newInput[1];
                }



            }
            Console.WriteLine($"{article.Title} - {article.Content}:{article.Author}");

        }
    }
    class Article
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }
    }
}
