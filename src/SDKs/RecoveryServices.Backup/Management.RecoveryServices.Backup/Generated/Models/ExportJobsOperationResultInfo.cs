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
    /// This class is used to send blob details after exporting jobs.
    /// </summary>
    public partial class ExportJobsOperationResultInfo : OperationResultInfoBase
    {
        /// <summary>
        /// Initializes a new instance of the ExportJobsOperationResultInfo
        /// class.
        /// </summary>
        public ExportJobsOperationResultInfo()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ExportJobsOperationResultInfo
        /// class.
        /// </summary>
        /// <param name="blobUrl">URL of the blob into which the serialized
        /// string of list of jobs is exported.</param>
        /// <param name="blobSasKey">SAS key to access the blob. It expires in
        /// 15 mins.</param>
        public ExportJobsOperationResultInfo(string blobUrl = default(string), string blobSasKey = default(string))
        {
            BlobUrl = blobUrl;
            BlobSasKey = blobSasKey;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets URL of the blob into which the serialized string of
        /// list of jobs is exported.
        /// </summary>
        [JsonProperty(PropertyName = "blobUrl")]
        public string BlobUrl { get; set; }

        /// <summary>
        /// Gets or sets SAS key to access the blob. It expires in 15 mins.
        /// </summary>
        [JsonProperty(PropertyName = "blobSasKey")]
        public string BlobSasKey { get; set; }

    }
}
