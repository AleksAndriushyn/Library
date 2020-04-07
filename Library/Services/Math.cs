using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Services
{
    public class Math: IMath
    {
        int a = 5;
        int b = 6;
        public int Count()
        {
            return a + b;
        }
    }
}
