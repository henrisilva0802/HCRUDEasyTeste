using System;
using System.Collections.Generic;
using System.Text;

namespace HCRUDEasy.Domain.Person
{
   public abstract class Person: Entity
    {
       protected Person()
        {

        }
        protected Person(string email, string name, string phone, string city, string state)
        {
            Email = email;
            Name = name;
            Phone = phone;
            City = city;
            State = state;
        }
        public virtual string Email { get; set; }
        public virtual string Name { get; set; }
        public virtual string Phone { get; set; }
        public virtual string City { get; set; }
        public virtual string State { get; set; }
    }
}
