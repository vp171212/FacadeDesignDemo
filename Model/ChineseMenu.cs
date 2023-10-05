using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeLibrary.Model
{
    internal class ChineseMenu : IMenu
    {
        public void DisplayMenu()
        {
            Console.WriteLine("Chinese Menu:\nMapo Tofu\nChowMein\nSpring Rolls\nWonton Soup\n");
        }
    }
}
