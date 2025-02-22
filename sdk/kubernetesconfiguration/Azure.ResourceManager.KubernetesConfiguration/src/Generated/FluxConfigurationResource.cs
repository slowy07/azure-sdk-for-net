// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.KubernetesConfiguration.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.KubernetesConfiguration
{
    /// <summary>
    /// A Class representing a FluxConfiguration along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="FluxConfigurationResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetFluxConfigurationResource method.
    /// Otherwise you can get one from its parent resource <see cref="ResourceGroupResource" /> using the GetFluxConfiguration method.
    /// </summary>
    public partial class FluxConfigurationResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="FluxConfigurationResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string clusterRp, string clusterResourceName, string clusterName, string fluxConfigurationName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{clusterRp}/{clusterResourceName}/{clusterName}/providers/Microsoft.KubernetesConfiguration/fluxConfigurations/{fluxConfigurationName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _fluxConfigurationClientDiagnostics;
        private readonly FluxConfigurationsRestOperations _fluxConfigurationRestClient;
        private readonly FluxConfigurationData _data;

        /// <summary> Initializes a new instance of the <see cref="FluxConfigurationResource"/> class for mocking. </summary>
        protected FluxConfigurationResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "FluxConfigurationResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal FluxConfigurationResource(ArmClient client, FluxConfigurationData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="FluxConfigurationResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal FluxConfigurationResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _fluxConfigurationClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.KubernetesConfiguration", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string fluxConfigurationApiVersion);
            _fluxConfigurationRestClient = new FluxConfigurationsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, fluxConfigurationApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.KubernetesConfiguration/fluxConfigurations";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual FluxConfigurationData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary>
        /// Gets details of the Flux Configuration.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{clusterRp}/{clusterResourceName}/{clusterName}/providers/Microsoft.KubernetesConfiguration/fluxConfigurations/{fluxConfigurationName}
        /// Operation Id: FluxConfigurations_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<FluxConfigurationResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _fluxConfigurationClientDiagnostics.CreateScope("FluxConfigurationResource.Get");
            scope.Start();
            try
            {
                var response = await _fluxConfigurationRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.ResourceType.Namespace, Id.Parent.ResourceType.GetLastType(), Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new FluxConfigurationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets details of the Flux Configuration.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{clusterRp}/{clusterResourceName}/{clusterName}/providers/Microsoft.KubernetesConfiguration/fluxConfigurations/{fluxConfigurationName}
        /// Operation Id: FluxConfigurations_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<FluxConfigurationResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _fluxConfigurationClientDiagnostics.CreateScope("FluxConfigurationResource.Get");
            scope.Start();
            try
            {
                var response = _fluxConfigurationRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.ResourceType.Namespace, Id.Parent.ResourceType.GetLastType(), Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new FluxConfigurationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// This will delete the YAML file used to set up the Flux Configuration, thus stopping future sync from the source repo.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{clusterRp}/{clusterResourceName}/{clusterName}/providers/Microsoft.KubernetesConfiguration/fluxConfigurations/{fluxConfigurationName}
        /// Operation Id: FluxConfigurations_Delete
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="forceDelete"> Delete the extension resource in Azure - not the normal asynchronous delete. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, bool? forceDelete = null, CancellationToken cancellationToken = default)
        {
            using var scope = _fluxConfigurationClientDiagnostics.CreateScope("FluxConfigurationResource.Delete");
            scope.Start();
            try
            {
                var response = await _fluxConfigurationRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.ResourceType.Namespace, Id.Parent.ResourceType.GetLastType(), Id.Parent.Name, Id.Name, forceDelete, cancellationToken).ConfigureAwait(false);
                var operation = new KubernetesConfigurationArmOperation(_fluxConfigurationClientDiagnostics, Pipeline, _fluxConfigurationRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.ResourceType.Namespace, Id.Parent.ResourceType.GetLastType(), Id.Parent.Name, Id.Name, forceDelete).Request, response, OperationFinalStateVia.AzureAsyncOperation);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// This will delete the YAML file used to set up the Flux Configuration, thus stopping future sync from the source repo.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{clusterRp}/{clusterResourceName}/{clusterName}/providers/Microsoft.KubernetesConfiguration/fluxConfigurations/{fluxConfigurationName}
        /// Operation Id: FluxConfigurations_Delete
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="forceDelete"> Delete the extension resource in Azure - not the normal asynchronous delete. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, bool? forceDelete = null, CancellationToken cancellationToken = default)
        {
            using var scope = _fluxConfigurationClientDiagnostics.CreateScope("FluxConfigurationResource.Delete");
            scope.Start();
            try
            {
                var response = _fluxConfigurationRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.ResourceType.Namespace, Id.Parent.ResourceType.GetLastType(), Id.Parent.Name, Id.Name, forceDelete, cancellationToken);
                var operation = new KubernetesConfigurationArmOperation(_fluxConfigurationClientDiagnostics, Pipeline, _fluxConfigurationRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.ResourceType.Namespace, Id.Parent.ResourceType.GetLastType(), Id.Parent.Name, Id.Name, forceDelete).Request, response, OperationFinalStateVia.AzureAsyncOperation);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletionResponse(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Update an existing Kubernetes Flux Configuration.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{clusterRp}/{clusterResourceName}/{clusterName}/providers/Microsoft.KubernetesConfiguration/fluxConfigurations/{fluxConfigurationName}
        /// Operation Id: FluxConfigurations_Update
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="patch"> Properties to Patch in an existing Flux Configuration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="patch"/> is null. </exception>
        public virtual async Task<ArmOperation<FluxConfigurationResource>> UpdateAsync(WaitUntil waitUntil, FluxConfigurationPatch patch, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(patch, nameof(patch));

            using var scope = _fluxConfigurationClientDiagnostics.CreateScope("FluxConfigurationResource.Update");
            scope.Start();
            try
            {
                var response = await _fluxConfigurationRestClient.UpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.ResourceType.Namespace, Id.Parent.ResourceType.GetLastType(), Id.Parent.Name, Id.Name, patch, cancellationToken).ConfigureAwait(false);
                var operation = new KubernetesConfigurationArmOperation<FluxConfigurationResource>(new FluxConfigurationOperationSource(Client), _fluxConfigurationClientDiagnostics, Pipeline, _fluxConfigurationRestClient.CreateUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.ResourceType.Namespace, Id.Parent.ResourceType.GetLastType(), Id.Parent.Name, Id.Name, patch).Request, response, OperationFinalStateVia.AzureAsyncOperation);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Update an existing Kubernetes Flux Configuration.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{clusterRp}/{clusterResourceName}/{clusterName}/providers/Microsoft.KubernetesConfiguration/fluxConfigurations/{fluxConfigurationName}
        /// Operation Id: FluxConfigurations_Update
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="patch"> Properties to Patch in an existing Flux Configuration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="patch"/> is null. </exception>
        public virtual ArmOperation<FluxConfigurationResource> Update(WaitUntil waitUntil, FluxConfigurationPatch patch, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(patch, nameof(patch));

            using var scope = _fluxConfigurationClientDiagnostics.CreateScope("FluxConfigurationResource.Update");
            scope.Start();
            try
            {
                var response = _fluxConfigurationRestClient.Update(Id.SubscriptionId, Id.ResourceGroupName, Id.ResourceType.Namespace, Id.Parent.ResourceType.GetLastType(), Id.Parent.Name, Id.Name, patch, cancellationToken);
                var operation = new KubernetesConfigurationArmOperation<FluxConfigurationResource>(new FluxConfigurationOperationSource(Client), _fluxConfigurationClientDiagnostics, Pipeline, _fluxConfigurationRestClient.CreateUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.ResourceType.Namespace, Id.Parent.ResourceType.GetLastType(), Id.Parent.Name, Id.Name, patch).Request, response, OperationFinalStateVia.AzureAsyncOperation);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
