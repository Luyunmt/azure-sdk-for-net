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
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Azure IaaS VM workload-specific Health Details.
    /// </summary>
    public partial class AzureIaaSVMHealthDetails
    {
        /// <summary>
        /// Initializes a new instance of the AzureIaaSVMHealthDetails class.
        /// </summary>
        public AzureIaaSVMHealthDetails()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AzureIaaSVMHealthDetails class.
        /// </summary>
        /// <param name="code">Health Code</param>
        /// <param name="title">Health Title</param>
        /// <param name="message">Health Message</param>
        /// <param name="recommendations">Health Recommended Actions</param>
        public AzureIaaSVMHealthDetails(int? code = default(int?), string title = default(string), string message = default(string), IList<string> recommendations = default(IList<string>))
        {
            Code = code;
            Title = title;
            Message = message;
            Recommendations = recommendations;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets health Code
        /// </summary>
        [JsonProperty(PropertyName = "code")]
        public int? Code { get; set; }

        /// <summary>
        /// Gets or sets health Title
        /// </summary>
        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets health Message
        /// </summary>
        [JsonProperty(PropertyName = "message")]
        public string Message { get; set; }

        /// <summary>
        /// Gets or sets health Recommended Actions
        /// </summary>
        [JsonProperty(PropertyName = "recommendations")]
        public IList<string> Recommendations { get; set; }

    }
}
