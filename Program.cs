using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    interface IItem
    {
        string Name { get; set; }
        int GoldValue { get; set; }

        void Equip();
        void Sell();
    }

    interface IDamagable
    {
        int Durability { get; set; }

        void TakeDemage(int _amount);
    }

    interface IPartOfQuest
    {
        
    }
    class Sword : IItem, IDamagable
    {
        public string Name { get ; set; }
        public int GoldValue { get; set; }
        public int Durability { get; set ; }

        public Sword(string _name)
        {
            Name = _name;
            GoldValue = 100;
            Durability = 200;
            
        }
        public void Equip()
        {
            Console.WriteLine($"{Name} equiped.");
        }

        public void Sell()
        {
            Console.WriteLine($"{Name} sold for ${GoldValue}.");
        }

        public void TakeDemage(int _amount)
        {
            Console.WriteLine($"{Name} was demaged by {_amount} points and {Name}'s durability is now at {Durability - _amount} points.");
        }
    }

    //class Axe : IItem, IDamagable
    //{
    //    public string Name { get ; set; }
    //    public int GoldValue { get; set; }
    //    public int Durability { get ; set ; }

    //    public Axe(string _name)
    //    {
    //        Name = _name;
    //        GoldValue = 80;
    //        Durability = 150;
    //    }
    //    public void Equip()
    //    {
    //        Console.WriteLine($"{Name} equiped.");
    //    }

    //    public void Sell()
    //    {
    //        Console.WriteLine($"{Name} sold for ${GoldValue}.");
    //    }

    //    public void TakeDemage(int _amount)
    //    {
    //        Console.WriteLine($"{Name} was demaged by {_amount} points and {Name}'s durability is now at {Durability - _amount} points.");
    //    }
    //}
    class Program
    {
        static void Main(string[] args)
        {
            Sword sword = new Sword("Sword Of Destiny");
            sword.Equip();
            sword.Sell();
            sword.TakeDemage(20);

            Console.WriteLine();

            //Axe axe = new Axe("Fury Axe");
            //axe.Equip();
            //axe.Sell();
            //axe.TakeDemage(20);

            Console.WriteLine();


            //test------------------
            //Console.WriteLine(axe is Axe);
            //Console.WriteLine("Outer block");
            //{
            //    string text = "Inner block";
            //    Console.WriteLine(text);
            //}
            Console.ReadKey();
        }
    }
}
