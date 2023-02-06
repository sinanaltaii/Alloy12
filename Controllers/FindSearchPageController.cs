using Alloy12.Helpers;
using Alloy12.Models.Pages;
using Alloy12.Models.ViewModels;
using EPiServer.Framework.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace Alloy12.Controllers
{
    [TemplateDescriptor(Inherited = false)]
    public class FindSearchPageController : PageControllerBase<SearchPage>
    {
        private readonly ISearchHelper _searchHelper;

        public FindSearchPageController(ISearchHelper searchHelper)
        {
            _searchHelper = searchHelper;
        }
        public ActionResult Index(SearchPage currentPage, string q)
        {
            var model = new FindSearchPageViewModel(currentPage, q);
            if (string.IsNullOrWhiteSpace(q))
            {
                return View(model);
            }

            //model.UnifiedSearchQueryResults = _searchHelper.UnifiedSearchForQuery(q);
            model.ContentSearchQueryResults = _searchHelper.SearchForContent(q);
            return View(model);
        }
    }
}
