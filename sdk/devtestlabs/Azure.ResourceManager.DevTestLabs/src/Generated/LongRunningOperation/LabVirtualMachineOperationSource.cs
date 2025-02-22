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

namespace Azure.ResourceManager.DevTestLabs
{
    internal class LabVirtualMachineOperationSource : IOperationSource<LabVirtualMachineResource>
    {
        private readonly ArmClient _client;

        internal LabVirtualMachineOperationSource(ArmClient client)
        {
            _client = client;
        }

        LabVirtualMachineResource IOperationSource<LabVirtualMachineResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = LabVirtualMachineData.DeserializeLabVirtualMachineData(document.RootElement);
            return new LabVirtualMachineResource(_client, data);
        }

        async ValueTask<LabVirtualMachineResource> IOperationSource<LabVirtualMachineResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = LabVirtualMachineData.DeserializeLabVirtualMachineData(document.RootElement);
            return new LabVirtualMachineResource(_client, data);
        }
    }
}
