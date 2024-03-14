using System;

namespace CSharpLabs2024.Task1
{
    public class Book(string title, string author, string content)
    {
        public Title Title
        {
            get => new(title);
            set => throw new InvalidOperationException("Назва книги не може бути змінена!");
        }
        
        public Author Author { get; set; } = new(author);
        public Content Content { get; set; } = new(content);

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Назва книги: " + Title.Text);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Автор: " + Author.Name);

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Зміст: " + Content.Text);
            
            Console.ResetColor();
        }
    }

}

