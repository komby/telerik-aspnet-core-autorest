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

    public partial class KendoMvcUIDataSourceResult
    {
        /// <summary>
        /// Initializes a new instance of the KendoMvcUIDataSourceResult class.
        /// </summary>
        public KendoMvcUIDataSourceResult()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the KendoMvcUIDataSourceResult class.
        /// </summary>
        public KendoMvcUIDataSourceResult(IList<object> data = default(IList<object>), int? total = default(int?), IList<KendoMvcInfrastructureAggregateResult> aggregateResults = default(IList<KendoMvcInfrastructureAggregateResult>), object errors = default(object))
        {
            Data = data;
            Total = total;
            AggregateResults = aggregateResults;
            Errors = errors;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "data")]
        public IList<object> Data { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "total")]
        public int? Total { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "aggregateResults")]
        public IList<KendoMvcInfrastructureAggregateResult> AggregateResults { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "errors")]
        public object Errors { get; set; }

    }
}
