// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> An update request for an Azure SQL Database server. </summary>
    public partial class ServerUpdate
    {
        /// <summary> Initializes a new instance of ServerUpdate. </summary>
        public ServerUpdate()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
            PrivateEndpointConnections = new ChangeTrackingList<ServerPrivateEndpointConnection>();
        }

        /// <summary> Resource tags. </summary>
        public IDictionary<string, string> Tags { get; }
        /// <summary> Administrator username for the server. Once created it cannot be changed. </summary>
        public string AdministratorLogin { get; set; }
        /// <summary> The administrator login password (required for server creation). </summary>
        public string AdministratorLoginPassword { get; set; }
        /// <summary> The version of the server. </summary>
        public string Version { get; set; }
        /// <summary> The state of the server. </summary>
        public string State { get; }
        /// <summary> The fully qualified domain name of the server. </summary>
        public string FullyQualifiedDomainName { get; }
        /// <summary> List of private endpoint connections on a server. </summary>
        public IReadOnlyList<ServerPrivateEndpointConnection> PrivateEndpointConnections { get; }
        /// <summary> Minimal TLS version. Allowed values: &apos;1.0&apos;, &apos;1.1&apos;, &apos;1.2&apos;. </summary>
        public string MinimalTlsVersion { get; set; }
        /// <summary> Whether or not public endpoint access is allowed for this server.  Value is optional but if passed in, must be &apos;Enabled&apos; or &apos;Disabled&apos;. </summary>
        public ServerPublicNetworkAccess? PublicNetworkAccess { get; set; }
    }
}