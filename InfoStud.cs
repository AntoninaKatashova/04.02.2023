using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class InfoStud
{
    public string FIO;
    public int Day;
    public int Month;
    public int Year;
    public string Groop;
    public string[] Predmet;
    public int[] Mark;
    public int n;

    static void Name()
    {
        string str = "Заполнение списка студентов.\n";
        Console.SetCursorPosition((Console.WindowWidth - str.Length) / 2, Console.CursorTop);
        Console.WriteLine(str);
    }
    public void show(List<InfoStud> Stud)
    {
        Perexod perexod = new Perexod();
        string s = "";
        Name();
        Console.Write("Введите количество предметов: ");
        n = Convert.ToInt32(Console.ReadLine());
        while (s != "стоп")
        {
            InfoStud person = new InfoStud();
            Console.Clear();
            Name();
            Console.Write("Введите ФИО студента: ");
            person.FIO = Console.ReadLine();
            Console.Write("Введите день рождения (от 1 до 31): ");
            person.Day = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите месяц рождения (от 1 до 12): ");
            person.Month = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите год рождения (от 1963 до 2009): ");
            person.Year = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите группу: ");
            person.Groop = Console.ReadLine();
            person.Predmet = new string[n];
            person.Mark = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("Введите экзаменационный предмет: ");
                person.Predmet[i] = Console.ReadLine();
                Console.Write("Введите оценку по данному предмету: ");
                person.Mark[i] = Convert.ToInt32(Console.ReadLine());
            }
            Stud.Add(person);
            Console.Write("\nДля завершения заполнения списка введите \"стоп\": ");
            s = Console.ReadLine();
            Console.WriteLine();
        }
        perexod.Work(Stud);
    }
}

