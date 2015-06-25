using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework01
{
    internal class Mora
    {
        private int whichOne;

        public int WhichOne
        {
            get { return whichOne; }
            set
            {
                if (value >= 3)
                {
                    whichOne = 3;
                }
                else
                {
                    whichOne = value;
                }
            }
        }

        private string[] typeOfMora = new string[4] { "剪刀", "石頭", "布", "不合規定的" };

        public string TypeOfMora
        {
            get { return typeOfMora[whichOne]; }
        }
    }
}