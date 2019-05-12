using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindEFCRUD
{
    partial class Region
    {
        public int GetLastRegionID()
        {
            return DbHelper.CreateDbContext().Regions.AsNoTracking().Max(r => r.RegionID) + 1;
        }

        public override string ToString()
        {
            return RegionID.ToString();
        }
    }
}
