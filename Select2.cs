using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Select2
{
    static void Name()
    {
        string str = "Студенты, являющиеся должниками.\n";
        Console.SetCursorPosition((Console.WindowWidth - str.Length) / 2, Console.CursorTop);
        Console.WriteLine(str);
    }
    public void SelDol(List<InfoStud> Stud) //должники
    {
        int i = 1;
        int k = 0;
        int c = 0;
        Name();
        Perexod perexod = new Perexod();
        InfoStud inf = new InfoStud();
        foreach (InfoStud info in Stud)
        {
            for (int a = 0; a < info.Mark.Length; a++)
            {
                if ((info.Mark[a] == 3) || (info.Mark[a] == 4) || (info.Mark[a] == 5))
                {
                    k++;
                }
                else
                {
                    k = 0;
                    c = 1;
                    break;
                }
            }
            if (k == 0)
            {
                Console.WriteLine("{0}. " + info.FIO, i);
                i++;
            }
            k = 0;
        }
        if ((c == 0) && (i == 1))
            Console.WriteLine("Список пуст.\n");
        Console.WriteLine();
        perexod.Work(Stud);
    }
}

