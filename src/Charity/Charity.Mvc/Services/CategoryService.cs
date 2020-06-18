using Charity.Mvc.Context;
using Charity.Mvc.Models;
using Charity.Mvc.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Charity.Mvc.Services
{
    public class CategoryService : ICategoryService
    {
		private readonly CharityContext _context;

		public CategoryService(CharityContext context)
		{
			this._context = context;
		}

        public bool Create(Category categoryModel)
        {
            _context.Categories.Add(categoryModel);
            return _context.SaveChanges() > 0;
        }

        public Category Get(int id)
        {
            return _context.Categories.SingleOrDefault(x => x.ID == id);
        }

        public IList<Category> GetAll()
        {
            return _context.Categories.ToList();
        }

        public bool Update(Category categoryModel)
        {
            _context.Categories.Update(categoryModel);
            return _context.SaveChanges() > 0;
        }


        public bool Delete(int id)
        {
            var category = _context.Categories.SingleOrDefault(b => b.ID == id);
            if (category == null)
                return false;

            _context.Categories.Remove(category);
            return _context.SaveChanges() > 0;
        }
    }
}
