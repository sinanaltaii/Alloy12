using System.ComponentModel.DataAnnotations;
using Alloy12.Business.EditorDescriptors;
using EPiServer.Shell.ObjectEditing;

namespace Alloy12.Models.Blocks
{

    [ContentType(DisplayName = "InfoBlock", GUID = "f9ddfe9a-4bd5-4401-a8eb-3c0208c5e35f", Description = "")]
    [SiteImageUrl]
    public class InfoBlock : BlockData
    {

        [CultureSpecific]
        [Display(GroupName = SystemTabNames.Content,
            Order = 100)]
        public virtual XhtmlString Text { get; set; }

        [SelectOne(SelectionFactoryType = typeof(ThemeSelectionFactory))]
        public virtual string Theme{ get; set; }
    }
}