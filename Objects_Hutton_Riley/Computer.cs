using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects_Hutton_Riley
{
    internal class Computer : IBootUp
    {

        //Bool with getter and setter from IBootUp
        public bool IsOn { get; set; }


        //Automatic string properties for Brand and Type
        public string Brand { get; set; }

        public string Type { get; set; }


        /// <summary>
        /// Constructor with parameter for brand, type, and ison
        /// </summary>
        /// <param Brand="brand"></param>
        /// <param Type="type"></param>
        /// <param IsOn="isOn"></param>
        public Computer(string brand, string type, bool isOn)
        {
            Brand = brand;
            Type = type;
            IsOn = isOn;
        }


        //Defines the PowerOnOff method
        public void PowerOnOff()
        {
            //Sets the IsOn to the opposite of the current value
            IsOn = !IsOn;

            //If IsOn is true, "The computer is booting up!" will be printed
            if (IsOn == true)
            {
                Console.WriteLine("The computer is booting up!");
            }
            //If false, "The computer is shutting down!" will be printed
            else
            {
                Console.WriteLine("The computer is shutting down!");
            }
        }

        
        public override string ToString()
        {

            return $"The computer is made by {Brand} and is a(n) {Type} computer, it is on: {IsOn}!";

        }

    }
}
