//@panos30fyllou
using System;

namespace CC45
{
    class Trainer
    {
        public Trainer(string trainer_type, int trainer_attack, int trainer_health) {
            Type = trainer_type;
            Attack = trainer_attack;
            Health = trainer_health;
            Strong = false;
        }

        public bool Strong { get; set; }
        public int Attack { get; set; }
        public int Health { get; set; }
        public string Type { get; set; }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            Trainer tr1 = new Trainer(Console.ReadLine(), int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
            Trainer tr2 = new Trainer(Console.ReadLine(), int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
            if (tr1.Type.Equals("Fire")) {
                if (tr2.Type.Equals("Grass"))       tr1.Strong = true;
                else if (tr2.Type.Equals("Water"))  tr2.Strong = true;             
            } else if (tr1.Type.Equals("Water")) {
                if (tr2.Type.Equals("Fire"))        tr1.Strong = true;
                else if (tr2.Type.Equals("Grass"))  tr2.Strong = true;
            } else if (tr1.Type.Equals("Grass")) {
                if (tr2.Type.Equals("Water"))       tr1.Strong = true;
                else if (tr2.Type.Equals("Fire"))   tr2.Strong = true;
            }
            if (tr1.Strong) {   tr1.Attack *= 2;    tr2.Attack /= 2;    } 
            else            {   tr1.Attack /= 2;    tr2.Attack *= 2;    }
            while (true) {
                tr2.Health -= tr1.Attack;
                if (tr2.Health <= 0) break;
                else tr1.Health -= tr2.Attack;
                if (tr1.Health <= 0) break;
            }
            Console.WriteLine(tr2.Health <= 0? "Trainer 1 wins" : "Trainer 2 wins");
        }
    }
}