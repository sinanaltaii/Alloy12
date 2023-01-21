using EPiServer.Personalization.VisitorGroups;

namespace Alloy12.Personalizations.FirstTimeVisitor
{
    public class FristTimeVisitorModel : CriterionModelBase
    {
        public string EpiNumberOfVisits {get; set;}
        public override ICriterionModel Copy()
        {
            return ShallowCopy();
        }
    }
}