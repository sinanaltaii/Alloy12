using EPiServer.Find.Cms;
using EPiServer.Find.UnifiedSearch;

namespace Alloy12.Helpers;

public interface ISearchHelper
{
    UnifiedSearchResults UnifiedSearchForQuery(string query);
    IContentResult<IContent> SearchForContent(string query);
}