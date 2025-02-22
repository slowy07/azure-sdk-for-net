// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.DataBox.Models
{
    /// <summary> Additional delivery info. </summary>
    internal partial class JobDeliveryInfo
    {
        /// <summary> Initializes a new instance of JobDeliveryInfo. </summary>
        public JobDeliveryInfo()
        {
        }

        /// <summary> Initializes a new instance of JobDeliveryInfo. </summary>
        /// <param name="scheduledOn"> Scheduled date time. </param>
        internal JobDeliveryInfo(DateTimeOffset? scheduledOn)
        {
            ScheduledOn = scheduledOn;
        }

        /// <summary> Scheduled date time. </summary>
        public DateTimeOffset? ScheduledOn { get; set; }
    }
}
