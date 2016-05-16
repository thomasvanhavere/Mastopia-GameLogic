using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP_Gamelogic_wfa
{
    abstract class BaseFood
    {

        public abstract int Money
        {
            get;
            set;
        }

        public abstract int Experience
        {
            get;
            set;
        }

        public abstract int Waste
        {
            get;
            set;
        }


        public abstract int TotalRecource
        {
            get;
            set;
        }

        public abstract int endTick { get; set; }

     

     
    }
}
