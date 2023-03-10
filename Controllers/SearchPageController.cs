using Alloy12.Models.Pages;
using Alloy12.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Alloy12.Controllers;

public class SearchPageController : PageControllerBase<SearchPage>
{
    public ViewResult Index(SearchPage currentPage, string q)
    {
        var model = new SearchContentModel(currentPage)
        {
            Hits = Enumerable.Empty<SearchContentModel.SearchHit>(),
            NumberOfHits = 0,
            SearchServiceDisabled = false,
            SearchedQuery = q
        };

        return View(model);
    }
}
