// Code generated by Microsoft (R) AutoRest Code Generator 1.1.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace k8s.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// ServiceStatus represents the current status of a service.
    /// </summary>
    public partial class V1ServiceStatus
    {
        /// <summary>
        /// Initializes a new instance of the V1ServiceStatus class.
        /// </summary>
        public V1ServiceStatus()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the V1ServiceStatus class.
        /// </summary>
        /// <param name="loadBalancer">LoadBalancer contains the current status
        /// of the load-balancer, if one is present.</param>
        public V1ServiceStatus(V1LoadBalancerStatus loadBalancer = default(V1LoadBalancerStatus))
        {
            LoadBalancer = loadBalancer;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets loadBalancer contains the current status of the
        /// load-balancer, if one is present.
        /// </summary>
        [JsonProperty(PropertyName = "loadBalancer")]
        public V1LoadBalancerStatus LoadBalancer { get; set; }

    }
}
