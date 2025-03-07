// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    public partial class AzureFileShareProtectionPolicy : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(WorkLoadType))
            {
                writer.WritePropertyName("workLoadType");
                writer.WriteStringValue(WorkLoadType.Value.ToString());
            }
            if (Optional.IsDefined(SchedulePolicy))
            {
                writer.WritePropertyName("schedulePolicy");
                writer.WriteObjectValue(SchedulePolicy);
            }
            if (Optional.IsDefined(RetentionPolicy))
            {
                writer.WritePropertyName("retentionPolicy");
                writer.WriteObjectValue(RetentionPolicy);
            }
            if (Optional.IsDefined(TimeZone))
            {
                writer.WritePropertyName("timeZone");
                writer.WriteStringValue(TimeZone);
            }
            if (Optional.IsDefined(ProtectedItemsCount))
            {
                writer.WritePropertyName("protectedItemsCount");
                writer.WriteNumberValue(ProtectedItemsCount.Value);
            }
            writer.WritePropertyName("backupManagementType");
            writer.WriteStringValue(BackupManagementType);
            if (Optional.IsCollectionDefined(ResourceGuardOperationRequests))
            {
                writer.WritePropertyName("resourceGuardOperationRequests");
                writer.WriteStartArray();
                foreach (var item in ResourceGuardOperationRequests)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static AzureFileShareProtectionPolicy DeserializeAzureFileShareProtectionPolicy(JsonElement element)
        {
            Optional<WorkloadType> workLoadType = default;
            Optional<SchedulePolicy> schedulePolicy = default;
            Optional<RetentionPolicy> retentionPolicy = default;
            Optional<string> timeZone = default;
            Optional<int> protectedItemsCount = default;
            string backupManagementType = default;
            Optional<IList<string>> resourceGuardOperationRequests = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("workLoadType"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    workLoadType = new WorkloadType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("schedulePolicy"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    schedulePolicy = SchedulePolicy.DeserializeSchedulePolicy(property.Value);
                    continue;
                }
                if (property.NameEquals("retentionPolicy"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    retentionPolicy = RetentionPolicy.DeserializeRetentionPolicy(property.Value);
                    continue;
                }
                if (property.NameEquals("timeZone"))
                {
                    timeZone = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("protectedItemsCount"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    protectedItemsCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("backupManagementType"))
                {
                    backupManagementType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resourceGuardOperationRequests"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    resourceGuardOperationRequests = array;
                    continue;
                }
            }
            return new AzureFileShareProtectionPolicy(Optional.ToNullable(protectedItemsCount), backupManagementType, Optional.ToList(resourceGuardOperationRequests), Optional.ToNullable(workLoadType), schedulePolicy.Value, retentionPolicy.Value, timeZone.Value);
        }
    }
}
