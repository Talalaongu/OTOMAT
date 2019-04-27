using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTOMAT
{
    class FA
    {
        private int _NumState;
        private int _NumAlpabet;
        public string[] Alphabet;
        public State[] Q;
        public int _FirstQ;
        public State[] F;

        public FA(int _state, int _alphabet)
        {
            _NumAlpabet = _alphabet;
            _NumState = _state;
            Alphabet = new string[_alphabet];
            Q = new State[_state];
            _FirstQ = 0;
            // chưa xong
        }
    }
}
