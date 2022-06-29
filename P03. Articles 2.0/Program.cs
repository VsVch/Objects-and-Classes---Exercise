using System;
using System.Collections.Generic;
using System.Linq;

namespace P03._Articles_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int numArticle = int.Parse(Console.ReadLine());
            List<Article> articles = new List<Article>();
            string[] input;
            for (int i = 0; i < numArticle; i++)
            {
                input = Console.ReadLine().Split(", ");
                var article = new Article(input[0], input[1], input[2]);
                articles.Add(article);

            }
            string order = Console.ReadLine();
            switch (order)
            {
                case "title":
                    articles = articles.OrderBy(x => x.Title).ToList();
                    break;
                case "content":
                    articles = articles.OrderBy(x => x.Content).ToList();
                    break;
                case "author":
                    articles = articles.OrderBy(x => x.Author).ToList();
                    break;


                default:
                    break;
            }

            Console.WriteLine(string.Join(Environment.NewLine, articles));
        }
    }
    class Article
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }

        public Article(string title, string content, string autor)
        {
            Title = title;
            Content = content;
            Author = autor;
        }
        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }
    }
}
