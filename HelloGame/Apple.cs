using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloGame
{
    class Apple
    {
        private int m_Blood;
        public int Blood
        {
            get
            {
                return m_Blood;
            }
        }
        public Apple(int initBlood)
        {
            m_Blood = initBlood;
        }


    }
}
