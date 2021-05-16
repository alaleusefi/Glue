using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public enum State { Created, Approved, Completed, Cancelled, Expired }
    public class Delivery
    {
        public Guid Id { get; set; }
        public State State { get; set; }
        public AccessWindow AccessWindow { get; set; }
        public Customer Recipient { get; set; }
        public Order Order { get; set; }
    }
}
