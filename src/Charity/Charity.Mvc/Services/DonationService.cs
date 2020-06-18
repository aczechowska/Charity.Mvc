using Charity.Mvc.Context;
using Charity.Mvc.Models;
using Charity.Mvc.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Charity.Mvc.Services
{
    public class DonationService : IDonationService
    {
        private readonly CharityContext _context;

        public DonationService(CharityContext context)
        {
            this._context = context;
        }


        public bool Create(Donation donationModel)
        {
            _context.Donations.Add(donationModel);
            return _context.SaveChanges() > 0;
        }

        public Donation Get(int id)
        {
            return _context.Donations.SingleOrDefault(x => x.ID == id);
        }

        public IList<Donation> GetAll()
        {
            return _context.Donations.ToList();
        }

        public bool Update(Donation donationModel)
        {
            _context.Donations.Update(donationModel);
            return _context.SaveChanges() > 0;
        }


        public bool Delete(int id)
        {
            var donation = _context.Donations.SingleOrDefault(b => b.ID == id);
            if (donation == null)
                return false;

            _context.Donations.Remove(donation);
            return _context.SaveChanges() > 0;
        }
    }
}
