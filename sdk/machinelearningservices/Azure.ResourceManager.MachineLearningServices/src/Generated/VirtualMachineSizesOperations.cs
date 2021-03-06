// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core.Pipeline;
using Azure.ResourceManager.MachineLearningServices.Models;

namespace Azure.ResourceManager.MachineLearningServices
{
    /// <summary> The VirtualMachineSizes service client. </summary>
    public partial class VirtualMachineSizesOperations
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal VirtualMachineSizesRestOperations RestClient { get; }

        /// <summary> Initializes a new instance of VirtualMachineSizesOperations for mocking. </summary>
        protected VirtualMachineSizesOperations()
        {
        }

        /// <summary> Initializes a new instance of VirtualMachineSizesOperations. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="subscriptionId"> Azure subscription identifier. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        internal VirtualMachineSizesOperations(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string subscriptionId, Uri endpoint = null, string apiVersion = "2020-09-01-preview")
        {
            RestClient = new VirtualMachineSizesRestOperations(clientDiagnostics, pipeline, subscriptionId, endpoint, apiVersion);
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        /// <summary> Returns supported VM Sizes in a location. </summary>
        /// <param name="location"> The location upon which virtual-machine-sizes is queried. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<VirtualMachineSizeListResult>> ListAsync(string location, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VirtualMachineSizesOperations.List");
            scope.Start();
            try
            {
                return await RestClient.ListAsync(location, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Returns supported VM Sizes in a location. </summary>
        /// <param name="location"> The location upon which virtual-machine-sizes is queried. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<VirtualMachineSizeListResult> List(string location, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VirtualMachineSizesOperations.List");
            scope.Start();
            try
            {
                return RestClient.List(location, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
