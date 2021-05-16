using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Model;

namespace API.Repositories
{
    public class DeliveryRepoMock : IDeliveryRepository
    {
        private List<Delivery> DataStore = new List<Delivery>();
        public Delivery Create(Delivery delivery)
        {
            delivery.Id = Guid.NewGuid();
            DataStore.Add(delivery);
            return delivery;
        }

        public Delivery Get(Guid id)
        {
            var delivery = DataStore.Single(x => x.Id == id);
            return delivery;
        }


        public void Delete(Guid id)
        {
            var delivery = Get(id);
            DataStore.Remove(delivery);
        }
        public Delivery Update(Guid id, Action<Delivery> change)
        {
            var delivery = Get(id);
            change(delivery);
            return delivery;
        }
    }
}
