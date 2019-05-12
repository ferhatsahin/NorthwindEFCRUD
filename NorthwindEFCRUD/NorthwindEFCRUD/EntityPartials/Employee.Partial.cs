using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindEFCRUD
{
    partial class Employee
    {
        public string FullName { get => $"{FirstName} {LastName}"; }
        public override string ToString()
        {
            return FullName;
        }
    }
}
