// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.Automation.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Automation
{
    /// <summary> A class to add extension methods to Azure.ResourceManager.Automation. </summary>
    public static partial class AutomationExtensions
    {
        private static SubscriptionResourceExtensionClient GetExtensionClient(SubscriptionResource subscriptionResource)
        {
            return subscriptionResource.GetCachedClient((client) =>
            {
                return new SubscriptionResourceExtensionClient(client, subscriptionResource.Id);
            }
            );
        }

        /// <summary>
        /// Retrieve a list of accounts within a given subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Automation/automationAccounts
        /// Operation Id: AutomationAccount_List
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="AutomationAccountResource" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<AutomationAccountResource> GetAutomationAccountsAsync(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscriptionResource).GetAutomationAccountsAsync(cancellationToken);
        }

        /// <summary>
        /// Retrieve a list of accounts within a given subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Automation/automationAccounts
        /// Operation Id: AutomationAccount_List
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="AutomationAccountResource" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<AutomationAccountResource> GetAutomationAccounts(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscriptionResource).GetAutomationAccounts(cancellationToken);
        }

        /// <summary>
        /// Retrieve deleted automation account.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Automation/deletedAutomationAccounts
        /// Operation Id: deletedAutomationAccounts_ListBySubscription
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DeletedAutomationAccount" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<DeletedAutomationAccount> GetDeletedAutomationAccountsBySubscriptionAsync(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscriptionResource).GetDeletedAutomationAccountsBySubscriptionAsync(cancellationToken);
        }

        /// <summary>
        /// Retrieve deleted automation account.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Automation/deletedAutomationAccounts
        /// Operation Id: deletedAutomationAccounts_ListBySubscription
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DeletedAutomationAccount" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<DeletedAutomationAccount> GetDeletedAutomationAccountsBySubscription(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscriptionResource).GetDeletedAutomationAccountsBySubscription(cancellationToken);
        }

        private static ResourceGroupResourceExtensionClient GetExtensionClient(ResourceGroupResource resourceGroupResource)
        {
            return resourceGroupResource.GetCachedClient((client) =>
            {
                return new ResourceGroupResourceExtensionClient(client, resourceGroupResource.Id);
            }
            );
        }

        /// <summary> Gets a collection of AutomationAccountResources in the ResourceGroupResource. </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of AutomationAccountResources and their operations over a AutomationAccountResource. </returns>
        public static AutomationAccountCollection GetAutomationAccounts(this ResourceGroupResource resourceGroupResource)
        {
            return GetExtensionClient(resourceGroupResource).GetAutomationAccounts();
        }

        /// <summary>
        /// Get information about an Automation Account.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automation/automationAccounts/{automationAccountName}
        /// Operation Id: AutomationAccount_Get
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="automationAccountName"> The name of the automation account. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="automationAccountName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="automationAccountName"/> is null. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<AutomationAccountResource>> GetAutomationAccountAsync(this ResourceGroupResource resourceGroupResource, string automationAccountName, CancellationToken cancellationToken = default)
        {
            return await resourceGroupResource.GetAutomationAccounts().GetAsync(automationAccountName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get information about an Automation Account.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automation/automationAccounts/{automationAccountName}
        /// Operation Id: AutomationAccount_Get
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="automationAccountName"> The name of the automation account. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="automationAccountName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="automationAccountName"/> is null. </exception>
        [ForwardsClientCalls]
        public static Response<AutomationAccountResource> GetAutomationAccount(this ResourceGroupResource resourceGroupResource, string automationAccountName, CancellationToken cancellationToken = default)
        {
            return resourceGroupResource.GetAutomationAccounts().Get(automationAccountName, cancellationToken);
        }

        #region AutomationPrivateEndpointConnectionResource
        /// <summary>
        /// Gets an object representing an <see cref="AutomationPrivateEndpointConnectionResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="AutomationPrivateEndpointConnectionResource.CreateResourceIdentifier" /> to create an <see cref="AutomationPrivateEndpointConnectionResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="AutomationPrivateEndpointConnectionResource" /> object. </returns>
        public static AutomationPrivateEndpointConnectionResource GetAutomationPrivateEndpointConnectionResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                AutomationPrivateEndpointConnectionResource.ValidateResourceId(id);
                return new AutomationPrivateEndpointConnectionResource(client, id);
            }
            );
        }
        #endregion

        #region AutomationAccountPython2PackageResource
        /// <summary>
        /// Gets an object representing an <see cref="AutomationAccountPython2PackageResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="AutomationAccountPython2PackageResource.CreateResourceIdentifier" /> to create an <see cref="AutomationAccountPython2PackageResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="AutomationAccountPython2PackageResource" /> object. </returns>
        public static AutomationAccountPython2PackageResource GetAutomationAccountPython2PackageResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                AutomationAccountPython2PackageResource.ValidateResourceId(id);
                return new AutomationAccountPython2PackageResource(client, id);
            }
            );
        }
        #endregion

        #region AutomationAccountModuleResource
        /// <summary>
        /// Gets an object representing an <see cref="AutomationAccountModuleResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="AutomationAccountModuleResource.CreateResourceIdentifier" /> to create an <see cref="AutomationAccountModuleResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="AutomationAccountModuleResource" /> object. </returns>
        public static AutomationAccountModuleResource GetAutomationAccountModuleResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                AutomationAccountModuleResource.ValidateResourceId(id);
                return new AutomationAccountModuleResource(client, id);
            }
            );
        }
        #endregion

        #region DscNodeResource
        /// <summary>
        /// Gets an object representing a <see cref="DscNodeResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="DscNodeResource.CreateResourceIdentifier" /> to create a <see cref="DscNodeResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="DscNodeResource" /> object. </returns>
        public static DscNodeResource GetDscNodeResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                DscNodeResource.ValidateResourceId(id);
                return new DscNodeResource(client, id);
            }
            );
        }
        #endregion

        #region DscNodeConfigurationResource
        /// <summary>
        /// Gets an object representing a <see cref="DscNodeConfigurationResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="DscNodeConfigurationResource.CreateResourceIdentifier" /> to create a <see cref="DscNodeConfigurationResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="DscNodeConfigurationResource" /> object. </returns>
        public static DscNodeConfigurationResource GetDscNodeConfigurationResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                DscNodeConfigurationResource.ValidateResourceId(id);
                return new DscNodeConfigurationResource(client, id);
            }
            );
        }
        #endregion

        #region DscCompilationJobResource
        /// <summary>
        /// Gets an object representing a <see cref="DscCompilationJobResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="DscCompilationJobResource.CreateResourceIdentifier" /> to create a <see cref="DscCompilationJobResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="DscCompilationJobResource" /> object. </returns>
        public static DscCompilationJobResource GetDscCompilationJobResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                DscCompilationJobResource.ValidateResourceId(id);
                return new DscCompilationJobResource(client, id);
            }
            );
        }
        #endregion

        #region SourceControlResource
        /// <summary>
        /// Gets an object representing a <see cref="SourceControlResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="SourceControlResource.CreateResourceIdentifier" /> to create a <see cref="SourceControlResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="SourceControlResource" /> object. </returns>
        public static SourceControlResource GetSourceControlResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                SourceControlResource.ValidateResourceId(id);
                return new SourceControlResource(client, id);
            }
            );
        }
        #endregion

        #region AutomationAccountResource
        /// <summary>
        /// Gets an object representing an <see cref="AutomationAccountResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="AutomationAccountResource.CreateResourceIdentifier" /> to create an <see cref="AutomationAccountResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="AutomationAccountResource" /> object. </returns>
        public static AutomationAccountResource GetAutomationAccountResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                AutomationAccountResource.ValidateResourceId(id);
                return new AutomationAccountResource(client, id);
            }
            );
        }
        #endregion

        #region CertificateResource
        /// <summary>
        /// Gets an object representing a <see cref="CertificateResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="CertificateResource.CreateResourceIdentifier" /> to create a <see cref="CertificateResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="CertificateResource" /> object. </returns>
        public static CertificateResource GetCertificateResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                CertificateResource.ValidateResourceId(id);
                return new CertificateResource(client, id);
            }
            );
        }
        #endregion

        #region ConnectionResource
        /// <summary>
        /// Gets an object representing a <see cref="ConnectionResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ConnectionResource.CreateResourceIdentifier" /> to create a <see cref="ConnectionResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ConnectionResource" /> object. </returns>
        public static ConnectionResource GetConnectionResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                ConnectionResource.ValidateResourceId(id);
                return new ConnectionResource(client, id);
            }
            );
        }
        #endregion

        #region ConnectionTypeResource
        /// <summary>
        /// Gets an object representing a <see cref="ConnectionTypeResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ConnectionTypeResource.CreateResourceIdentifier" /> to create a <see cref="ConnectionTypeResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ConnectionTypeResource" /> object. </returns>
        public static ConnectionTypeResource GetConnectionTypeResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                ConnectionTypeResource.ValidateResourceId(id);
                return new ConnectionTypeResource(client, id);
            }
            );
        }
        #endregion

        #region CredentialResource
        /// <summary>
        /// Gets an object representing a <see cref="CredentialResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="CredentialResource.CreateResourceIdentifier" /> to create a <see cref="CredentialResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="CredentialResource" /> object. </returns>
        public static CredentialResource GetCredentialResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                CredentialResource.ValidateResourceId(id);
                return new CredentialResource(client, id);
            }
            );
        }
        #endregion

        #region JobScheduleResource
        /// <summary>
        /// Gets an object representing a <see cref="JobScheduleResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="JobScheduleResource.CreateResourceIdentifier" /> to create a <see cref="JobScheduleResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="JobScheduleResource" /> object. </returns>
        public static JobScheduleResource GetJobScheduleResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                JobScheduleResource.ValidateResourceId(id);
                return new JobScheduleResource(client, id);
            }
            );
        }
        #endregion

        #region ScheduleResource
        /// <summary>
        /// Gets an object representing a <see cref="ScheduleResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ScheduleResource.CreateResourceIdentifier" /> to create a <see cref="ScheduleResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ScheduleResource" /> object. </returns>
        public static ScheduleResource GetScheduleResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                ScheduleResource.ValidateResourceId(id);
                return new ScheduleResource(client, id);
            }
            );
        }
        #endregion

        #region VariableResource
        /// <summary>
        /// Gets an object representing a <see cref="VariableResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="VariableResource.CreateResourceIdentifier" /> to create a <see cref="VariableResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="VariableResource" /> object. </returns>
        public static VariableResource GetVariableResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                VariableResource.ValidateResourceId(id);
                return new VariableResource(client, id);
            }
            );
        }
        #endregion

        #region WatcherResource
        /// <summary>
        /// Gets an object representing a <see cref="WatcherResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="WatcherResource.CreateResourceIdentifier" /> to create a <see cref="WatcherResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="WatcherResource" /> object. </returns>
        public static WatcherResource GetWatcherResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                WatcherResource.ValidateResourceId(id);
                return new WatcherResource(client, id);
            }
            );
        }
        #endregion

        #region DscConfigurationResource
        /// <summary>
        /// Gets an object representing a <see cref="DscConfigurationResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="DscConfigurationResource.CreateResourceIdentifier" /> to create a <see cref="DscConfigurationResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="DscConfigurationResource" /> object. </returns>
        public static DscConfigurationResource GetDscConfigurationResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                DscConfigurationResource.ValidateResourceId(id);
                return new DscConfigurationResource(client, id);
            }
            );
        }
        #endregion

        #region JobResource
        /// <summary>
        /// Gets an object representing a <see cref="JobResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="JobResource.CreateResourceIdentifier" /> to create a <see cref="JobResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="JobResource" /> object. </returns>
        public static JobResource GetJobResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                JobResource.ValidateResourceId(id);
                return new JobResource(client, id);
            }
            );
        }
        #endregion

        #region SoftwareUpdateConfigurationResource
        /// <summary>
        /// Gets an object representing a <see cref="SoftwareUpdateConfigurationResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="SoftwareUpdateConfigurationResource.CreateResourceIdentifier" /> to create a <see cref="SoftwareUpdateConfigurationResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="SoftwareUpdateConfigurationResource" /> object. </returns>
        public static SoftwareUpdateConfigurationResource GetSoftwareUpdateConfigurationResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                SoftwareUpdateConfigurationResource.ValidateResourceId(id);
                return new SoftwareUpdateConfigurationResource(client, id);
            }
            );
        }
        #endregion

        #region RunbookResource
        /// <summary>
        /// Gets an object representing a <see cref="RunbookResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="RunbookResource.CreateResourceIdentifier" /> to create a <see cref="RunbookResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="RunbookResource" /> object. </returns>
        public static RunbookResource GetRunbookResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                RunbookResource.ValidateResourceId(id);
                return new RunbookResource(client, id);
            }
            );
        }
        #endregion

        #region WebhookResource
        /// <summary>
        /// Gets an object representing a <see cref="WebhookResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="WebhookResource.CreateResourceIdentifier" /> to create a <see cref="WebhookResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="WebhookResource" /> object. </returns>
        public static WebhookResource GetWebhookResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                WebhookResource.ValidateResourceId(id);
                return new WebhookResource(client, id);
            }
            );
        }
        #endregion

        #region HybridRunbookWorkerResource
        /// <summary>
        /// Gets an object representing a <see cref="HybridRunbookWorkerResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="HybridRunbookWorkerResource.CreateResourceIdentifier" /> to create a <see cref="HybridRunbookWorkerResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="HybridRunbookWorkerResource" /> object. </returns>
        public static HybridRunbookWorkerResource GetHybridRunbookWorkerResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                HybridRunbookWorkerResource.ValidateResourceId(id);
                return new HybridRunbookWorkerResource(client, id);
            }
            );
        }
        #endregion

        #region HybridRunbookWorkerGroupResource
        /// <summary>
        /// Gets an object representing a <see cref="HybridRunbookWorkerGroupResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="HybridRunbookWorkerGroupResource.CreateResourceIdentifier" /> to create a <see cref="HybridRunbookWorkerGroupResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="HybridRunbookWorkerGroupResource" /> object. </returns>
        public static HybridRunbookWorkerGroupResource GetHybridRunbookWorkerGroupResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                HybridRunbookWorkerGroupResource.ValidateResourceId(id);
                return new HybridRunbookWorkerGroupResource(client, id);
            }
            );
        }
        #endregion
    }
}
