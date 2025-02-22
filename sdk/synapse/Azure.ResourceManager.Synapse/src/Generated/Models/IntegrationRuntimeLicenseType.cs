// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Synapse.Models
{
    /// <summary> License type for bringing your own license scenario. </summary>
    public readonly partial struct IntegrationRuntimeLicenseType : IEquatable<IntegrationRuntimeLicenseType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="IntegrationRuntimeLicenseType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public IntegrationRuntimeLicenseType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string BasePriceValue = "BasePrice";
        private const string LicenseIncludedValue = "LicenseIncluded";

        /// <summary> BasePrice. </summary>
        public static IntegrationRuntimeLicenseType BasePrice { get; } = new IntegrationRuntimeLicenseType(BasePriceValue);
        /// <summary> LicenseIncluded. </summary>
        public static IntegrationRuntimeLicenseType LicenseIncluded { get; } = new IntegrationRuntimeLicenseType(LicenseIncludedValue);
        /// <summary> Determines if two <see cref="IntegrationRuntimeLicenseType"/> values are the same. </summary>
        public static bool operator ==(IntegrationRuntimeLicenseType left, IntegrationRuntimeLicenseType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="IntegrationRuntimeLicenseType"/> values are not the same. </summary>
        public static bool operator !=(IntegrationRuntimeLicenseType left, IntegrationRuntimeLicenseType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="IntegrationRuntimeLicenseType"/>. </summary>
        public static implicit operator IntegrationRuntimeLicenseType(string value) => new IntegrationRuntimeLicenseType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is IntegrationRuntimeLicenseType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(IntegrationRuntimeLicenseType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
