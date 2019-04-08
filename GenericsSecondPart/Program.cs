using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsSecondPart
{
    class Program
    {
        static void Main(string[] args)
        {
            using (HotelDataService service = new HotelDataService())
            {
                service.Add(new Hotel());
            }
        }
    }
}
