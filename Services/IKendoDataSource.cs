using System;
using System.Collections.Generic;
using System.Linq;
using Orchard;

namespace Kendo.DataViz.Services
{
    public interface IKendoDataSource : IDependency
    {
        string Type { get; }

        IEnumerable<object> FetchData(int id);

        IEnumerable<object> FetchData(string source);
    }
}