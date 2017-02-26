using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestClassi
{
    public partial class Form1 : Form
    {
        private List<Monster> monsters;

        public Form1()
        {
            InitializeComponent();
            monsters = Deserializer.deserializeMonsters();

            /* foreach (Monster m in monsters)
            {
                Console.WriteLine(m.GetType());

                if (m is Fire_Monster) //if (m.GetType() == typeof(Fire_Monster))
                {
                    Fire_Monster f = m as Fire_Monster;
                    Console.WriteLine(f.fireDamage);
                }
            } */
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            renderMonster(curMonsterIndex);
            //Console.WriteLine(monsters[0].describe());
        }
        private Monster addMonster(Monster m)
        {
            monsters.Add(m);
            return m;
        }

        private int curMonsterIndex = 0;

        private void renderMonster(int monsterIndex)
        {
            enemyImg.Image = monsters[monsterIndex].image;
        }

        private void prevButt_Click(object sender, EventArgs e)
        {
            if (curMonsterIndex == 0) return;
            curMonsterIndex--;
            renderMonster(curMonsterIndex);
        }

        private void nextButt_Click(object sender, EventArgs e)
        {
            if (curMonsterIndex == monsters.Count - 1) return;
            curMonsterIndex++;
            renderMonster(curMonsterIndex);
        }
    }
    }
