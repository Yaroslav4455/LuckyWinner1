using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LuckyWinner1
{
   static class IDU
    {
        static public string ID = "global";
    }
    static class NameN
    {
        static public string N = "global";
    }
    static class LoginL
    {
        static public string L = "global";
    }
    static class StatysS
    {
        static public string S = "Пользователь";
    }
    static class BronirovanieB
    {
        static public string B = "У вас ничего не забронированно";
    }
    static class BalansB
    {
        static public string B = "0";
    }







    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm1());
        }
    }
}
