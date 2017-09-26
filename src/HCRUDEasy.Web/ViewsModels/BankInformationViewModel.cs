using HCRUDEasy.Domain.Bank;
using HCRUDEasy.Domain.Person;
using HCRUDEasy.Domain.Person.Attributes.Work.Information;
using HCRUDEasy.Domain.Person.Attributes.Work.Skill;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HCRUDEasy.Web.ViewsModels
{
    public class BankVieq
    {
      
        public int BankInformationId { get; set; }
        public string BankInformationPersonName { get; set; }
        public string BankInformationCpf { get; set; }
        public string BankInformationBankName { get; set; }
        public string BankInformationAgency { get; set; }
        public string BankInformationAccountType { get; set; }
        public string BankInformationAccountNumber { get; set; }
    }
}
