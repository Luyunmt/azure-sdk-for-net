// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.RecoveryServices.Backup.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.RecoveryServices;
    using Microsoft.Azure.Management.RecoveryServices.Backup;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Additional information on Azure IaaS VM specific backup item.
    /// </summary>
    public partial class AzureIaaSVMProtectedItemExtendedInfo
    {
        /// <summary>
        /// Initializes a new instance of the
        /// AzureIaaSVMProtectedItemExtendedInfo class.
        /// </summary>
        public AzureIaaSVMProtectedItemExtendedInfo()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// AzureIaaSVMProtectedItemExtendedInfo class.
        /// </summary>
        /// <param name="oldestRecoveryPoint">The oldest backup copy available
        /// for this backup item.</param>
        /// <param name="recoveryPointCount">Number of backup copies available
        /// for this backup item.</param>
        /// <param name="policyInconsistent">Specifies if backup policy
        /// associated with the backup item is inconsistent.</param>
        public AzureIaaSVMProtectedItemExtendedInfo(System.DateTime? oldestRecoveryPoint = default(System.DateTime?), int? recoveryPointCount = default(int?), bool? policyInconsistent = default(bool?))
        {
            OldestRecoveryPoint = oldestRecoveryPoint;
            RecoveryPointCount = recoveryPointCount;
            PolicyInconsistent = policyInconsistent;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the oldest backup copy available for this backup item.
        /// </summary>
        [JsonProperty(PropertyName = "oldestRecoveryPoint")]
        public System.DateTime? OldestRecoveryPoint { get; set; }

        /// <summary>
        /// Gets or sets number of backup copies available for this backup
        /// item.
        /// </summary>
        [JsonProperty(PropertyName = "recoveryPointCount")]
        public int? RecoveryPointCount { get; set; }

        /// <summary>
        /// Gets or sets specifies if backup policy associated with the backup
        /// item is inconsistent.
        /// </summary>
        [JsonProperty(PropertyName = "policyInconsistent")]
        public bool? PolicyInconsistent { get; set; }

    }
}
