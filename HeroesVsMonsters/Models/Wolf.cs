using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesVsMonsters.Models
{
    public class Wolf : Monsters
    {
        public int Leather { get; set; }
      

        public override int SetHp()
        {
            int endurance = SetStrenght(Dice6());
            int hp = 0;
            int modifier = Modifier();
            return endurance += modifier;
        }
        public override int SetStrenght(List<int> big)
        {
            int strenght = 0;
            foreach (int i in big)
            {
                strenght += big[i];
            }
            return strenght;
        }
        public override int SetEndurance(List<int> big)
        {
            int endurance = 0;
            foreach (int i in big)
            {
                endurance += big[i];
            }
            return endurance;
        }
        public override int Attack()
        {
            int Dice = 0;
            foreach (int i in Dice4())
            {
                Dice += i;
            }
            int modifier = ModifierStrenght();
            return Dice + modifier;

        }
        public static List<int> Dice4()
        {

            Random r = new Random();
            List<int> big4 = new();
            for (int i = 0; i < 3; i++)
            {


                big4.Add(r.Next(1, 4));

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


                big6.Add(r.Next(1, 6));

            }
            big6.Sort();
            big6.Remove(0);
            return big6;

        }
        public int Modifier()
        {
            int modifier = 0;
            int endurance = SetEndurance(Dice6());
            int strenght = SetStrenght(Dice6());
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
            int strenght = SetStrenght(Dice6());
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
        public void SpawnLeather()
        {
            
            foreach (int i in Dice4())
            {
                this.Leather += i;
                
            }
        }
    }
}
