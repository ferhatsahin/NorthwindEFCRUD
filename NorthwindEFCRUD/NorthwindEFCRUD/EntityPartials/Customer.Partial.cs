﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindEFCRUD
{
    partial class Customer
    {
        public override string ToString()
        {
            return CompanyName;
        }
    }
}
