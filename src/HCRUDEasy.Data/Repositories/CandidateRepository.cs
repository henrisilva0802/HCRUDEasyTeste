using HCRUDEasy.Data.Contexts;
using HCRUDEasy.Domain;
using HCRUDEasy.Domain.Bank;
using HCRUDEasy.Domain.Person.Candidate;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace HCRUDEasy.Data.Repositories
{
    public class CandidateRepository : GenericRepository<Candidate> 
    {
        public CandidateRepository(ApplicationDbContext context):base(context)
        {
           
        }

        public override IEnumerable<Candidate> All()
        {
            return _context.Set<Candidate>().Include(c => c.BankInformation).AsEnumerable();
        }

        public override Candidate GetById(int id)
        {
            var query = _context.Set<Candidate>().Include(c => c.BankInformation).Where(e => e.Id == id);

            if (query.Any())
            {
                return query.First();
            }
            else
            {
                return null;
            }
        }

        public override void Remove(Candidate candidate)
        {
            _context.Set<BankInformation>().Remove(candidate.BankInformation);
            _context.Set<Candidate>().Remove(candidate);
        }


    }

}
