
using Assignment1.Services;

IMenu menu = new MenuService(filepath);
do
{
    menu.MainMenu();
} while (true);