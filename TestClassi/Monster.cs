﻿using System;
using System.Windows.Forms;

namespace TestClassi
{
    class Monster
    {
        public string _name;
        private string name
        {
           get
            {
                return _name;
            }
        }
        public int _maxHp;
        private int maxHp
        {
            get
            {
                return _maxHp;
            }
        }

        public int _curHp;
        private int curHp
        {
            set
            {
                if (value < 0) value = 0;
                else if (value > _maxHp) value = _maxHp;
                _curHp = value;
            }

            get
            {
                return _curHp;
            }
        }


        public int _damage;
        private int damage
        {
            get
            {
                return _damage;
            }
        }
        public int _healFactor;
        private int healFactor
        {
            get
            {
                return _healFactor;
            }
}

public Monster(string name, int maxHp, int damage, int healFactor = 0)
        {
            _name = name;
            _maxHp = maxHp;
            curHp = maxHp;
            _damage = damage;
            _healFactor = healFactor;
            describe();
        }

        public string describe()
        {
            string output = "Questo è " + name + "\r\n";
            output += "HP: " + curHp + "\r\n";
            output += "DAMAGE: " + damage + "\r\n";

            return output;
        }

        public void describe(TextBox t)
        {
            t.Text = describe();
        }

        public void heal(Monster target)
        {
            if (healFactor == 0)
            {
                Console.WriteLine("Non hai il potere di curare nessuno");
                return;
            }

            if (curHp <= 0)
            {
                Console.WriteLine("Non puoi curare nessuno da morto");
                return;
            }

            if (target.curHp <= 0)
            {
                Console.WriteLine(target.name + " è esausto e non puoi resuscitarlo con la cura.");
                return;
            }

            target.curHp += healFactor;

            if (target.curHp > target.maxHp)
            {
                target.curHp = target.maxHp;
            }

            Console.WriteLine(name + " usa cura su " + target.name);
            Console.WriteLine(target.name + " è stato curato e ora ha " + target.curHp + "/" + target.maxHp + " HP");
        }

        public void heal()
        {
            heal(this);
        }

        public void attack(Monster target)
        {
            if (curHp <= 0)
            {
                Console.WriteLine("Non puoi attaccare nessuno da morto");
                return;
            }

            if (target.curHp <= 0)
            {
                Console.WriteLine(target.name + " è già esausto, non infierire.");
                return;
            }

            Console.WriteLine(name + " attacca " + target.name);
            Console.WriteLine(name + " fa " + damage + " danni a " + target.name);
            target.curHp -= damage;
            
            if (target.curHp <= 0 )
            {
                target.curHp = 0;
                Console.WriteLine(target.name + " è esausto.");
            } else
            {
                Console.WriteLine("a " + target.name + " rimangono " + target.curHp + " hp");
            }
        }
    }
}