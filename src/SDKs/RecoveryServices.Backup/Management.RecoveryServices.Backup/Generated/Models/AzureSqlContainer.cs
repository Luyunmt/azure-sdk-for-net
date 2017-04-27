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
    using System.Linq;

    /// <summary>
    /// Azure Sql workload-specific container.
    /// </summary>
    public partial class AzureSqlContainer : ProtectionContainer
    {
        /// <summary>
        /// Initializes a new instance of the AzureSqlContainer class.
        /// </summary>
        public AzureSqlContainer()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AzureSqlContainer class.
        /// </summary>
        /// <param name="friendlyName">Friendly name of the container.</param>
        /// <param name="backupManagementType">Type of backup managemenent for
        /// the container. Possible values include: 'Invalid', 'AzureIaasVM',
        /// 'MAB', 'DPM', 'AzureBackupServer', 'AzureSql'</param>
        /// <param name="registrationStatus">Status of registration of the
        /// container with the Recovery Services Vault.</param>
        /// <param name="healthStatus">Status of health of the
        /// container.</param>
        /// <param name="containerType">Type of the container. The value of
        /// this property for: 1. Compute Azure VM is
        /// Microsoft.Compute/virtualMachines 2. Classic Compute Azure VM is
        /// Microsoft.ClassicCompute/virtualMachines 3. Windows machines (like
        /// MAB, DPM etc) is Windows 4. Azure SQL instance is
        /// AzureSqlContainer. Possible values include: 'Invalid', 'Unknown',
        /// 'IaasVMContainer', 'IaasVMServiceContainer', 'DPMContainer',
        /// 'AzureBackupServerContainer', 'MABContainer', 'Cluster',
        /// 'AzureSqlContainer', 'Windows', 'VCenter'</param>
        public AzureSqlContainer(string friendlyName = default(string), string backupManagementType = default(string), string registrationStatus = default(string), string healthStatus = default(string), string containerType = default(string))
            : base(friendlyName, backupManagementType, registrationStatus, healthStatus, containerType)
        {
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

    }
}
