using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Model;

namespace API.Repositories
{
    public class DeliveryRepoMock : IDeliveryRepository
    {
        private List<Delivery> DataStore= new List<Delivery>();
        public Delivery Create(Delivery delivery)
        {
            var existingDelivery = DataStore.Find(x => x.Id == delivery.Id);
            if (existingDelivery != null)
                throw new Exception($"A {nameof(Delivery)} with the id of {delivery.Id} already exists");

            DataStore.Add(delivery);
            return delivery;
        }

        public Delivery Get(int id)
        {
            var delivery = DataStore.Single(x => x.Id == id);
            return delivery;
        }


        public void Delete(int id)
        {
            var delivery = Get(id);
            DataStore.Remove(delivery);
        }
        public Delivery Update(int id, Action<Delivery> change)
        {
            var delivery = Get(id);
            change(delivery);
            return delivery;
        }
    }
}
