using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Select1
{
    static void Name()
    {
        string str = "Студенты, учащиеся в заданной группе.\n";
        Console.SetCursorPosition((Console.WindowWidth - str.Length) / 2, Console.CursorTop);
        Console.WriteLine(str);
    }
    public void SelGr(List<InfoStud> Stud) //группа
    {
        string g = "";
        int i = 1;
        int k = 0;
        Name();
        Console.Write("Введите название группы для поиска: ");
        g = Console.ReadLine();
        Console.WriteLine();
        Perexod perexod = new Perexod();
        foreach (InfoStud info in Stud)
        {
            if (g == info.Groop)
            {
                Console.WriteLine("{0}. " + info.FIO, i);
                i++;
                k = 1;
            }
        }
        if (k == 0)
            Console.WriteLine("Список пуст.\n");
        Console.WriteLine();
        perexod.Work(Stud);
    }
}

