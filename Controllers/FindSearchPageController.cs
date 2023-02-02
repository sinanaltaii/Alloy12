using Alloy12.Models.Pages;
using Alloy12.Models.ViewModels;
using EPiServer.Find;
using EPiServer.Find.Cms;
using EPiServer.Find.Framework;
using EPiServer.Find.Framework.Statistics;
using EPiServer.Find.Statistics;
using EPiServer.Framework.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace Alloy12.Controllers
{
    [TemplateDescriptor(Default = true)]
    public class FindSearchPageController : PageControllerBase<SearchPage>
    {
        public ActionResult Index(SearchPage currentPage, string q)
        {
            var model = new FindSearchPageViewModel(currentPage, q);
            if (string.IsNullOrWhiteSpace(q))
            {
                return View(model);
            }
		 
		 // Url: https://docs.developers.optimizely.com/digital-experience-platform/v1.1.0-search-and-navigation/docs/search-statistics
            // what does StatisticsTrack() do? It seems that Track() does just fine.
            var unifiedSearch = SearchClient.Instance.UnifiedSearchFor(q).Track().StatisticsTrack();
            model.Results = unifiedSearch.GetResult();

            return View(model);
        }
    }
}
