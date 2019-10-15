using DarElFathElEslamy.Academy.Service.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DarElFathElEslamy.Academy.Service.Controllers
{
    public class BaseController : Controller
    {
        protected override void ExecuteCore()
        {
            int culture = 0;
            if (this.Session == null || this.Session["CurrentCulture"] == null)
            {

                int.TryParse(System.Configuration.ConfigurationManager.AppSettings["Culture"], out culture);
                this.Session["CurrentCulture"] = culture;
            }
            else
            {
                culture = (int)this.Session["CurrentCulture"];
            }
            // calling CultureHelper class properties for setting  
            CultureHelper.CurrentCulture = culture;
            
            
            base.ExecuteCore();
            
        }
        protected override IAsyncResult BeginExecuteCore(AsyncCallback callback, object state)
        {
            int culture = 0;
            if (this.Session == null || this.Session["CurrentCulture"] == null)
            {

                int.TryParse(System.Configuration.ConfigurationManager.AppSettings["Culture"], out culture);
                this.Session["CurrentCulture"] = culture;
            }
            else
            {
                culture = (int)this.Session["CurrentCulture"];
            }
            // calling CultureHelper class properties for setting  
            CultureHelper.CurrentCulture = culture;

           return base.BeginExecuteCore(callback, state);
        }
        protected override bool DisableAsyncSupport
        {
            get { return false; }
        }

    }
}