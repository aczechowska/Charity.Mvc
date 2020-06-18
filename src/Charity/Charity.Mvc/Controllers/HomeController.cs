using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Charity.Mvc.Models;
using Charity.Mvc.Context;
using Charity.Mvc.Services.Interface;

namespace Charity.Mvc.Controllers
{
	public class HomeController : Controller
	{

		private readonly IInstitutionService _institutionService;


		public HomeController(IInstitutionService institutionService)
		{
			_institutionService = institutionService;
		}


		public IActionResult Index()
		{
			var institutionList = _institutionService.GetAll();
			return View(institutionList);
		}

		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}
