
using HCRUDEasy.Domain;

namespace HCRUDEasy.Domain.Bank
{
    public class BankInformationStorer
    {
        private readonly IGenericRepository<BankInformation> _bankInformationRepository;

        public BankInformationStorer(IGenericRepository<BankInformation> bankInformationRepository)
        {
            _bankInformationRepository = bankInformationRepository;
        }

        public void Store(int id, string personName, string cpf, string bankName, string agency,
                                string accountType, string accountNumber)
        {
            var bankInformation = _bankInformationRepository.GetById(id);
            if (bankInformation == null)
            {
                bankInformation = new BankInformation(personName,cpf,bankName,agency,accountType,accountNumber);
                _bankInformationRepository.Save(bankInformation);
            }
            else
            {
                bankInformation.Update(personName, cpf, bankName, agency, accountType, accountNumber);
            }
        }
    }
}
