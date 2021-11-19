using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloGame
{
    class Enemy
    {
        private int m_Blood=1;
        public int Blood
        {
            get
            {
                return m_Blood;
            }
        }

        public int Damage()
        {
            m_Blood -= 1;
            return m_Blood;
        }

        public int Damage(int blood)
        {
            m_Blood -= blood;
            return m_Blood;
        }
    }
}
