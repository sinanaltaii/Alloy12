using EPiServer.Framework;
using EPiServer.Framework.Initialization;
using EPiServer.Find.Cms;
using EPiServer.Find.Cms.Conventions;
using EPiServer.Find.Cms.Module;

namespace Alloy12.Business.Initialization
{
    [InitializableModule]
    [ModuleDependency(typeof(IndexingModule))]
    public class FindInitializationModule : IInitializableModule
    {
        public void Initialize(InitializationEngine context)
        {
            ContentIndexer.Instance.Conventions.ForInstancesOf<ContentFolder>().ShouldIndex(x => false);
        }

        public void Uninitialize(InitializationEngine context)
        {
        }
    }
}