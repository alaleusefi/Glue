using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Repositories
{
    public interface IDeliveryRepository
    {
        public Delivery Create(Delivery delivery);
        public Delivery Get(int id);
        public Delivery Update(int id, Action<Delivery> change);
        public void Delete(int id);
    }
}
