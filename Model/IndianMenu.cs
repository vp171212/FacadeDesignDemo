using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeLibrary.Model
{
    internal class IndianMenu : IMenu
    {
        public void DisplayMenu()
        {
            Console.WriteLine("Indian Menu:\nRajma\nJeeraRice\nPalak Paneer\nNaan\nKheer\n");
        }
    }
}
