using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace AcademicPortal
{
    public class MvcApplication : System.Web.HttpApplication
	{
        private object GlobalConfiguration;

        protected void Application_Start()
		{
            object p = GlobalConfiguration.Configure(WebApiConfig.Register);
			AreaRegistration.RegisterAllAreas();
			FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
			RouteConfig.RegisterRoutes(RouteTable.Routes);
			BundleConfig.RegisterBundles(BundleTable.Bundles);
		}
	}
}
