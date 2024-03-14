namespace CSharpLabs2024.Task1
{
    public class Author(string name)
    {
        public string Name => name;

        public void Show()
        {
            Console.WriteLine(name);
        }
    }
}