// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Reservations.Models
{
    public partial class RefundPolicyResultProperty
    {
        internal static RefundPolicyResultProperty DeserializeRefundPolicyResultProperty(JsonElement element)
        {
            Optional<PurchasePrice> consumedRefundsTotal = default;
            Optional<PurchasePrice> maxRefundLimit = default;
            Optional<IReadOnlyList<RefundPolicyError>> policyErrors = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("consumedRefundsTotal"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    consumedRefundsTotal = PurchasePrice.DeserializePurchasePrice(property.Value);
                    continue;
                }
                if (property.NameEquals("maxRefundLimit"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    maxRefundLimit = PurchasePrice.DeserializePurchasePrice(property.Value);
                    continue;
                }
                if (property.NameEquals("policyErrors"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<RefundPolicyError> array = new List<RefundPolicyError>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(RefundPolicyError.DeserializeRefundPolicyError(item));
                    }
                    policyErrors = array;
                    continue;
                }
            }
            return new RefundPolicyResultProperty(consumedRefundsTotal.Value, maxRefundLimit.Value, Optional.ToList(policyErrors));
        }
    }
}
