public class Vowels
{
    public static void Vowelss()
    {
        Console.WriteLine("Enter a letter to check whether it is vowel");
        char n = Convert.ToChar(Console.ReadLine());
        n = char.ToUpper(n);
        if (n == 'A' || n == 'E' || n == 'I' || n == 'O' || n == 'U')
        {
            Console.WriteLine($"The letter {n} is a vowel");
        }
        else
        {
            Console.WriteLine($"The letter {n} is a consonant");
        }

    }
    public static void Main(string[] args)
    {
        Vowelss();
    }
}