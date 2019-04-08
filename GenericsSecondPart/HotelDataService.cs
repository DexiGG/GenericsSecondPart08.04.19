using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsSecondPart
{
    public class HotelDataService : AbstractDataAccessServices<Hotel>
    {
        public override void Add(Hotel entity)
        {
            throw new NotImplementedException();
        }

        public override void Delete(Hotel entity)
        {
            throw new NotImplementedException();
        }

        public override List<Hotel> GetAll()
        {
            throw new NotImplementedException();
        }

        public override void Update(Hotel entity)
        {
            throw new NotImplementedException();
        }
    }
}
