using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Library.Models
{
    public class Readers_Card
    {
       public int ID { get; set; }
       public string firstName { get; set; }
       public string lastName { get; set; }
       [DataType(DataType.Date)] 
       public DateTime date { get; set; }
       public string book_title { get; set; }
    }
}
