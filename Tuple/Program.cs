class MainClass
{
    public static void Main(string[] args)
    {
        (string Name, string[] Dishes) User;
        User.Dishes = new string[5];
        Console.WriteLine("Введите имя:");
        User.Name = Console.ReadLine();
        
        for (int i = 0; i < User.Dishes.Length; i++)
        {
            Console.WriteLine($"Укажите название {i + 1}-го любимого блюда:");
            User.Dishes[i] = Console.ReadLine();
        }
        Console.ReadKey();
    }
}
