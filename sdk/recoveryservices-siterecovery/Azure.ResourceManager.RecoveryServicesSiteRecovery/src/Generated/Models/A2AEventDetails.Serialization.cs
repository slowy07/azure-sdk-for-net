// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class A2AEventDetails
    {
        internal static A2AEventDetails DeserializeA2AEventDetails(JsonElement element)
        {
            Optional<string> protectedItemName = default;
            Optional<string> fabricObjectId = default;
            Optional<string> fabricName = default;
            Optional<string> fabricLocation = default;
            Optional<string> remoteFabricName = default;
            Optional<string> remoteFabricLocation = default;
            string instanceType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("protectedItemName"))
                {
                    protectedItemName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("fabricObjectId"))
                {
                    fabricObjectId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("fabricName"))
                {
                    fabricName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("fabricLocation"))
                {
                    fabricLocation = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("remoteFabricName"))
                {
                    remoteFabricName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("remoteFabricLocation"))
                {
                    remoteFabricLocation = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("instanceType"))
                {
                    instanceType = property.Value.GetString();
                    continue;
                }
            }
            return new A2AEventDetails(instanceType, protectedItemName.Value, fabricObjectId.Value, fabricName.Value, fabricLocation.Value, remoteFabricName.Value, remoteFabricLocation.Value);
        }
    }
}
