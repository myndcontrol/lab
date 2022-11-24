using Microsoft.VisualStudio.TestTools.UnitTesting;
using l;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace l.Tests
{
    [TestClass()]
    public class charactercharacterTests
    {
        private string name;
        public string Name { get { return name; } set { name = value; } }

        private bool type;
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

        public character actual = new character();
        public string aname = "v";
        public bool atype = false;
        int adamage = 10;
        int amaxhp = 10;
        int ahp = 10;
        int aregenhp = 1;
        private character newcharacter = new character();

        public void InitializeTest()
        {
            name = "v";
            type = false;
            damage = 10;
            maxhp = 10;
            hp = 10;
            regenhp = 1;      
            newcharacter.Name = name;
            newcharacter.Type = type;
            newcharacter.Damage = damage;
            newcharacter.maxHP = maxhp;
            newcharacter.HP = hp;
            newcharacter.regenHP = regenhp;            
            actual.Name = aname;
            actual.Type = atype;
            actual.Damage = adamage;
            actual.maxHP = amaxhp;
            actual.HP = ahp;
            actual.regenHP = aregenhp;
            Assert.AreEqual(newcharacter, actual);
        }


        [TestMethod()]
        public void attackTest(character target)
        {
            actual = target;
            actual.HP -= damage;
            Assert.AreEqual(target.HP - damage, actual.HP);
        }

        [TestMethod()]
        public void healTest(character target)
        {
            actual = target;
            if (type == true)
            {
                if (actual.HP + healP <= actual.maxHP)
                {
                    actual.HP += healP;
                    
                }
                    
                else
                {
                    Assert.AreEqual(actual.maxHP, actual.HP);
                    actual.HP = actual.maxHP;
                }
                    
            }
        }

        [TestMethod()]
        public void regenTest()
        {
            actual = newcharacter;
            if (actual.HP + actual.regenHP > actual.maxHP)
            {
                actual.HP = actual.maxHP;
                Assert.AreEqual(actual.HP, newcharacter.maxHP);
            }            
            else
            {
                actual.HP += actual.regenHP;
                Assert.AreEqual(actual.HP, newcharacter.HP + regenhp);
            }
                
        }
    }
}