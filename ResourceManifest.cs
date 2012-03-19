using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Orchard.UI.Resources;

namespace Kendo.DataViz
{
    public class ResourceManifest : IResourceManifestProvider
    {
        public void BuildManifests(ResourceManifestBuilder builder)
        {
            var manifest = builder.Add();

            //v2011.3.1129 Scripts
            //Will be specifying all chart scripts for now. 
            manifest.DefineScript("kendo").SetUrl("kendo.all.min.js").SetDependencies("jQuery").SetVersion("v2011.3.1129");

            //v2011.3.1129 Styles
            manifest.DefineStyle("kendo.common").SetUrl("kendo.common.min.css").SetVersion("v2011.3.1129");
            manifest.DefineStyle("kendo.black").SetUrl("kendo.black.min.css").SetDependencies("kendo.common").SetVersion("v2011.3.1129");
            manifest.DefineStyle("kendo.blueopal").SetUrl("kendo.blueopal.min.css").SetDependencies("kendo.common").SetVersion("v2011.3.1129");
            manifest.DefineStyle("kendo.default").SetUrl("kendo.default.min.css").SetDependencies("kendo.common").SetVersion("v2011.3.1129");
            manifest.DefineStyle("kendo.hakama").SetUrl("kendo.hakama.min.css").SetDependencies("kendo.common").SetVersion("v2011.3.1129");
            manifest.DefineStyle("kendo.kendo").SetUrl("kendo.kendo.min.css").SetDependencies("kendo.common").SetVersion("v2011.3.1129");
            manifest.DefineStyle("kendo.metro").SetUrl("kendo.metro.min.css").SetDependencies("kendo.common").SetVersion("v2011.3.1129");
            manifest.DefineStyle("kendo.silver").SetUrl("kendo.silver.min.css").SetDependencies("kendo.common").SetVersion("v2011.3.1129");
        }
    }

}
