internal class Program
{
    static void Main(string[] args)
    {
        TextPost a = new TextPost("A", "aaaaa");
        TextPost b = new TextPost("b", "bbbbbb");

        for (int i = 0; i < 3; i++)
        {
            a.Like(); 
        }

        Console.WriteLine(a.GetDescription());
        Console.ReadKey();
    }
}
