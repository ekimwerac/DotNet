// See https://aka.ms/new-console-template for more information



using MyExtensions; // Import the namespace where the extension methods are defined

class Program
{
    static void Main()
    {
        string text = "hello, world!";
        string capitalized = text.CapitalizeFirstLetter();
        Console.WriteLine(capitalized); // Output: "Hello, world!"
        
    }
}

