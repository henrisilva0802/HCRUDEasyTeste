namespace HCRUDEasy.Domain.Bank
{
    public class BankInformation: Entity
    {

        private BankInformation()
        {

        }


        public BankInformation(string personName, string cpf, string bankName, string agency, 
                                string accountType, string accountNumber)
        {
            PersonName = personName;
            Cpf = cpf;
            BankName = bankName;
            Agency = agency;
            AccountType = accountType;
            AccountNumber = accountNumber;
        }

        public void Update(string personName, string cpf, string bankName, string agency,
                                string accountType, string accountNumber)
        {
            PersonName = personName;
            Cpf = cpf;
            BankName = bankName;
            Agency = agency;
            AccountType = accountType;
            AccountNumber = accountNumber;
        }

        public string PersonName { get; set; }
        public string Cpf { get; set; }
        public string BankName { get; set; }
        public string Agency { get; set; }
        public string AccountType { get; set; }
        public string AccountNumber { get; set; }

    }
}
