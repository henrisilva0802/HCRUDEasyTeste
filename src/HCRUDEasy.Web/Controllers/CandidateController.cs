using System.Linq;
using Microsoft.AspNetCore.Mvc;
using HCRUDEasy.Domain;
using HCRUDEasy.Domain.Person.Candidate;
using HCRUDEasy.Web.ViewsModels;
using HCRUDEasy.Domain.Bank;

namespace HCRUDEasy.Web.Controllers
{
    public class CandidateController : Controller
    {
        private readonly CandidateStorer _candidateStorer;
        private readonly IGenericRepository<Candidate> _candidateRepository;
        private readonly BankInformationStorer _bankInformationStorer;
        private readonly IGenericRepository<BankInformation> _bankInformationRepository;

        public CandidateController( CandidateStorer candidateStorer, IGenericRepository<Candidate> candidateRepository,
                                    BankInformationStorer bankInformationStorer, IGenericRepository<BankInformation> bankInformationRepository)
        {
            _candidateStorer = candidateStorer;
            _candidateRepository = candidateRepository;
            _bankInformationStorer = bankInformationStorer;
            _bankInformationRepository = bankInformationRepository;
        }


        [HttpGet]
        public IActionResult Index(int id)
        {
            return View();
        }

        [HttpGet]
        public IActionResult CandidateForm()
        {
            return View();
        } 


        [HttpPost]
        public IActionResult CandidateForm(CandidateViewModel viewModel)
        {
            _candidateStorer.Store(
                viewModel.Id, 
                viewModel.Email, 
                viewModel.Name, 
                viewModel.Phone,
              viewModel.City, 
              viewModel.State, 
              viewModel.BankInformationId, 
              viewModel.BankInformationPersonName,
               viewModel.BankInformationCpf, 
               viewModel.BankInformationBankName, 
               viewModel.BankInformationAgency,
                viewModel.BankInformationAccountType, 
                viewModel.BankInformationAccountNumber
                );

            return RedirectToAction("Index");
        }


        [HttpGet]
        public IActionResult Details(int id)
        {
            var candidate = _candidateRepository.GetById(id);

            if (candidate != null)
            {
                var candidateViewModel = new CandidateViewModel
                {
                    //Peson
                    Id = candidate.Id,
                    City = candidate.City,
                    Email = candidate.Email,
                    Name = candidate.Name,
                    Phone = candidate.Phone,
                    State = candidate.State,
                    //Bank
                    BankInformationId = candidate.BankInformation.Id,
                    BankInformationPersonName = candidate.BankInformation.PersonName,
                    BankInformationBankName = candidate.BankInformation.BankName,
                    BankInformationAgency = candidate.BankInformation.Agency,
                    BankInformationAccountType = candidate.BankInformation.AccountType,
                    BankInformationAccountNumber = candidate.BankInformation.AccountNumber,
                    BankInformationCpf = candidate.BankInformation.Cpf
                };

                return View(candidateViewModel);
            }
            else
            {
                return View();
            }
            
        }


        [HttpGet]
        public IActionResult List()
        {
            var candidates = _candidateRepository.All();
            if (candidates!= null)
            {
                var candidateViewModel = candidates.Select( c=> new CandidateViewModel
                { 
                //Person
                Id = c.Id,
                Email = c.Email,
                Name = c.Name,
                });

                return View(candidateViewModel);
            }
            else
            {
                return View();
            }
        }


        [HttpGet]
        public IActionResult Edit(int id)
        {
            var candidate = _candidateRepository.GetById(id);

            if (candidate != null)
            {
                var candidateViewModel = new CandidateViewModel
                {
                    //Peson
                    Id = candidate.Id,
                    City = candidate.City,
                    Email = candidate.Email,
                    Name = candidate.Name,
                    Phone = candidate.Phone,
                    State = candidate.State,
                    //Bank
                    BankInformationId = candidate.BankInformation.Id,
                    BankInformationPersonName = candidate.BankInformation.PersonName,
                    BankInformationBankName = candidate.BankInformation.BankName,
                    BankInformationAgency = candidate.BankInformation.Agency,
                    BankInformationAccountType = candidate.BankInformation.AccountType,
                    BankInformationAccountNumber = candidate.BankInformation.AccountNumber,
                    BankInformationCpf = candidate.BankInformation.Cpf
                };

                return View(candidateViewModel);
            }
            else
            {
                return View();
            }
        }


        [HttpPost]
        public IActionResult Edit(CandidateViewModel viewModel)
        {
   
            _candidateStorer.Store(viewModel.Id,
              viewModel.Email,
                viewModel.Name,
                viewModel.Phone,
              viewModel.City, 
              viewModel.State,
              viewModel.BankInformationId, 
              viewModel.BankInformationPersonName,
               viewModel.BankInformationCpf, 
               viewModel.BankInformationBankName, 
               viewModel.BankInformationAgency,
                viewModel.BankInformationAccountType, 
                viewModel.BankInformationAccountNumber
                
                );

            return RedirectToAction("List");

        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var candidate = _candidateRepository.GetById(id);
            _bankInformationRepository.Remove(candidate.BankInformation);
            _candidateRepository.Remove(candidate);       
            return RedirectToAction("List");
        }
    }
    
}
