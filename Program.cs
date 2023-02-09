using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Program
{
    static void Main()
    {
        Menu menu = new Menu();
        List<InfoStud> Stud = new List<InfoStud>();
        menu.Meny(Stud);
    }
}