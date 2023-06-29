using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesVsMonsters.Models
{
    public class Human : Hero
    {
        public override void SetStrenght(List<int> big6)
        {
            int strenght = 0;
            foreach (int i in big6)
            {
                strenght += i;
            }
            Strenght = strenght;
        }
        public override void SetEndurance(List<int> big6)
        {
            int endurance = 0;
            foreach (int i in big6)
            {
                endurance += i;
            }
            endurance += 1;
            Endurance = endurance;
        }
        public override void SetHp()
        {
            int hp = 0;
            int modifier = Modifier();
            hp = Endurance + modifier;

            Hp = hp;
        }
        public static List<int> Dice4()
        {

            Random r = new Random();
            List<int> big4 = new();
            for (int i = 0; i < 3; i++)
            {


                big4.Add(r.Next(1, 5));

            }
            big4.Sort();
            big4.Remove(0);
            return big4;

        }
        public static List<int> Dice6()
        {

            Random r = new Random();
            List<int> big6 = new();
            for (int i = 0; i < 3; i++)
            {


                big6.Add(r.Next(1, 7));

            }
            big6.Sort();
            big6.Remove(0);
            return big6;

        }
        public int Modifier()
        {
            int modifier = 0;
            int endurance = Endurance;
            int strenght = Strenght;
            if (endurance < 5)
                modifier = -1;

            else if (endurance < 10)
                modifier = 0;

            else if (endurance < 15)
                modifier = 1;
            else
            {
                modifier = 2;
            }
            return modifier;
        }
        public int ModifierStrenght()
        {
            int modifier = 0;
            int strenght = Strenght;
            if (strenght < 5)
                modifier = -1;

            else if (strenght < 10)
                modifier = 0;

            else if (strenght < 15)
                modifier = 1;
            else
            {
                modifier = 2;
            }
            return modifier;
        }

        public override void Attack()
        {
            int Dice = 0;
            foreach (int i in Dice4())
            {
                Dice += i;
            }
            int modifier = ModifierStrenght();
            ATK = Dice + modifier;

        }


    }

}
