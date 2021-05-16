using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Logic
{
    public interface IDeliveryLogic
    {
        public Delivery Approve(Guid Id);
        //TODO: Cancel method
        //TODO: Expire method
        //TODO: Complete method
    }
}
