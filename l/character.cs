using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l
{
    public class character
    {
        private string name;
        public string Name { get { return name; } set { name = value; } }

        private bool type; //true - healer, false - warrior

        public bool Type { get { return type; } set { type = value; } }

        private int damage;
        public int Damage { get { return damage; } set { damage = value; } }

        private int maxhp;
        public int maxHP { get { return maxhp; } set { maxhp = value; } }

        private int hp;
        public int HP { get { return hp; } set { hp = value; } }

        private int regenhp;
        public int regenHP { get { return regenhp; } set { regenhp = value; } }

        private int healP;
        public int HealP { get { return healP; } set { healP = value; } }

        public void attack(character target)
        {
            target.HP -= damage;
        }

        public void heal(character target)
        {
            if (type == true) 
            {
                if (target.HP + healP <= target.maxHP)
                    target.HP += healP;
                else
                    target.HP = target.maxHP;
            }          
        }

        public void regen()
        {
            if (HP + regenhp > maxHP)
                HP = maxHP;
            else
                HP += regenhp;
        }

    }
}
