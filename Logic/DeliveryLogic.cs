using System;
using Logic.Repositories;
using Model;

namespace Logic
{
    public class DeliveryLogic : IDeliveryLogic
    {
        private readonly IDeliveryRepository Repo;
        public DeliveryLogic(IDeliveryRepository repo)
        {
            Repo = repo;
        }
        public Delivery Approve(Guid Id)
        {
           return Repo.Update(Id, x => x.State = State.Approved);
        }
        public Delivery Cancel(Guid Id)
        {
            return Repo.Update(Id, x => x.State = State.Cancelled);
        }
        public Delivery Expire(Guid Id)
        {
            return Repo.Update(Id, x => x.State = State.Expired);
        }
        public Delivery Complete(Guid Id)
        {
            return Repo.Update(Id, x => x.State = State.Completed);
        }
    }
}
