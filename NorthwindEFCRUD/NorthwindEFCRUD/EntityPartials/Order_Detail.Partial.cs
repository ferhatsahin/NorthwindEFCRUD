using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindEFCRUD
{
    partial class Order_Detail
    {
        public override string ToString()
        {
            return $"{Quantity} {Product.ProductName} - {UnitPrice} ₺";
        }
    }
}
