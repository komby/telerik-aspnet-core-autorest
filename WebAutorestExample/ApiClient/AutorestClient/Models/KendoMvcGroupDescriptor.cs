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

    public partial class KendoMvcGroupDescriptor
    {
        /// <summary>
        /// Initializes a new instance of the KendoMvcGroupDescriptor class.
        /// </summary>
        public KendoMvcGroupDescriptor()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the KendoMvcGroupDescriptor class.
        /// </summary>
        /// <param name="sortDirection">Possible values include: 'Ascending',
        /// 'Descending'</param>
        public KendoMvcGroupDescriptor(string memberType = default(string), object displayContent = default(object), IList<KendoMvcAggregateFunction> aggregateFunctions = default(IList<KendoMvcAggregateFunction>), string member = default(string), string sortDirection = default(string))
        {
            MemberType = memberType;
            DisplayContent = displayContent;
            AggregateFunctions = aggregateFunctions;
            Member = member;
            SortDirection = sortDirection;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "memberType")]
        public string MemberType { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "displayContent")]
        public object DisplayContent { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "aggregateFunctions")]
        public IList<KendoMvcAggregateFunction> AggregateFunctions { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "member")]
        public string Member { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'Ascending', 'Descending'
        /// </summary>
        [JsonProperty(PropertyName = "sortDirection")]
        public string SortDirection { get; set; }

    }
}
