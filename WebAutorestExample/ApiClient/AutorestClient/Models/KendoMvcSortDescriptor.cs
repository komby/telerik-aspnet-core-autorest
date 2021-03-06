// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace WebAutorestExample.ApiClient.Models
{
    using Newtonsoft.Json;
    using System.Linq;
    using WebAutorestExample.ApiClient;

    public partial class KendoMvcSortDescriptor
    {
        /// <summary>
        /// Initializes a new instance of the KendoMvcSortDescriptor class.
        /// </summary>
        public KendoMvcSortDescriptor()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the KendoMvcSortDescriptor class.
        /// </summary>
        /// <param name="sortDirection">Possible values include: 'Ascending',
        /// 'Descending'</param>
        public KendoMvcSortDescriptor(string member = default(string), string sortDirection = default(string))
        {
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
        [JsonProperty(PropertyName = "member")]
        public string Member { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'Ascending', 'Descending'
        /// </summary>
        [JsonProperty(PropertyName = "sortDirection")]
        public string SortDirection { get; set; }

    }
}
