// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Workloads.Models
{
    /// <summary> Gets or sets the DB2 provider properties. </summary>
    public partial class DB2ProviderInstanceProperties : ProviderSpecificProperties
    {
        /// <summary> Initializes a new instance of DB2ProviderInstanceProperties. </summary>
        public DB2ProviderInstanceProperties()
        {
            ProviderType = "Db2";
        }

        /// <summary> Initializes a new instance of DB2ProviderInstanceProperties. </summary>
        /// <param name="providerType"> The provider type. For example, the value can be SapHana. </param>
        /// <param name="hostname"> Gets or sets the target virtual machine name. </param>
        /// <param name="dbName"> Gets or sets the db2 database name. </param>
        /// <param name="dbPort"> Gets or sets the db2 database sql port. </param>
        /// <param name="dbUsername"> Gets or sets the db2 database user name. </param>
        /// <param name="dbPassword"> Gets or sets the db2 database password. </param>
        /// <param name="dbPasswordUri"> Gets or sets the key vault URI to secret with the database password. </param>
        /// <param name="sapSid"> Gets or sets the SAP System Identifier. </param>
        internal DB2ProviderInstanceProperties(string providerType, string hostname, string dbName, string dbPort, string dbUsername, string dbPassword, Uri dbPasswordUri, string sapSid) : base(providerType)
        {
            Hostname = hostname;
            DBName = dbName;
            DBPort = dbPort;
            DBUsername = dbUsername;
            DBPassword = dbPassword;
            DBPasswordUri = dbPasswordUri;
            SapSid = sapSid;
            ProviderType = providerType ?? "Db2";
        }

        /// <summary> Gets or sets the target virtual machine name. </summary>
        public string Hostname { get; set; }
        /// <summary> Gets or sets the db2 database name. </summary>
        public string DBName { get; set; }
        /// <summary> Gets or sets the db2 database sql port. </summary>
        public string DBPort { get; set; }
        /// <summary> Gets or sets the db2 database user name. </summary>
        public string DBUsername { get; set; }
        /// <summary> Gets or sets the db2 database password. </summary>
        public string DBPassword { get; set; }
        /// <summary> Gets or sets the key vault URI to secret with the database password. </summary>
        public Uri DBPasswordUri { get; set; }
        /// <summary> Gets or sets the SAP System Identifier. </summary>
        public string SapSid { get; set; }
    }
}
