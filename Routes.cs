using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using System.Web.Routing;
using Orchard.Mvc.Routes;
using Orchard.Environment.Extensions;

namespace Kendo.DataViz
{
    public class Routes : IRouteProvider
    {
        public string Area = "Kendo.DataViz"; 

        public void GetRoutes(ICollection<RouteDescriptor> routes)
        {
            foreach (var routeDescriptor in GetRoutes())
                routes.Add(routeDescriptor);
        }

        public IEnumerable<RouteDescriptor> GetRoutes()
        {
            return new[] {
                new RouteDescriptor {
                    Priority = 5,
                    Route = new Route(
                        "Kendo.DataViz/{controller}/{action}",
                        new RouteValueDictionary {
                            {"area", Area},
                            {"controller", "KendoViz"},
                            {"action", "RemotePieChartDemo"}
                        },
                        new RouteValueDictionary {
                        },
                        new RouteValueDictionary {
                            {"area", Area }
                        },
                        new MvcRouteHandler())
                }
            };
        }
    }

    [OrchardFeature("Kendo.DataViz.Demos")]
    public class DemoRoutes : IRouteProvider
    {
        public string Area = "Kendo.DataViz.Demos";

        public void GetRoutes(ICollection<RouteDescriptor> routes)
        {
            foreach (var routeDescriptor in GetRoutes())
                routes.Add(routeDescriptor);
        }

        public IEnumerable<RouteDescriptor> GetRoutes()
        {
            return new[] {
                new RouteDescriptor {
                    Priority = 5,
                    Route = new Route(
                        "Kendo.DataViz/{controller}/{action}",
                        new RouteValueDictionary {
                            {"area", Area},
                        },
                        new RouteValueDictionary {
                        },
                        new RouteValueDictionary {
                            {"area", Area }
                        },
                        new MvcRouteHandler())
                }
            };
        }
    }
}
