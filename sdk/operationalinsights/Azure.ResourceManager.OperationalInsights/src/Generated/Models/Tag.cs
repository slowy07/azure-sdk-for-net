// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.OperationalInsights.Models
{
    /// <summary> A tag of a saved search. </summary>
    public partial class Tag
    {
        /// <summary> Initializes a new instance of Tag. </summary>
        /// <param name="name"> The tag name. </param>
        /// <param name="value"> The tag value. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="value"/> is null. </exception>
        public Tag(string name, string value)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }

            Name = name;
            Value = value;
        }

        /// <summary> The tag name. </summary>
        public string Name { get; set; }
        /// <summary> The tag value. </summary>
        public string Value { get; set; }
    }
}
