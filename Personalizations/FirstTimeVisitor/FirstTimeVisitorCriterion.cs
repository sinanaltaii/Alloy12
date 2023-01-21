using System.Security.Principal;
using EPiServer.Personalization.VisitorGroups;

namespace Alloy12.Personalizations.FirstTimeVisitor
{
    [VisitorGroupCriterion(
        Category = "First time visitors and returning visitors",
        Description = "Shows welcome back text to first time visitors",
        DisplayName = "First time and returning visitors"
    )]
    public class FirstTimeVisitorCriterion : CriterionBase<FristTimeVisitorModel>
    {
        public override bool IsMatch(IPrincipal principal, HttpContext httpContext)
        {
            var cookieName = httpContext.Request.Cookies[Model.EpiNumberOfVisits];
            var count = cookieName.Split(',')[0];
            int.TryParse(count, out var numberOfVisists);

            return numberOfVisists == 1;
        }
    }
}