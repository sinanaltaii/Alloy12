using Alloy12.Models.Pages;
using EPiServer.Find;
using EPiServer.Find.Cms;
using EPiServer.Find.Framework;
using EPiServer.Find.Framework.Statistics;
using EPiServer.Find.Statistics;
using EPiServer.Find.UnifiedSearch;

namespace Alloy12.Helpers
{
    public class SearchHelper : ISearchHelper
    {
        public UnifiedSearchResults UnifiedSearchForQuery(string query)
        {
            // Url: https://docs.developers.optimizely.com/digital-experience-platform/v1.1.0-search-and-navigation/docs/search-statistics
            // what does StatisticsTrack() do? It seems that Track() does just fine.
            var unifiedSearch = SearchClient.Instance
                .UnifiedSearch()
                .For(query, x => x.Analyzer = Language.English.Analyzer)
                .Track()
                .StatisticsTrack();
            var searchResult = unifiedSearch.GetResult();
            
            return searchResult;
        }

        public IContentResult<IContent> SearchForContent(string query)
        {
            // Search<IContent> could be any page type
            var searchResult = SearchClient.Instance
                .Search<SitePageData>()
                .For(query, x => x.Analyzer = Language.English.Analyzer)
                .FilterForVisitor() // Group of filters including ExcludeDelete, PublishedInCurrentLanguage, and FilterOnReadAccess https://docs.developers.optimizely.com/digital-experience-platform/v1.1.0-search-and-navigation/docs/filters
                .Track()
                .StatisticsTrack()
                .GetContentResult();
            
            return searchResult;
        }
    }
}
