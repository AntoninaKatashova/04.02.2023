using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Select4
{
    static void Name()
    {
        string str = "Студенты моложе 20 лет.\n";
        Console.SetCursorPosition((Console.WindowWidth - str.Length) / 2, Console.CursorTop);
        Console.WriteLine(str);
    }
    public void SelVoz(List<InfoStud> Stud) //возраст
    {
        int i = 1;
        int k = 0;
        Name();
        Perexod perexod = new Perexod();
        foreach (InfoStud info in Stud)
        {
            if ((info.Year > 2003) || ((info.Year > 2003) && (info.Month > 2)) || ((info.Year > 2003) && (info.Month == 2) && (info.Day > 10)))
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


