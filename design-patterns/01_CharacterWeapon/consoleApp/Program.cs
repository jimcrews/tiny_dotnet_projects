using System;
using lib;

namespace consoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            IWeapon w = new ShortSword();
            var c1 = new Assassin(w);

            c1.Fight();

            w = new Knife();
            c1.weapon = w;

            c1.Fight();
        }
    }
}
