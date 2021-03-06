// Code generated by Microsoft (R) AutoRest Code Generator 1.1.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace k8s.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// A StatefulSetSpec is the specification of a StatefulSet.
    /// </summary>
    public partial class V1beta1StatefulSetSpec
    {
        /// <summary>
        /// Initializes a new instance of the V1beta1StatefulSetSpec class.
        /// </summary>
        public V1beta1StatefulSetSpec()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the V1beta1StatefulSetSpec class.
        /// </summary>
        /// <param name="serviceName">ServiceName is the name of the service
        /// that governs this StatefulSet. This service must exist before the
        /// StatefulSet, and is responsible for the network identity of the
        /// set. Pods get DNS/hostnames that follow the pattern:
        /// pod-specific-string.serviceName.default.svc.cluster.local where
        /// "pod-specific-string" is managed by the StatefulSet
        /// controller.</param>
        /// <param name="template">Template is the object that describes the
        /// pod that will be created if insufficient replicas are detected.
        /// Each pod stamped out by the StatefulSet will fulfill this Template,
        /// but have a unique identity from the rest of the
        /// StatefulSet.</param>
        /// <param name="replicas">Replicas is the desired number of replicas
        /// of the given Template. These are replicas in the sense that they
        /// are instantiations of the same Template, but individual replicas
        /// also have a consistent identity. If unspecified, defaults to
        /// 1.</param>
        /// <param name="selector">Selector is a label query over pods that
        /// should match the replica count. If empty, defaulted to labels on
        /// the pod template. More info:
        /// http://kubernetes.io/docs/user-guide/labels#label-selectors</param>
        /// <param name="volumeClaimTemplates">VolumeClaimTemplates is a list
        /// of claims that pods are allowed to reference. The StatefulSet
        /// controller is responsible for mapping network identities to claims
        /// in a way that maintains the identity of a pod. Every claim in this
        /// list must have at least one matching (by name) volumeMount in one
        /// container in the template. A claim in this list takes precedence
        /// over any volumes in the template, with the same name.</param>
        public V1beta1StatefulSetSpec(string serviceName, V1PodTemplateSpec template, int? replicas = default(int?), V1LabelSelector selector = default(V1LabelSelector), IList<V1PersistentVolumeClaim> volumeClaimTemplates = default(IList<V1PersistentVolumeClaim>))
        {
            Replicas = replicas;
            Selector = selector;
            ServiceName = serviceName;
            Template = template;
            VolumeClaimTemplates = volumeClaimTemplates;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets replicas is the desired number of replicas of the
        /// given Template. These are replicas in the sense that they are
        /// instantiations of the same Template, but individual replicas also
        /// have a consistent identity. If unspecified, defaults to 1.
        /// </summary>
        [JsonProperty(PropertyName = "replicas")]
        public int? Replicas { get; set; }

        /// <summary>
        /// Gets or sets selector is a label query over pods that should match
        /// the replica count. If empty, defaulted to labels on the pod
        /// template. More info:
        /// http://kubernetes.io/docs/user-guide/labels#label-selectors
        /// </summary>
        [JsonProperty(PropertyName = "selector")]
        public V1LabelSelector Selector { get; set; }

        /// <summary>
        /// Gets or sets serviceName is the name of the service that governs
        /// this StatefulSet. This service must exist before the StatefulSet,
        /// and is responsible for the network identity of the set. Pods get
        /// DNS/hostnames that follow the pattern:
        /// pod-specific-string.serviceName.default.svc.cluster.local where
        /// "pod-specific-string" is managed by the StatefulSet controller.
        /// </summary>
        [JsonProperty(PropertyName = "serviceName")]
        public string ServiceName { get; set; }

        /// <summary>
        /// Gets or sets template is the object that describes the pod that
        /// will be created if insufficient replicas are detected. Each pod
        /// stamped out by the StatefulSet will fulfill this Template, but have
        /// a unique identity from the rest of the StatefulSet.
        /// </summary>
        [JsonProperty(PropertyName = "template")]
        public V1PodTemplateSpec Template { get; set; }

        /// <summary>
        /// Gets or sets volumeClaimTemplates is a list of claims that pods are
        /// allowed to reference. The StatefulSet controller is responsible for
        /// mapping network identities to claims in a way that maintains the
        /// identity of a pod. Every claim in this list must have at least one
        /// matching (by name) volumeMount in one container in the template. A
        /// claim in this list takes precedence over any volumes in the
        /// template, with the same name.
        /// </summary>
        [JsonProperty(PropertyName = "volumeClaimTemplates")]
        public IList<V1PersistentVolumeClaim> VolumeClaimTemplates { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (ServiceName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ServiceName");
            }
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
