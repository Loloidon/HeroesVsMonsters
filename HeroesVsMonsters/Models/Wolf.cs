using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesVsMonsters.Models
{
    public class Wolf : Monsters
    {
        public int Leather;

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
    }
}
