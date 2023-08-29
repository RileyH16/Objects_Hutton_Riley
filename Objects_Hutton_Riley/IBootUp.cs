using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects_Hutton_Riley
{
    internal interface IBootUp
    {

        //Boolean property with automatic getter and setter
        public bool IsOn { get; set; }

         //Method called PowerOnOff
        public void PowerOnOff();

    }
}
