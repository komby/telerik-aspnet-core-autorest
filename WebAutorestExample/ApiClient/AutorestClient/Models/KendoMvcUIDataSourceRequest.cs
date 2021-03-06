// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace WebAutorestExample.ApiClient.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using WebAutorestExample.ApiClient;

    public partial class KendoMvcUIDataSourceRequest
    {
        /// <summary>
        /// Initializes a new instance of the KendoMvcUIDataSourceRequest
        /// class.
        /// </summary>
        public KendoMvcUIDataSourceRequest()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the KendoMvcUIDataSourceRequest
        /// class.
        /// </summary>
        public KendoMvcUIDataSourceRequest(int? page = default(int?), int? pageSize = default(int?), IList<KendoMvcSortDescriptor> sorts = default(IList<KendoMvcSortDescriptor>), IList<object> filters = default(IList<object>), IList<KendoMvcGroupDescriptor> groups = default(IList<KendoMvcGroupDescriptor>), IList<KendoMvcAggregateDescriptor> aggregates = default(IList<KendoMvcAggregateDescriptor>))
        {
            Page = page;
            PageSize = pageSize;
            Sorts = sorts;
            Filters = filters;
            Groups = groups;
            Aggregates = aggregates;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "page")]
        public int? Page { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "pageSize")]
        public int? PageSize { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sorts")]
        public IList<KendoMvcSortDescriptor> Sorts { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "filters")]
        public IList<object> Filters { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "groups")]
        public IList<KendoMvcGroupDescriptor> Groups { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "aggregates")]
        public IList<KendoMvcAggregateDescriptor> Aggregates { get; set; }

    }
}
