// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.ResourceManager.DataMigration.Models
{
    /// <summary> Input for the task that migrates MySQL databases to Azure Database for MySQL for offline migrations. </summary>
    public partial class MigrateMySqlAzureDBForMySqlOfflineTaskInput
    {
        /// <summary> Initializes a new instance of MigrateMySqlAzureDBForMySqlOfflineTaskInput. </summary>
        /// <param name="sourceConnectionInfo"> Connection information for source MySQL. </param>
        /// <param name="targetConnectionInfo"> Connection information for target Azure Database for MySQL. </param>
        /// <param name="selectedDatabases"> Databases to migrate. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="sourceConnectionInfo"/>, <paramref name="targetConnectionInfo"/> or <paramref name="selectedDatabases"/> is null. </exception>
        public MigrateMySqlAzureDBForMySqlOfflineTaskInput(MySqlConnectionInfo sourceConnectionInfo, MySqlConnectionInfo targetConnectionInfo, IEnumerable<MigrateMySqlAzureDBForMySqlOfflineDatabaseInput> selectedDatabases)
        {
            if (sourceConnectionInfo == null)
            {
                throw new ArgumentNullException(nameof(sourceConnectionInfo));
            }
            if (targetConnectionInfo == null)
            {
                throw new ArgumentNullException(nameof(targetConnectionInfo));
            }
            if (selectedDatabases == null)
            {
                throw new ArgumentNullException(nameof(selectedDatabases));
            }

            SourceConnectionInfo = sourceConnectionInfo;
            TargetConnectionInfo = targetConnectionInfo;
            SelectedDatabases = selectedDatabases.ToList();
            OptionalAgentSettings = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of MigrateMySqlAzureDBForMySqlOfflineTaskInput. </summary>
        /// <param name="sourceConnectionInfo"> Connection information for source MySQL. </param>
        /// <param name="targetConnectionInfo"> Connection information for target Azure Database for MySQL. </param>
        /// <param name="selectedDatabases"> Databases to migrate. </param>
        /// <param name="makeSourceServerReadOnly"> Setting to set the source server read only. </param>
        /// <param name="startedOn"> Parameter to specify when the migration started. </param>
        /// <param name="optionalAgentSettings"> Optional parameters for fine tuning the data transfer rate during migration. </param>
        /// <param name="encryptedKeyForSecureFields"> encrypted key for secure fields. </param>
        internal MigrateMySqlAzureDBForMySqlOfflineTaskInput(MySqlConnectionInfo sourceConnectionInfo, MySqlConnectionInfo targetConnectionInfo, IList<MigrateMySqlAzureDBForMySqlOfflineDatabaseInput> selectedDatabases, bool? makeSourceServerReadOnly, DateTimeOffset? startedOn, IDictionary<string, string> optionalAgentSettings, string encryptedKeyForSecureFields)
        {
            SourceConnectionInfo = sourceConnectionInfo;
            TargetConnectionInfo = targetConnectionInfo;
            SelectedDatabases = selectedDatabases;
            MakeSourceServerReadOnly = makeSourceServerReadOnly;
            StartedOn = startedOn;
            OptionalAgentSettings = optionalAgentSettings;
            EncryptedKeyForSecureFields = encryptedKeyForSecureFields;
        }

        /// <summary> Connection information for source MySQL. </summary>
        public MySqlConnectionInfo SourceConnectionInfo { get; set; }
        /// <summary> Connection information for target Azure Database for MySQL. </summary>
        public MySqlConnectionInfo TargetConnectionInfo { get; set; }
        /// <summary> Databases to migrate. </summary>
        public IList<MigrateMySqlAzureDBForMySqlOfflineDatabaseInput> SelectedDatabases { get; }
        /// <summary> Setting to set the source server read only. </summary>
        public bool? MakeSourceServerReadOnly { get; set; }
        /// <summary> Parameter to specify when the migration started. </summary>
        public DateTimeOffset? StartedOn { get; set; }
        /// <summary> Optional parameters for fine tuning the data transfer rate during migration. </summary>
        public IDictionary<string, string> OptionalAgentSettings { get; }
        /// <summary> encrypted key for secure fields. </summary>
        public string EncryptedKeyForSecureFields { get; set; }
    }
}
