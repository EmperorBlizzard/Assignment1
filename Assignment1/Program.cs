
using Assignment1.Services;
using Assignment1.Model;
using Newtonsoft.Json;
using System.Collections.Generic;


IMenuService menu = new MenuService();

do
{
    Console.Clear();

    menu.MainMenu();
    Console.ReadKey();

} while (true);