// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Migrate.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Gets or sets the virtual machine resource settings.
    /// </summary>
    [Newtonsoft.Json.JsonObject("Microsoft.Compute/virtualMachines")]
    public partial class VirtualMachineResourceSettings : ResourceSettings
    {
        /// <summary>
        /// Initializes a new instance of the VirtualMachineResourceSettings
        /// class.
        /// </summary>
        public VirtualMachineResourceSettings()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the VirtualMachineResourceSettings
        /// class.
        /// </summary>
        /// <param name="targetResourceName">Gets or sets the target Resource
        /// name.</param>
        /// <param name="targetAvailabilityZone">Gets or sets the target
        /// availability zone. Possible values include: '1', '2', '3',
        /// 'NA'</param>
        /// <param name="targetVmSize">Gets or sets the target virtual machine
        /// size.</param>
        /// <param name="targetAvailabilitySetId">Gets or sets the target
        /// availability set id for virtual machines not in an availability set
        /// at source.</param>
        public VirtualMachineResourceSettings(string targetResourceName, string targetAvailabilityZone = default(string), string targetVmSize = default(string), string targetAvailabilitySetId = default(string))
            : base(targetResourceName)
        {
            TargetAvailabilityZone = targetAvailabilityZone;
            TargetVmSize = targetVmSize;
            TargetAvailabilitySetId = targetAvailabilitySetId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the target availability zone. Possible values include:
        /// '1', '2', '3', 'NA'
        /// </summary>
        [JsonProperty(PropertyName = "targetAvailabilityZone")]
        public string TargetAvailabilityZone { get; set; }

        /// <summary>
        /// Gets or sets the target virtual machine size.
        /// </summary>
        [JsonProperty(PropertyName = "targetVmSize")]
        public string TargetVmSize { get; set; }

        /// <summary>
        /// Gets or sets the target availability set id for virtual machines
        /// not in an availability set at source.
        /// </summary>
        [JsonProperty(PropertyName = "targetAvailabilitySetId")]
        public string TargetAvailabilitySetId { get; set; }

    }
}