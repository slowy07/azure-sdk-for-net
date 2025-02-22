// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Logic.Models
{
    /// <summary> The recurrence schedule. </summary>
    public partial class LogicWorkflowRecurrenceSchedule
    {
        /// <summary> Initializes a new instance of LogicWorkflowRecurrenceSchedule. </summary>
        public LogicWorkflowRecurrenceSchedule()
        {
            Minutes = new ChangeTrackingList<int>();
            Hours = new ChangeTrackingList<int>();
            WeekDays = new ChangeTrackingList<LogicWorkflowDayOfWeek>();
            MonthDays = new ChangeTrackingList<int>();
            MonthlyOccurrences = new ChangeTrackingList<LogicWorkflowRecurrenceScheduleOccurrence>();
        }

        /// <summary> Initializes a new instance of LogicWorkflowRecurrenceSchedule. </summary>
        /// <param name="minutes"> The minutes. </param>
        /// <param name="hours"> The hours. </param>
        /// <param name="weekDays"> The days of the week. </param>
        /// <param name="monthDays"> The month days. </param>
        /// <param name="monthlyOccurrences"> The monthly occurrences. </param>
        internal LogicWorkflowRecurrenceSchedule(IList<int> minutes, IList<int> hours, IList<LogicWorkflowDayOfWeek> weekDays, IList<int> monthDays, IList<LogicWorkflowRecurrenceScheduleOccurrence> monthlyOccurrences)
        {
            Minutes = minutes;
            Hours = hours;
            WeekDays = weekDays;
            MonthDays = monthDays;
            MonthlyOccurrences = monthlyOccurrences;
        }

        /// <summary> The minutes. </summary>
        public IList<int> Minutes { get; }
        /// <summary> The hours. </summary>
        public IList<int> Hours { get; }
        /// <summary> The days of the week. </summary>
        public IList<LogicWorkflowDayOfWeek> WeekDays { get; }
        /// <summary> The month days. </summary>
        public IList<int> MonthDays { get; }
        /// <summary> The monthly occurrences. </summary>
        public IList<LogicWorkflowRecurrenceScheduleOccurrence> MonthlyOccurrences { get; }
    }
}
