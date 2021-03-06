// Code generated by Microsoft (R) AutoRest Code Generator 1.1.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace k8s.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Deployment enables declarative updates for Pods and ReplicaSets.
    /// </summary>
    public partial class Extensionsv1beta1Deployment
    {
        /// <summary>
        /// Initializes a new instance of the Extensionsv1beta1Deployment
        /// class.
        /// </summary>
        public Extensionsv1beta1Deployment()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Extensionsv1beta1Deployment
        /// class.
        /// </summary>
        /// <param name="apiVersion">APIVersion defines the versioned schema of
        /// this representation of an object. Servers should convert recognized
        /// schemas to the latest internal value, and may reject unrecognized
        /// values. More info:
        /// http://releases.k8s.io/HEAD/docs/devel/api-conventions.md#resources</param>
        /// <param name="kind">Kind is a string value representing the REST
        /// resource this object represents. Servers may infer this from the
        /// endpoint the client submits requests to. Cannot be updated. In
        /// CamelCase. More info:
        /// http://releases.k8s.io/HEAD/docs/devel/api-conventions.md#types-kinds</param>
        /// <param name="metadata">Standard object metadata.</param>
        /// <param name="spec">Specification of the desired behavior of the
        /// Deployment.</param>
        /// <param name="status">Most recently observed status of the
        /// Deployment.</param>
        public Extensionsv1beta1Deployment(string apiVersion = default(string), string kind = default(string), V1ObjectMeta metadata = default(V1ObjectMeta), Extensionsv1beta1DeploymentSpec spec = default(Extensionsv1beta1DeploymentSpec), Extensionsv1beta1DeploymentStatus status = default(Extensionsv1beta1DeploymentStatus))
        {
            ApiVersion = apiVersion;
            Kind = kind;
            Metadata = metadata;
            Spec = spec;
            Status = status;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets aPIVersion defines the versioned schema of this
        /// representation of an object. Servers should convert recognized
        /// schemas to the latest internal value, and may reject unrecognized
        /// values. More info:
        /// http://releases.k8s.io/HEAD/docs/devel/api-conventions.md#resources
        /// </summary>
        [JsonProperty(PropertyName = "apiVersion")]
        public string ApiVersion { get; set; }

        /// <summary>
        /// Gets or sets kind is a string value representing the REST resource
        /// this object represents. Servers may infer this from the endpoint
        /// the client submits requests to. Cannot be updated. In CamelCase.
        /// More info:
        /// http://releases.k8s.io/HEAD/docs/devel/api-conventions.md#types-kinds
        /// </summary>
        [JsonProperty(PropertyName = "kind")]
        public string Kind { get; set; }

        /// <summary>
        /// Gets or sets standard object metadata.
        /// </summary>
        [JsonProperty(PropertyName = "metadata")]
        public V1ObjectMeta Metadata { get; set; }

        /// <summary>
        /// Gets or sets specification of the desired behavior of the
        /// Deployment.
        /// </summary>
        [JsonProperty(PropertyName = "spec")]
        public Extensionsv1beta1DeploymentSpec Spec { get; set; }

        /// <summary>
        /// Gets or sets most recently observed status of the Deployment.
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public Extensionsv1beta1DeploymentStatus Status { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Spec != null)
            {
                Spec.Validate();
            }
        }
    }
}
