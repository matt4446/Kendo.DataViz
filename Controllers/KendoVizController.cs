using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Kendo.DataViz.Services;
using Orchard.Themes;

namespace Kendo.DataViz.Controllers
{
    [Themed]
    public class KendoVizController : Controller
    {
        private readonly IKendoDataService kendoDataService;

        public KendoVizController(IKendoDataService kendoDataService) 
        {
            this.kendoDataService = kendoDataService;
        }

        
        /// <summary>
        /// Example of random data
        /// </summary>
        /// <returns></returns>
        public JsonResult Data(string dataType, string source) 
        {
            var repository = string.IsNullOrWhiteSpace(dataType) ? "test" : dataType;
            var dataSource = kendoDataService.FetchData(repository, source);

            return Json(dataSource, JsonRequestBehavior.AllowGet);    
        }

    }
}
