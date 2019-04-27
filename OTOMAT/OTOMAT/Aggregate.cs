using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTOMAT
{
    class Aggregate
    {
        private State _Element;
        public Aggregate _Next;

        public State Element { get => _Element; set => _Element = value; }

        //public Aggregate()
        //{
        //    _Next = null;
        //}

        public bool IsMember(State q, Aggregate A)
        {

            return false;
        }
    }
}
