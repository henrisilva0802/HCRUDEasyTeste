using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace HCRUDEasy.Web.ViewsModels
{
    public class CandidateViewModel
    {
        public int Id { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Phone { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string State { get; set; }

        public int BankInformationId { get; set; }
        [Required]
        public string BankInformationPersonName { get; set; }
        [Required]
        public string BankInformationCpf { get; set; }
        [Required]
        public string BankInformationBankName { get; set; }
        [Required]
        public string BankInformationAgency { get; set; }
        [Required]
        public string BankInformationAccountType { get; set; }
        [Required]
        public string BankInformationAccountNumber { get; set; }
     

        /*public string Skype { get; set; }
        public string Linkedin { get; set; }
        public string PortFolio { get; set; }

        public string WorkDisponibility { get; set; }


        public string WorkSchedule { get; set; }
        public string Salary { get; set; }
        public string PaymentType { get; set; } */


        public IEnumerable<CandidateViewModel> Candidates { get; set; }
    }
}
