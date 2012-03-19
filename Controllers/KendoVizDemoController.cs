using System;
using System.Linq;
using System.Web.Mvc;
using Orchard.Environment.Extensions;
using Orchard.Themes;
using Orchard.UI.Admin;

namespace Kendo.DataViz.Controllers
{
    [OrchardFeature("Kendo.DataViz.Demos")]
    public class KendoVizDemoController : Controller
    {
        public KendoVizDemoController() 
        {
            
        }

        [Admin]
        public ActionResult Admin() 
        {
            return View();
        }

        [Admin]
        public ActionResult HighperformanceDemo()
        {
            return View();
        }

        /// <summary>
        /// Example of local pie chart. 
        /// </summary>
        /// <returns></returns>
        [Admin]
        public ActionResult LocalPieChardDemo()
        {
            //todo : knockout and kendo ui to auto update
            return View();
        }

        //GET: Kendo.DataViz/

        /// <summary>
        /// Example of remote pie chart 
        /// </summary>
        /// <returns></returns>
        [Admin]
        public ActionResult RemotePieChartDemo()
        {
            return View();
        }


        [Themed]
        public ActionResult HighperformanceDemoThemed() 
        {
            return View();    
        }
    }
}
