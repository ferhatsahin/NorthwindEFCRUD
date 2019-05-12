using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindEFCRUD
{
    class DbHelper
    {
        public static NorthwindContext CreateDbContext()
        {
            return new NorthwindContext();
        }
    }
}
