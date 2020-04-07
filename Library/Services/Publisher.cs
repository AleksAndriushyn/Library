using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Services
{
    public class Publisher: IPublisher
    {
        public string Publish()
        {
            return "Andriushyn Oleksiy. Age: 19. Student of KPI";
        }
    }
}
