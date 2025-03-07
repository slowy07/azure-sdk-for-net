// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager;

namespace Azure.ResourceManager.Synapse
{
    internal class ClusterPrincipalAssignmentOperationSource : IOperationSource<ClusterPrincipalAssignmentResource>
    {
        private readonly ArmClient _client;

        internal ClusterPrincipalAssignmentOperationSource(ArmClient client)
        {
            _client = client;
        }

        ClusterPrincipalAssignmentResource IOperationSource<ClusterPrincipalAssignmentResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = ClusterPrincipalAssignmentData.DeserializeClusterPrincipalAssignmentData(document.RootElement);
            return new ClusterPrincipalAssignmentResource(_client, data);
        }

        async ValueTask<ClusterPrincipalAssignmentResource> IOperationSource<ClusterPrincipalAssignmentResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = ClusterPrincipalAssignmentData.DeserializeClusterPrincipalAssignmentData(document.RootElement);
            return new ClusterPrincipalAssignmentResource(_client, data);
        }
    }
}
