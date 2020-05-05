using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Sieve.Models;
using Sieve.Services;
using SieveTest.Model;
using SieveTest.Services;

namespace SieveTest.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public List<SuperHero> SuperHeroList { get; set; }

        [BindProperty]
        public SuperHero UpdateSuperHeroVm { get; set; }

        private IDataService _dataService { get; set; }

        private IFilterProcessor _filterProcessor { get; set; }

        public IndexModel(IDataService DataService, IFilterProcessor filterProcessor)
        {

            SuperHeroList = new List<SuperHero>();

            
            _dataService = DataService;
            _filterProcessor = filterProcessor;
        }

        public void OnGet()
        {
           

        }

        public JsonResult OnGetLoadData(FilterOptions model)
        {

            var SuperHeroList = _dataService.GetSuperHeros().AsQueryable();

            var returnValue = _filterProcessor.Process(SuperHeroList, model);
                 


           
            return new JsonResult(returnValue.Value);
        }

        public IActionResult OnPost()
        {
            return new OkResult();
        }
    }
}
