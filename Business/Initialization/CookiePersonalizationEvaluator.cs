using Alloy12.Personalizations;
using EPiServer.ServiceLocation;
using System.Web;
namespace Alloy12.Business.Initialization
{
    [ServiceConfiguration(typeof(IPersonalizationEvaluator), IncludeServiceAccessor = false)]
    public class CookiePersonalizationEvaluator : IPersonalizationEvaluator
    {
        public const string PersonalizeCookie = "Personalize";
        private readonly ServiceAccessor<HttpRequest> _requestAccessor;

        public CookiePersonalizationEvaluator(ServiceAccessor<HttpRequest> requestAccessor)
        {
            _requestAccessor = requestAccessor;
        }

        public bool Personalize()
        {
            return _requestAccessor()?.Cookies[PersonalizeCookie] != null;
        }
    }
}