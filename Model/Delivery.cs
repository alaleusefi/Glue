using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        public void Validate()
        {
            if (Id == null || Id == new Guid())
                throw new ValidationException($"Value of {nameof(Id)} cannot be null");
            if (AccessWindow == null)
                throw new ValidationException($"Value of {nameof(AccessWindow)} cannot be null");
            if (Recipient == null)
                throw new ValidationException($"Value of {nameof(Recipient)} cannot be null");
            if (Order == null)
                throw new ValidationException($"Value of {nameof(Order)} cannot be null");
        }
    }
}
