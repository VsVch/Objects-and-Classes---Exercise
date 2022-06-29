using System;
using System.Collections.Generic;
using System.Linq;

namespace PP03._Articles_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            List<Article> articles = new List<Article>();
            for (int i = 0; i < number; i++)
            {
                string[] input = Console.ReadLine().Split(", ");
                string title = input[0];
                string content = input[1];
                string author = input[2];
                var article = new Article (title, content, author);
                articles.Add(article);

            }
            string criteria = Console.ReadLine();
            if (criteria == "title")
            {
                articles = articles.OrderBy(x => x.Title).ToList();
            }
            if (criteria == "content")
            {
                articles = articles.OrderBy(x => x.Content).ToList();
            }
            if (criteria == "author")
            {
                articles = articles.OrderBy(x => x.Author).ToList();
            }

            Console.WriteLine(string.Join(Environment.NewLine, articles));
        }
    }
    class Article
    {
        public string Title {get; set;}
        public string Content {get; set;}
        public string Author {get; set;}

        public Article(string title, string content, string author)
        {
            this.Title = title;
            this.Content = content;
            this.Author = author;
        
        }
        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }
    }
}
