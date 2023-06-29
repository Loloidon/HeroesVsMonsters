using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesVsMonsters.Models
{
    public abstract class Monsters
    {

        private int _hp;
        private int _endurance;
        private int _strenght;
        private int _atk;
        public int Hp
        {
            get
            {
                return _hp;
            }
            protected set
            {
                _hp = value;
            }
        }
        public int Strenght
        {
            get
            {
                return _strenght;
            }
            protected set
            {
                _strenght = value;
            }
        }
        public int Endurance
        {
            get
            {
                return _endurance;
            }
            protected set
            {
                _endurance = value;
            }
        }

        public int ATK
        {
            get
            {
                return _atk;
            }
            protected set
            {
                _atk = value;
            }
        }
        public abstract void SetHp();
        public abstract void SetStrenght(List<int> big);
        public abstract void SetEndurance(List<int> big);
        public abstract void Attack();
    }
}

