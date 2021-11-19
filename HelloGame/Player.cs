using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloGame
{
    class Player
    {
        private int m_Level = 1;
        public int Level
        {
            get { return m_Level; }
        }
        private string m_Nickname;
        public string Nickname
        {
            get
            { 
                return m_Nickname; 
            }
        }
        private int m_Blood;
        public int Blood
        {
            get
            {
                return m_Blood;
            }
        }

        //构造函数
        //重载构造函数
        public Player(string name,int blood,int level)
        {
            m_Nickname = name;
            m_Blood = blood;
            m_Level = level;
        }
        //函数签名：函数名 + 参数

        public void Eat(Apple apple)
        {
            m_Blood += apple.Blood;
        }
    
        public void Damage()
        {
            m_Blood -= 1;
        }

        public void Damage(int blood)
        {
            m_Blood -= blood;
        }

        public void Attack(Enemy enemy)
        {
            enemy.Damage();
        }
    
        public  string GetInfo()
        {
            var info = "昵称：" + m_Nickname + "  血量：" + m_Blood+" 等级： "+m_Level;
            return info;
        }
    }
}
