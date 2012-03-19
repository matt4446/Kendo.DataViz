
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Orchard;

namespace Kendo.DataViz.Services
{
    /// <summary>
    /// interface to Bring data to the kendo ui control 
    /// </summary>
    public interface IKendoDataService : IDependency
    {
        IEnumerable<object> FetchData(string type, int id);
        IEnumerable<object> FetchData(string type, string source);  
    }

    /// <summary>
    /// 
    /// </summary>
    public class KendoDataService : IKendoDataService
    {
        private readonly IEnumerable<IKendoDataSource> dataSources; 

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dataSources">Available data sources to query</param>
        public KendoDataService(IEnumerable<IKendoDataSource> dataSources) 
        {
            this.dataSources = dataSources;
        }

        private IKendoDataSource GetDataSource(string type)
        {
            var section = dataSources.FirstOrDefault(e => e.Type.Equals(type, StringComparison.InvariantCultureIgnoreCase));

            return section;
        } 

        public IEnumerable<object> FetchData(string type, string source)
        {
            var section = GetDataSource(type);

            if (section == null)
                return null;

            return section.FetchData(source);
        }

        public IEnumerable<object> FetchData(string type, int id) 
        {
            var section = GetDataSource(type);

            if (section == null)
                return null;

            return section.FetchData(id);
        }

    }
}
