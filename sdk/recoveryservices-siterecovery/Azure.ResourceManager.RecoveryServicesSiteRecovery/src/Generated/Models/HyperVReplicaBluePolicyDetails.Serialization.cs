// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class HyperVReplicaBluePolicyDetails
    {
        internal static HyperVReplicaBluePolicyDetails DeserializeHyperVReplicaBluePolicyDetails(JsonElement element)
        {
            Optional<int> replicationFrequencyInSeconds = default;
            Optional<int> recoveryPoints = default;
            Optional<int> applicationConsistentSnapshotFrequencyInHours = default;
            Optional<string> compression = default;
            Optional<string> initialReplicationMethod = default;
            Optional<string> onlineReplicationStartTime = default;
            Optional<string> offlineReplicationImportPath = default;
            Optional<string> offlineReplicationExportPath = default;
            Optional<int> replicationPort = default;
            Optional<int> allowedAuthenticationType = default;
            Optional<string> replicaDeletionOption = default;
            string instanceType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("replicationFrequencyInSeconds"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    replicationFrequencyInSeconds = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("recoveryPoints"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    recoveryPoints = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("applicationConsistentSnapshotFrequencyInHours"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    applicationConsistentSnapshotFrequencyInHours = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("compression"))
                {
                    compression = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("initialReplicationMethod"))
                {
                    initialReplicationMethod = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("onlineReplicationStartTime"))
                {
                    onlineReplicationStartTime = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("offlineReplicationImportPath"))
                {
                    offlineReplicationImportPath = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("offlineReplicationExportPath"))
                {
                    offlineReplicationExportPath = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("replicationPort"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    replicationPort = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("allowedAuthenticationType"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    allowedAuthenticationType = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("replicaDeletionOption"))
                {
                    replicaDeletionOption = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("instanceType"))
                {
                    instanceType = property.Value.GetString();
                    continue;
                }
            }
            return new HyperVReplicaBluePolicyDetails(instanceType, Optional.ToNullable(replicationFrequencyInSeconds), Optional.ToNullable(recoveryPoints), Optional.ToNullable(applicationConsistentSnapshotFrequencyInHours), compression.Value, initialReplicationMethod.Value, onlineReplicationStartTime.Value, offlineReplicationImportPath.Value, offlineReplicationExportPath.Value, Optional.ToNullable(replicationPort), Optional.ToNullable(allowedAuthenticationType), replicaDeletionOption.Value);
        }
    }
}
