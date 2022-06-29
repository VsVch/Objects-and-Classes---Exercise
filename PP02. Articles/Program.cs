using System;
using System.Linq;
using System.Collections.Generic;

namespace PP02._Articles
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputText = Console.ReadLine().Split(", ").ToList();

            int number = int.Parse(Console.ReadLine());
            List<Article> articles = new List<Article>();
            {
            string title = inputText[0];
            string content = inputText[1];
            string author = inputText[2];
            var article = new Article(title, content, author);
                articles.Add(article);
            };
            for (int i = 0; i < number; i++)
            {
                var newInput = Console.ReadLine().Split(':').Select(s => s.Trim()).ToList();
                    

                if (newInput[0] == "Edit")
                {
                    articles. = newInput[1];
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

        }
    }
    public class Article
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }

        public Article(string title, string content, string author)
        {
            this.Title = title;
            this.Content = content;
            this.Author = author;
        }
    }
}
