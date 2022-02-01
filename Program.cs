class Program
{
    static void Main(string[] args)
    {
        string[] names = { "Lucifer", "Diabolus", "Marchosias", "Astaroth", "Satanas", "Beelzeboth", "Asmodeus", "Lilith", "Leonardo", "Behemoth" };
        
        for (int i = 0; i < names.Length; i++)
        {
            Console.WriteLine(names[i]);
        }

        foreach(string name in names)
        {
            Console.WriteLine(name);
        }
    }
}

