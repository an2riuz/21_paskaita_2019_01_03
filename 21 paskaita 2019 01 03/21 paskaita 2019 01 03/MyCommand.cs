using System;
namespace _21_paskaita_2019_01_03
{
    internal class MyCommand : Command
    {
        public override void Execute()
        {
            Console.WriteLine("Execute!");
        }
    }
}