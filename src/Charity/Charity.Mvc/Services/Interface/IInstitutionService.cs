using Charity.Mvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Charity.Mvc.Services.Interface
{
    public interface IInstitutionService
    {
        bool Create(Institution institutionModel);
        Institution Get(int id);
        IList<Institution> GetAll();
        bool Update(Institution institutionModel);
        bool Delete(int id);
    }
}
