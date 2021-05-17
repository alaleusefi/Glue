using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Logic
{
    public interface IDeliveryLogic
    {
        public Delivery Approve(Guid Id);
        public Delivery Cancel(Guid Id);
        public Delivery Expire(Guid Id);
        public Delivery Complete(Guid Id);
    }
}
