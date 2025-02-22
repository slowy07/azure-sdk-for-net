// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.SecurityInsights.Models
{
    /// <summary> The EntityQueryItemPropertiesDataTypesItem. </summary>
    public partial class EntityQueryItemPropertiesDataTypesItem
    {
        /// <summary> Initializes a new instance of EntityQueryItemPropertiesDataTypesItem. </summary>
        internal EntityQueryItemPropertiesDataTypesItem()
        {
        }

        /// <summary> Initializes a new instance of EntityQueryItemPropertiesDataTypesItem. </summary>
        /// <param name="dataType"> Data type name. </param>
        internal EntityQueryItemPropertiesDataTypesItem(string dataType)
        {
            DataType = dataType;
        }

        /// <summary> Data type name. </summary>
        public string DataType { get; }
    }
}
