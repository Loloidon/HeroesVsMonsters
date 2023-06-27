using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesVsMonsters.Models
{
    public abstract class Hero
    {
        int Hp;
        int Strenght;
        int Endurance;




        public abstract int SetHp();
        public abstract int SetStrenght(List<int>big);
        public abstract int SetEndurance(List<int> big);
        public abstract int Attack();
    }
}
