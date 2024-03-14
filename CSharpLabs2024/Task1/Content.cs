namespace CSharpLabs2024.Task1
{
    public class Content(string text)
    {
        public string Text => text;

        public void Show()
        {
            Console.WriteLine(text);
        }
    }

}