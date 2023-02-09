using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Select3
{
    static void Name()
    {
        string str = "Студенты, являющиеся отличниками.\n";
        Console.SetCursorPosition((Console.WindowWidth - str.Length) / 2, Console.CursorTop);
        Console.WriteLine(str);
    }
    public void SelOtl(List<InfoStud> Stud) //отличники
    {
        int i = 1;
        int k = 0;
        int c = 0;
        Name();
        Perexod perexod = new Perexod();
        InfoStud inf = new InfoStud();
        foreach (InfoStud info in Stud)
        {
            k = 0;
            for (int a = 0; a < info.Mark.Length; a++)
            {
                if (info.Mark[a] == 5)
                    k++;
            }
            if (k == info.Mark.Length)
            {
                Console.WriteLine("{0}. " + info.FIO, i);
                i++;
                c = 1;
            }
            
        }
        if (c == 0)
            Console.WriteLine("Список пуст.\n");
        Console.WriteLine();
        perexod.Work(Stud);
    }
}

