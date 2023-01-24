using EPiServer.ServiceLocation;
using EPiServer.Shell.ObjectEditing;

namespace Alloy12.Business.EditorDescriptors
{
    [ServiceConfiguration]
    public class ThemeSelectionFactory : ISelectionFactory
    {
        public IEnumerable<ISelectItem> GetSelections(ExtendedMetadata metadata)
        {
            return new List<ISelectItem>()
            {
                new SelectItem() { Text = "None", Value = "" },
                new SelectItem() { Text = "Info", Value = ".info" },
                new SelectItem() { Text = "Alert", Value = ".alert" }
            };
        }
    }
}