// Code generated by Microsoft (R) AutoRest Code Generator 1.1.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace k8s.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// DaemonSetSpec is the specification of a daemon set.
    /// </summary>
    public partial class V1beta1DaemonSetSpec
    {
        /// <summary>
        /// Initializes a new instance of the V1beta1DaemonSetSpec class.
        /// </summary>
        public V1beta1DaemonSetSpec()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the V1beta1DaemonSetSpec class.
        /// </summary>
        /// <param name="template">An object that describes the pod that will
        /// be created. The DaemonSet will create exactly one copy of this pod
        /// on every node that matches the template's node selector (or on
        /// every node if no node selector is specified). More info:
        /// http://kubernetes.io/docs/user-guide/replication-controller#pod-template</param>
        /// <param name="minReadySeconds">The minimum number of seconds for
        /// which a newly created DaemonSet pod should be ready without any of
        /// its container crashing, for it to be considered available. Defaults
        /// to 0 (pod will be considered available as soon as it is
        /// ready).</param>
        /// <param name="selector">A label query over pods that are managed by
        /// the daemon set. Must match in order to be controlled. If empty,
        /// defaulted to labels on Pod template. More info:
        /// http://kubernetes.io/docs/user-guide/labels#label-selectors</param>
        /// <param name="templateGeneration">A sequence number representing a
        /// specific generation of the template. Populated by the system. It
        /// can be set only during the creation.</param>
        /// <param name="updateStrategy">An update strategy to replace existing
        /// DaemonSet pods with new pods.</param>
        public V1beta1DaemonSetSpec(V1PodTemplateSpec template, int? minReadySeconds = default(int?), V1LabelSelector selector = default(V1LabelSelector), long? templateGeneration = default(long?), V1beta1DaemonSetUpdateStrategy updateStrategy = default(V1beta1DaemonSetUpdateStrategy))
        {
            MinReadySeconds = minReadySeconds;
            Selector = selector;
            Template = template;
            TemplateGeneration = templateGeneration;
            UpdateStrategy = updateStrategy;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the minimum number of seconds for which a newly
        /// created DaemonSet pod should be ready without any of its container
        /// crashing, for it to be considered available. Defaults to 0 (pod
        /// will be considered available as soon as it is ready).
        /// </summary>
        [JsonProperty(PropertyName = "minReadySeconds")]
        public int? MinReadySeconds { get; set; }

        /// <summary>
        /// Gets or sets a label query over pods that are managed by the daemon
        /// set. Must match in order to be controlled. If empty, defaulted to
        /// labels on Pod template. More info:
        /// http://kubernetes.io/docs/user-guide/labels#label-selectors
        /// </summary>
        [JsonProperty(PropertyName = "selector")]
        public V1LabelSelector Selector { get; set; }

        /// <summary>
        /// Gets or sets an object that describes the pod that will be created.
        /// The DaemonSet will create exactly one copy of this pod on every
        /// node that matches the template's node selector (or on every node if
        /// no node selector is specified). More info:
        /// http://kubernetes.io/docs/user-guide/replication-controller#pod-template
        /// </summary>
        [JsonProperty(PropertyName = "template")]
        public V1PodTemplateSpec Template { get; set; }

        /// <summary>
        /// Gets or sets a sequence number representing a specific generation
        /// of the template. Populated by the system. It can be set only during
        /// the creation.
        /// </summary>
        [JsonProperty(PropertyName = "templateGeneration")]
        public long? TemplateGeneration { get; set; }

        /// <summary>
        /// Gets or sets an update strategy to replace existing DaemonSet pods
        /// with new pods.
        /// </summary>
        [JsonProperty(PropertyName = "updateStrategy")]
        public V1beta1DaemonSetUpdateStrategy UpdateStrategy { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Template == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Template");
            }
            if (Template != null)
            {
                Template.Validate();
            }
        }
    }
}
