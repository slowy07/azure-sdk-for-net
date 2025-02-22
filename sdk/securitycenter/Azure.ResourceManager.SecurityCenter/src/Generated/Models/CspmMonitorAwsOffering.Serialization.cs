// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    public partial class CspmMonitorAwsOffering : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(NativeCloudConnection))
            {
                writer.WritePropertyName("nativeCloudConnection");
                writer.WriteObjectValue(NativeCloudConnection);
            }
            writer.WritePropertyName("offeringType");
            writer.WriteStringValue(OfferingType.ToString());
            writer.WriteEndObject();
        }

        internal static CspmMonitorAwsOffering DeserializeCspmMonitorAwsOffering(JsonElement element)
        {
            Optional<CspmMonitorAwsOfferingNativeCloudConnection> nativeCloudConnection = default;
            OfferingType offeringType = default;
            Optional<string> description = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("nativeCloudConnection"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    nativeCloudConnection = CspmMonitorAwsOfferingNativeCloudConnection.DeserializeCspmMonitorAwsOfferingNativeCloudConnection(property.Value);
                    continue;
                }
                if (property.NameEquals("offeringType"))
                {
                    offeringType = new OfferingType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("description"))
                {
                    description = property.Value.GetString();
                    continue;
                }
            }
            return new CspmMonitorAwsOffering(offeringType, description.Value, nativeCloudConnection.Value);
        }
    }
}
