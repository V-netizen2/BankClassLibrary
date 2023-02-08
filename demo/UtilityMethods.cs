using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
    static  class UtilityMethods
    {
        //A method for text inputs
        public static string ReadTextInput(string aMessage)
        {
            string returnValue;
            Console.WriteLine(aMessage);
            returnValue = Console.ReadLine();
            return returnValue;

        }
        public static void ReadTextInput(string aMessage , ref string aReturnValue)
        {
            aReturnValue = ReadTextInput(aMessage);
        }
        //A method for numeric inputs
        public static int ReadNumericInput(string aMessage)
        {
            int returnValue;
            Console.WriteLine(aMessage);
            returnValue  = Convert.ToInt32(Console.ReadLine());
            return returnValue;
        }
        public static void ReadNumericInput(string aMessage,ref int aReturnValue)
        {
            aReturnValue = ReadNumericInput(aMessage);
        }
        public static void PressAnyKeyToContinue()
        {
            Console.WriteLine("Press Any key To Continue");
            Console.ReadKey();
        }
    }
}
