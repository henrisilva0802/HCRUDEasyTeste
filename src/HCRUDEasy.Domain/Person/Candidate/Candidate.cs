using HCRUDEasy.Domain.Bank;
using HCRUDEasy.Domain.Person.Attributes.Work.Information;
using HCRUDEasy.Domain.Person.Attributes.Work.Skill;

namespace HCRUDEasy.Domain.Person.Candidate
{
    public class Candidate : Person
    {
      private Candidate()
      {

      }
        public Candidate(string email, string name, string phone, string city, string state, 
                        BankInformation bankInformation)  
                        :base(email,name,phone,city,state)
       {
            BankInformation = bankInformation;
        }
     
       //public Information Information { get; set; }
      // public Skill Skill { get; set; }
      // public BankInformation BankInformation { get; set; }

        public void Update(string email, string name, string phone, 
                    string city, string state, BankInformation bankInformation)
                       
        {
            Email = email;
            Name = name;
            Phone = phone;
            City = city;
            State = state;
            BankInformation = bankInformation;
        }


        public BankInformation BankInformation { get; set; }
    }
}
