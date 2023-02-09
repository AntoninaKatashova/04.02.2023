using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Menu
{
    static void Name()
    {
        string str = "Анализ студентов.\n";
        Console.SetCursorPosition((Console.WindowWidth - str.Length) / 2, Console.CursorTop);
        Console.WriteLine(str);
    }
    static string[] texts = new string[] { "Для перехода между пунктами воспользуйтесь стрелками вверх/вниз, в соответствии с выбором.\nДля подтверждения нажмите Enter.\n",
                "1 : Заполнение информации о студенте", "2 : Выдать студентов, которые учатся в заданной группе", "3 : Выдать студентов должников", "4 : Выдать студентов отличников", "5 : Выдать студентов моложе 20 лет", "6 : Выход" };
    public void Meny(List <InfoStud> Stud)
    {
        Console.CursorVisible = false;
        InfoStud student = new InfoStud();
        Select1 select1 = new Select1();
        Select2 select2 = new Select2();
        Select3 select3 = new Select3();
        Select4 select4 = new Select4();
        Console.ForegroundColor = ConsoleColor.Cyan;
        Name();
        foreach (string text in texts)
            Console.WriteLine(text);
        int num = keys();
        switch (num)
        {
            case 1: Console.Clear(); student.show(Stud); break;
            case 2: Console.Clear(); select1.SelGr(Stud); break;
            case 3: Console.Clear(); select2.SelDol(Stud); break;
            case 4: Console.Clear(); select3.SelOtl(Stud); break;
            case 5: Console.Clear(); select4.SelVoz(Stud); break;
            case 6: Console.Clear(); break;
        }
    }
    static void Text(int i)
    {
        if (i == 1)
        {
            Console.Clear();
            Name();
            Console.WriteLine(texts[0]);
            Console.WriteLine(">  " + texts[1] + "  <");
            Console.WriteLine(texts[2]);
            Console.WriteLine(texts[3]);
            Console.WriteLine(texts[4]);
            Console.WriteLine(texts[5]);
            Console.WriteLine(texts[6]);
        }
        if (i == 2)
        {
            Console.Clear();
            Name();
            Console.WriteLine(texts[0]);
            Console.WriteLine(texts[1]);
            Console.WriteLine(">  " + texts[2] + "  <");
            Console.WriteLine(texts[3]);
            Console.WriteLine(texts[4]);
            Console.WriteLine(texts[5]);
            Console.WriteLine(texts[6]);
        }
        if (i == 3)
        {
            Console.Clear();
            Name(); 
            Console.WriteLine(texts[0]);
            Console.WriteLine(texts[1]);
            Console.WriteLine(texts[2]);
            Console.WriteLine(">  " + texts[3] + "  <");
            Console.WriteLine(texts[4]);
            Console.WriteLine(texts[5]);
            Console.WriteLine(texts[6]);
        }
        if (i == 4)
        {
            Console.Clear();
            Name();
            Console.WriteLine(texts[0]);
            Console.WriteLine(texts[1]);
            Console.WriteLine(texts[2]);
            Console.WriteLine(texts[3]);
            Console.WriteLine(">  " + texts[4] + "  <");
            Console.WriteLine(texts[5]);
            Console.WriteLine(texts[6]);
        }
        if (i == 5)
        {
            Console.Clear();
            Name();
            Console.WriteLine(texts[0]);
            Console.WriteLine(texts[1]);
            Console.WriteLine(texts[2]);
            Console.WriteLine(texts[3]);
            Console.WriteLine(texts[4]);
            Console.WriteLine(">  " + texts[5] + "  <");
            Console.WriteLine(texts[6]);
        }
        if (i == 6)
        {
            Console.Clear();
            Name();
            Console.WriteLine(texts[0]);
            Console.WriteLine(texts[1]);
            Console.WriteLine(texts[2]);
            Console.WriteLine(texts[3]);
            Console.WriteLine(texts[4]);
            Console.WriteLine(texts[5]);
            Console.WriteLine(">  " + texts[6] + "  <");
        }
    }
    static int keys()
    {
        int num = 0;
        bool flag = false;
        do
        {
            ConsoleKeyInfo keyPushed = Console.ReadKey();
            if (keyPushed.Key == ConsoleKey.DownArrow && num != texts.Length - 1)
            {
                num++;
                Text(num);
            }
            if (keyPushed.Key == ConsoleKey.UpArrow && num != 0)
            {
                num--;
                Text(num);
            }
            if (keyPushed.Key == ConsoleKey.Enter)
            {
                flag = true;
            }
            if (num == 0)
            {
                num = 6;
                Text(6);
            }
            if (keyPushed.Key == ConsoleKey.DownArrow && num == 6)
            {
                num = 0;
                Text(0);
            }
        } while (!flag);
        return num;
    }
}
