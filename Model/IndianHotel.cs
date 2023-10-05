﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeLibrary.Model
{
    internal class IndianHotel : IHotel
    {
        public IMenu GetMenu()
        {
            return new IndianMenu();
        }
    }
}
