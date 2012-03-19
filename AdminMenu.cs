using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Orchard.UI.Navigation;
using Orchard.Environment.Extensions;
using Orchard.Localization;

namespace Kendo.DataViz
{
    [OrchardFeature("Kendo.DataViz.Demos")]
    public class AdminMenu : INavigationProvider
    {
        public AdminMenu() 
        {
            
        }

        public Localizer T { get; set; }
        public string MenuName { get { return "admin"; } }

        public void GetNavigation(NavigationBuilder builder)
        {
            builder.AddImageSet("navigation")
                .Add(T("Kendo UI Dataviz Demo"), "9", menu => 
                    {
                        menu.Add(T("Demo"), "0", item => item.Action("Admin", "KendoVizDemo", new { Area = "Kendo.DataViz.Demos" })); 
                    });

        }
    }
}