using System;
using System.Collections.Generic;
using System.Text;

namespace HCRUDEasy.Domain.Person.Attributes.Work.Information
{
   public class Information : Entity
    {
        
        public string Skype { get; set; }
        public string Linkedin { get; set; }
        public string PortFolio { get; set; }
        public string WorkDisponibility { get; set; }
        public string WorkSchedule { get; set; }
        public string Salary { get; set; }
        public string PaymentType { get; set; }

    }
}
