// See https://aka.ms/new-console-template for more information
using C_sharp_HW_2;
    FileInfo file = new FileInfo(@"C:\Users\admin\Documents\Шаг\C#\Orientirovanie\Orientirovanie\save.txt");
// file.Create();

List<string> strings = new List<string>();



List<Uchastniki> uchastniki = new List<Uchastniki>();



int count = Uchastniki.Vvod_age("Введите количество участников: ");

for (int i = 0; i < count; i++)
{
    uchastniki.Add(new Uchastniki(i + 1));
}

foreach (var item in strings)
    {
        string[] subs = item.Split('!');
        uchastniki.Add(new Uchastniki(int.Parse(subs[0]), subs[1], int.Parse(subs[2])));
    }

    void vyvod()
    {
        Console.WriteLine("Все участники:");

        foreach (var item in uchastniki)
        {
            Console.WriteLine(item.ToString());
        }
    }

    string s = "";
    while (s != "5")
    {
        Console.WriteLine();
        vyvod();
        Console.WriteLine();
        Console.WriteLine("[1] Добавить участника");
        Console.WriteLine("[2] Удалить участника");
        Console.WriteLine("[3] Изменить возраст");
        Console.WriteLine("[4] Изменить ФИО");
        Console.WriteLine("[5] Выход");
        s = Console.ReadLine();
        if (s == "5")
        {
            break;
        }

        switch (s)
        {
            case "1":
                uchastniki.Add(new Uchastniki(uchastniki.Count + 1));
                Console.WriteLine();
                vyvod();
                break;
            case "2":
                Console.WriteLine("Введите ID участника: ");
                uchastniki.RemoveAt(Uchastniki.Vvod_age("") - 1);
                Console.WriteLine();
                vyvod();
                break;
            case "3":
                Console.WriteLine("Введите ID участника: ");
                int _age = int.Parse(Console.ReadLine()) - 1;
                Console.WriteLine("Введите новый возраст: ");
                (uchastniki.ElementAt(_age)).Age = int.Parse(Console.ReadLine());
                Console.WriteLine();
                vyvod();
                break;
            case "4":
                Console.WriteLine("Введите ID участника: ");
                int _name = int.Parse(Console.ReadLine()) - 1;
                Console.WriteLine("Введите новое ФИО: ");
                uchastniki.ElementAt(_name).Name = String.Format(Console.ReadLine());
                Console.WriteLine();
                vyvod();
                break;
            case "5":
                break;


            default:
                {
                    break;
                }
        }
    }

using (StreamWriter writer = new(@"C:\Users\admin\Documents\Шаг\C#\Orientirovanie\Orientirovanie\save.txt", false))
{
    foreach (var item in uchastniki)
    {
        writer.WriteLine(item.Id + "!" + item.Name + "!" + item.Age);
    }

}

using (StreamReader reader = new(@"C:\Users\admin\Documents\Шаг\C#\Orientirovanie\Orientirovanie\save.txt"))
{
    string line;
    while ((line = reader.ReadLine()) != null)
    {
        Console.WriteLine(line);
    }
}

return;