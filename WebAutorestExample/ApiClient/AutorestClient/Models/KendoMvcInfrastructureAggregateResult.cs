// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace WebAutorestExample.ApiClient.Models
{
    using Newtonsoft.Json;
    using System.Linq;
    using WebAutorestExample.ApiClient;

    public partial class KendoMvcInfrastructureAggregateResult
    {
        /// <summary>
        /// Initializes a new instance of the
        /// KendoMvcInfrastructureAggregateResult class.
        /// </summary>
        public KendoMvcInfrastructureAggregateResult()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// KendoMvcInfrastructureAggregateResult class.
        /// </summary>
        public KendoMvcInfrastructureAggregateResult(object value = default(object), string member = default(string), object formattedValue = default(object), int? itemCount = default(int?), string caption = default(string), string functionName = default(string), string aggregateMethodName = default(string))
        {
            Value = value;
            Member = member;
            FormattedValue = formattedValue;
            ItemCount = itemCount;
            Caption = caption;
            FunctionName = functionName;
            AggregateMethodName = aggregateMethodName;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public object Value { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "member")]
        public string Member { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "formattedValue")]
        public object FormattedValue { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "itemCount")]
        public int? ItemCount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "caption")]
        public string Caption { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "functionName")]
        public string FunctionName { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "aggregateMethodName")]
        public string AggregateMethodName { get; private set; }

    }
}
