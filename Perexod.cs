using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Perexod
{
    static void Name()
    {
        string str = "Вернитесь обратно в меню или завершите работу.\n";
        Console.SetCursorPosition((Console.WindowWidth - str.Length) / 2, Console.CursorTop);
        Console.WriteLine(str);
    }
    static string[] text = new string[] { "Для перехода между пунктами воспользуйтесь стрелками вверх/вниз, в соответствии с выбором.\nДля подтверждения нажмите Enter.\n",
                "1 : В меню", "2 : Выход"};
    public void Work(List<InfoStud> Stud)
    {
        Console.CursorVisible = false;
        Menu men = new Menu();
        foreach (string text in text)
            Console.WriteLine(text);
        int num = keys();
        switch (num)
        {
            case 1: Console.Clear(); men.Meny(Stud); break;
            case 2: Console.Clear(); break;
        }
    }
    static void Text(int i)
    {
        if (i == 1)
        {
            Console.Clear();
            Name();
            Console.WriteLine(text[0]);
            Console.WriteLine(">  " + text[1] + "  <");
            Console.WriteLine(text[2]);
        }
        if (i == 2)
        {
            Console.Clear();
            Name();
            Console.WriteLine(text[0]);
            Console.WriteLine(text[1]);
            Console.WriteLine(">  " + text[2] + "  <");
        }
    }
    static int keys()
    {
        int num = 0;
        bool flag = false;
        do
        {
            ConsoleKeyInfo keyPushed = Console.ReadKey();
            if (keyPushed.Key == ConsoleKey.DownArrow && num != text.Length - 1)
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
                num = 2;
                Text(2);
            }
            if (keyPushed.Key == ConsoleKey.DownArrow && num == 2)
            {
                num = 0;
                Text(0);
            }
        } while (!flag);
        return num;
    }
}


