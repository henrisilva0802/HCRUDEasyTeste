using System;
using System.Collections.Generic;
using System.Text;

namespace HCRUDEasy.Domain
{
   public abstract class Entity
    {
        public int Id { get; protected set; }
    }
}
