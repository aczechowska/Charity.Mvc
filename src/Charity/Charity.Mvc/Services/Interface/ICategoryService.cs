using Charity.Mvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Charity.Mvc.Services.Interface
{
    public interface ICategoryService
    {
        bool Create(Category categoryModel);
        Category Get(int id);
        IList<Category> GetAll();
        bool Update(Category categoryModel);
        bool Delete(int id);
    }
}
