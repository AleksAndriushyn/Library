using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Interfaces
{
    interface Readers_Card
    {
        string firstName { get; set; }
        string lastName { get; set; }
        DateTime date { get; set; }
        string book_title { get; set; }
    }
}
