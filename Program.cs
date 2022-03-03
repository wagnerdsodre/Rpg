using System;
using Rpg.src.Entities;
using src.Entities;

namespace Rpg
{
    class Program
    {
        static void Main(string[] args)
        {

            Elves Elfo = new Elves("Timote",63,"Mago");
            Mago Mago = new Mago("Derick",42,"Mago");
            Dwarf Anao = new Dwarf("Herry",48,"Mago");
            Human Humano = new Human("Derick",100,"Mago");
            
            Console.WriteLine(Humano.Attack(7));
            Console.WriteLine(Anao.Attack(3));
            Console.WriteLine(Elfo.Attack(8));
            Console.WriteLine(Mago.Attack(3));
        }
    }
}
