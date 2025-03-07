// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Synapse.Models
{
    public partial class LanguageExtensionsList : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Value))
            {
                writer.WritePropertyName("value");
                writer.WriteStartArray();
                foreach (var item in Value)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static LanguageExtensionsList DeserializeLanguageExtensionsList(JsonElement element)
        {
            Optional<IList<LanguageExtension>> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<LanguageExtension> array = new List<LanguageExtension>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(LanguageExtension.DeserializeLanguageExtension(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new LanguageExtensionsList(Optional.ToList(value));
        }
    }
}
