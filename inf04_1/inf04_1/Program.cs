internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        int a = 7 % 3;
        int b = 1 % 2;
        int c = 5 / 2;
        int[] ints = new int[5];
        Console.WriteLine(ints.Length);
        List<int> lista = new List<int>();
        string slowo = "Hallo, wie gehts dir?";
        Console.WriteLine(slowo[2]);
        char A = 'A';
        A += (char)32;
        Console.WriteLine(A);
        int i = 0;
        if (i > 10 && i < 100)
        {

        }
        int temp = 0;
        foreach (int j in ints)
        {
            temp += j;

        }
       
    }
    public void funkcja1(int a, string b)
    {
        int c = 1; 
        string d = "f";
        funkcja1(c, d);
    }
}
class Foo
{
    int name;
    public void Bar()
    {
        
    }

}
