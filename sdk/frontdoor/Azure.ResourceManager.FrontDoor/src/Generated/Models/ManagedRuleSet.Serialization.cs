// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.FrontDoor.Models
{
    public partial class ManagedRuleSet : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("ruleSetType");
            writer.WriteStringValue(RuleSetType);
            writer.WritePropertyName("ruleSetVersion");
            writer.WriteStringValue(RuleSetVersion);
            if (Optional.IsDefined(RuleSetAction))
            {
                writer.WritePropertyName("ruleSetAction");
                writer.WriteStringValue(RuleSetAction.Value.ToString());
            }
            if (Optional.IsCollectionDefined(Exclusions))
            {
                writer.WritePropertyName("exclusions");
                writer.WriteStartArray();
                foreach (var item in Exclusions)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(RuleGroupOverrides))
            {
                writer.WritePropertyName("ruleGroupOverrides");
                writer.WriteStartArray();
                foreach (var item in RuleGroupOverrides)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static ManagedRuleSet DeserializeManagedRuleSet(JsonElement element)
        {
            string ruleSetType = default;
            string ruleSetVersion = default;
            Optional<ManagedRuleSetActionType> ruleSetAction = default;
            Optional<IList<ManagedRuleExclusion>> exclusions = default;
            Optional<IList<ManagedRuleGroupOverride>> ruleGroupOverrides = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("ruleSetType"))
                {
                    ruleSetType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("ruleSetVersion"))
                {
                    ruleSetVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("ruleSetAction"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    ruleSetAction = new ManagedRuleSetActionType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("exclusions"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<ManagedRuleExclusion> array = new List<ManagedRuleExclusion>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ManagedRuleExclusion.DeserializeManagedRuleExclusion(item));
                    }
                    exclusions = array;
                    continue;
                }
                if (property.NameEquals("ruleGroupOverrides"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<ManagedRuleGroupOverride> array = new List<ManagedRuleGroupOverride>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ManagedRuleGroupOverride.DeserializeManagedRuleGroupOverride(item));
                    }
                    ruleGroupOverrides = array;
                    continue;
                }
            }
            return new ManagedRuleSet(ruleSetType, ruleSetVersion, Optional.ToNullable(ruleSetAction), Optional.ToList(exclusions), Optional.ToList(ruleGroupOverrides));
        }
    }
}
