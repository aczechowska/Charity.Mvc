using Charity.Mvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Charity.Mvc.Services.Interface
{
    public interface IDonationService
    {
        bool Create(Donation donationModel);
        Donation Get(int id);
        IList<Donation> GetAll();
        bool Update(Donation donationModel);
        bool Delete(int id);
    }
}
