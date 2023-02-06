using Alloy12.Models.Pages;
using EPiServer.Find.Cms;
using EPiServer.Find.UnifiedSearch;

namespace Alloy12.Models.ViewModels
{
    public class FindSearchPageViewModel : PageViewModel<SearchPage>
    {
        public FindSearchPageViewModel(SearchPage currentPage, string searchQuery) : base(currentPage)
        {
            SearchQuery = searchQuery;
        }

        public string SearchQuery { get; private set; }
        public UnifiedSearchResults UnifiedSearchQueryResults { get; set; }
        public IContentResult<IContent> ContentSearchQueryResults { get; set; }
    }
}
