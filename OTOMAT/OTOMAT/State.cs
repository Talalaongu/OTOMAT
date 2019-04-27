using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTOMAT
{
    class State
    {
        private int _maxlength;
        public bool[] value;

        public State(int length)
        {
            _maxlength = length;
            value = new bool[length];
            for(int i = 0; i < length; i++)
            {
                value[i] = false;
            }
        }

        public static State operator +(State a, State b)
        {
            State kq = new State(a._maxlength);
            for(int i = 0;i < kq._maxlength; i++)
            {
                if(a.value[i] == true || b.value[i] == true)
                {
                    kq.value[i] = true;
                }
            }
            return kq;
        }

        public static State operator *(State a, State b)
        {
            State kq = new State(a._maxlength);
            for (int i = 0; i < kq._maxlength; i++)
            {
                if (a.value[i] == true && b.value[i] == true)
                {
                    kq.value[i] = true;
                }
            }
            return kq;
        }

        public static State operator =(State a, State b)
        {
            State kq = new State(a._maxlength);
            for (int i = 0; i < kq._maxlength; i++)
            {
                if (a.value[i] == true && b.value[i] == true)
                {
                    kq.value[i] = true;
                }
            }
            return kq;
        }
    }
}
