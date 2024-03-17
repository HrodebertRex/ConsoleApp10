Person n = new Person();
class Person
{
    static void Main(string[] args)
    {
    public string name = "неизвестно";
    public int age;

    public void Print()
    {
        Console.ReadLine();
        if (name == "Роберт" || name == "Валериан" || name == "Тёма")
        {
            Console.WriteLine($"Ваше имя{name}");
        }
        else
        {
            Console.WriteLine($"Такого пользователя {name}");
        }
    }
}
