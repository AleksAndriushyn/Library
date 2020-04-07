using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Interfaces
{
    public interface Author
    {
        string firstName { get; set; }
        string lastName { get; set; }
        DateTime dateOfBirth { get; set; }
        int books_amount { get; set; }
    }
}
