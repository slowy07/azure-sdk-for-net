// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class A2AProtectionContainerMappingDetails
    {
        internal static A2AProtectionContainerMappingDetails DeserializeA2AProtectionContainerMappingDetails(JsonElement element)
        {
            Optional<AgentAutoUpdateStatus> agentAutoUpdateStatus = default;
            Optional<string> automationAccountArmId = default;
            Optional<AutomationAccountAuthenticationType> automationAccountAuthenticationType = default;
            Optional<string> scheduleName = default;
            Optional<string> jobScheduleName = default;
            string instanceType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("agentAutoUpdateStatus"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    agentAutoUpdateStatus = new AgentAutoUpdateStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("automationAccountArmId"))
                {
                    automationAccountArmId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("automationAccountAuthenticationType"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    automationAccountAuthenticationType = new AutomationAccountAuthenticationType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("scheduleName"))
                {
                    scheduleName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("jobScheduleName"))
                {
                    jobScheduleName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("instanceType"))
                {
                    instanceType = property.Value.GetString();
                    continue;
                }
            }
            return new A2AProtectionContainerMappingDetails(instanceType, Optional.ToNullable(agentAutoUpdateStatus), automationAccountArmId.Value, Optional.ToNullable(automationAccountAuthenticationType), scheduleName.Value, jobScheduleName.Value);
        }
    }
}
