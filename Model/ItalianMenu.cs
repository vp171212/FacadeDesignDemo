using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeLibrary.Model
{
    internal class ItalianMenu : IMenu
    {
        public void DisplayMenu()
        {
            Console.WriteLine("Italian Menu:\nSpaghetti\nPizza\nPasta\nPolenta\nArancini\n");

        }
    }
}
