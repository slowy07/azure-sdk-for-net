// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DesktopVirtualization.Models
{
    /// <summary> HostPool properties that can be patched. </summary>
    public partial class HostPoolPatch : ResourceData
    {
        /// <summary> Initializes a new instance of HostPoolPatch. </summary>
        public HostPoolPatch()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of HostPoolPatch. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> tags to be updated. </param>
        /// <param name="friendlyName"> Friendly name of HostPool. </param>
        /// <param name="description"> Description of HostPool. </param>
        /// <param name="customRdpProperty"> Custom rdp property of HostPool. </param>
        /// <param name="maxSessionLimit"> The max session limit of HostPool. </param>
        /// <param name="personalDesktopAssignmentType"> PersonalDesktopAssignment type for HostPool. </param>
        /// <param name="loadBalancerType"> The type of the load balancer. </param>
        /// <param name="ring"> The ring number of HostPool. </param>
        /// <param name="isValidationEnvironment"> Is validation environment. </param>
        /// <param name="registrationInfo"> The registration info of HostPool. </param>
        /// <param name="vmTemplate"> VM template for sessionhosts configuration within hostpool. </param>
        /// <param name="ssoAdfsAuthority"> URL to customer ADFS server for signing WVD SSO certificates. </param>
        /// <param name="ssoClientId"> ClientId for the registered Relying Party used to issue WVD SSO certificates. </param>
        /// <param name="ssoClientSecretKeyVaultPath"> Path to Azure KeyVault storing the secret used for communication to ADFS. </param>
        /// <param name="ssoSecretType"> The type of single sign on Secret Type. </param>
        /// <param name="preferredAppGroupType"> The type of preferred application group type, default to Desktop Application Group. </param>
        /// <param name="startVmOnConnect"> The flag to turn on/off StartVMOnConnect feature. </param>
        internal HostPoolPatch(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, string friendlyName, string description, string customRdpProperty, int? maxSessionLimit, PersonalDesktopAssignmentType? personalDesktopAssignmentType, HostPoolLoadBalancerType? loadBalancerType, int? ring, bool? isValidationEnvironment, HostPoolRegistrationInfoPatch registrationInfo, string vmTemplate, string ssoAdfsAuthority, string ssoClientId, string ssoClientSecretKeyVaultPath, HostPoolSsoSecretType? ssoSecretType, PreferredAppGroupType? preferredAppGroupType, bool? startVmOnConnect) : base(id, name, resourceType, systemData)
        {
            Tags = tags;
            FriendlyName = friendlyName;
            Description = description;
            CustomRdpProperty = customRdpProperty;
            MaxSessionLimit = maxSessionLimit;
            PersonalDesktopAssignmentType = personalDesktopAssignmentType;
            LoadBalancerType = loadBalancerType;
            Ring = ring;
            IsValidationEnvironment = isValidationEnvironment;
            RegistrationInfo = registrationInfo;
            VmTemplate = vmTemplate;
            SsoAdfsAuthority = ssoAdfsAuthority;
            SsoClientId = ssoClientId;
            SsoClientSecretKeyVaultPath = ssoClientSecretKeyVaultPath;
            SsoSecretType = ssoSecretType;
            PreferredAppGroupType = preferredAppGroupType;
            StartVmOnConnect = startVmOnConnect;
        }

        /// <summary> tags to be updated. </summary>
        public IDictionary<string, string> Tags { get; }
        /// <summary> Friendly name of HostPool. </summary>
        public string FriendlyName { get; set; }
        /// <summary> Description of HostPool. </summary>
        public string Description { get; set; }
        /// <summary> Custom rdp property of HostPool. </summary>
        public string CustomRdpProperty { get; set; }
        /// <summary> The max session limit of HostPool. </summary>
        public int? MaxSessionLimit { get; set; }
        /// <summary> PersonalDesktopAssignment type for HostPool. </summary>
        public PersonalDesktopAssignmentType? PersonalDesktopAssignmentType { get; set; }
        /// <summary> The type of the load balancer. </summary>
        public HostPoolLoadBalancerType? LoadBalancerType { get; set; }
        /// <summary> The ring number of HostPool. </summary>
        public int? Ring { get; set; }
        /// <summary> Is validation environment. </summary>
        public bool? IsValidationEnvironment { get; set; }
        /// <summary> The registration info of HostPool. </summary>
        public HostPoolRegistrationInfoPatch RegistrationInfo { get; set; }
        /// <summary> VM template for sessionhosts configuration within hostpool. </summary>
        public string VmTemplate { get; set; }
        /// <summary> URL to customer ADFS server for signing WVD SSO certificates. </summary>
        public string SsoAdfsAuthority { get; set; }
        /// <summary> ClientId for the registered Relying Party used to issue WVD SSO certificates. </summary>
        public string SsoClientId { get; set; }
        /// <summary> Path to Azure KeyVault storing the secret used for communication to ADFS. </summary>
        public string SsoClientSecretKeyVaultPath { get; set; }
        /// <summary> The type of single sign on Secret Type. </summary>
        public HostPoolSsoSecretType? SsoSecretType { get; set; }
        /// <summary> The type of preferred application group type, default to Desktop Application Group. </summary>
        public PreferredAppGroupType? PreferredAppGroupType { get; set; }
        /// <summary> The flag to turn on/off StartVMOnConnect feature. </summary>
        public bool? StartVmOnConnect { get; set; }
    }
}
