using Charity.Mvc.Context;
using Charity.Mvc.Models;
using Charity.Mvc.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Charity.Mvc.Services
{
    public class InstitutionService : IInstitutionService
	{
			private readonly CharityContext _context;

			public InstitutionService(CharityContext context)
			{
				this._context = context;
			}


        public bool Create(Institution institutionModel)
        {
            _context.Institutions.Add(institutionModel);
            return _context.SaveChanges() > 0;
        }

        public Institution Get(int id)
        {
            return _context.Institutions.SingleOrDefault(x => x.ID == id);
        }

        public IList<Institution> GetAll()
        {
            return _context.Institutions.ToList();
        }

        public bool Update(Institution institutionModel)
        {
            _context.Institutions.Update(institutionModel);
            return _context.SaveChanges() > 0;
        }


        public bool Delete(int id)
        {
            var institution = _context.Institutions.SingleOrDefault(b => b.ID == id);
            if (institution == null)
                return false;

            _context.Institutions.Remove(institution);
            return _context.SaveChanges() > 0;
        }
    }
}
