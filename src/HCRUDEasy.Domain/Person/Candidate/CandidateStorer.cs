using HCRUDEasy.Domain.Bank;
using HCRUDEasy.Domain.Person.Attributes.Work.Information;
using HCRUDEasy.Domain.Person.Attributes.Work.Skill;

namespace HCRUDEasy.Domain.Person.Candidate
{
   public class CandidateStorer
    {
        private readonly IGenericRepository<Candidate> _candidateRepository;
        private readonly IGenericRepository<BankInformation> _bankInformationRepository;

        public CandidateStorer(IGenericRepository<Candidate> candidateRepository, 
            IGenericRepository<BankInformation> bankInformationRepository)
        {
            _candidateRepository = candidateRepository;
            _bankInformationRepository = bankInformationRepository;

        }

        public void Store(int personId, string personEmail, string personName, string personPhone, 
                            string personCity, string personState, int bankInformationId, 
                            string bankInformationPersonName, string bankInformationCpf, 
                            string bankInformationBankName, string bankInformationAgency, 
                            string bankInformationAccountType, string bankInformationAccountNumber)
        {
            var bankInformation = _bankInformationRepository.GetById(bankInformationId);
            var candidate = _candidateRepository.GetById(personId);

            if (candidate == null)
            {
                 bankInformation = new BankInformation(bankInformationPersonName, bankInformationCpf,
                                        bankInformationBankName, bankInformationAgency,
                                        bankInformationAccountType, bankInformationAccountNumber);
                _bankInformationRepository.Save(bankInformation);

                candidate = new Candidate(personEmail,personName,personPhone,personCity,personState,bankInformation);
                _candidateRepository.Save(candidate);
                
            }
            else
            {
                bankInformation.Update(bankInformationPersonName, bankInformationCpf,
                                        bankInformationBankName, bankInformationAgency,
                                        bankInformationAccountType, bankInformationAccountNumber);

                candidate.Update(personEmail, personName, personPhone, personCity, personState, bankInformation);
            }
        }
    }
}
