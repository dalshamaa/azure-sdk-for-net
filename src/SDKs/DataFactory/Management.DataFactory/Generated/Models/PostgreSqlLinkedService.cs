// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataFactory.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Linked service for PostgreSQL data source.
    /// </summary>
    [Newtonsoft.Json.JsonObject("PostgreSql")]
    [Rest.Serialization.JsonTransformation]
    public partial class PostgreSqlLinkedService : LinkedService
    {
        /// <summary>
        /// Initializes a new instance of the PostgreSqlLinkedService class.
        /// </summary>
        public PostgreSqlLinkedService()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PostgreSqlLinkedService class.
        /// </summary>
        /// <param name="server">Server name for connection. Type: string (or
        /// Expression with resultType string).</param>
        /// <param name="database">Database name for connection. Type: string
        /// (or Expression with resultType string).</param>
        /// <param name="additionalProperties">Unmatched properties from the
        /// message are deserialized this collection</param>
        /// <param name="connectVia">The integration runtime reference.</param>
        /// <param name="description">Linked service description.</param>
        /// <param name="schema">Schema name for connection. Type: string (or
        /// Expression with resultType string).</param>
        /// <param name="username">Username for authentication. Type: string
        /// (or Expression with resultType string).</param>
        /// <param name="password">Password for authentication.</param>
        /// <param name="encryptedCredential">The encrypted credential used for
        /// authentication. Credentials are encrypted using the integration
        /// runtime credential manager. Type: string (or Expression with
        /// resultType string).</param>
        public PostgreSqlLinkedService(object server, object database, IDictionary<string, object> additionalProperties = default(IDictionary<string, object>), IntegrationRuntimeReference connectVia = default(IntegrationRuntimeReference), string description = default(string), object schema = default(object), object username = default(object), SecureString password = default(SecureString), object encryptedCredential = default(object))
            : base(additionalProperties, connectVia, description)
        {
            Server = server;
            Database = database;
            Schema = schema;
            Username = username;
            Password = password;
            EncryptedCredential = encryptedCredential;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets server name for connection. Type: string (or
        /// Expression with resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.server")]
        public object Server { get; set; }

        /// <summary>
        /// Gets or sets database name for connection. Type: string (or
        /// Expression with resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.database")]
        public object Database { get; set; }

        /// <summary>
        /// Gets or sets schema name for connection. Type: string (or
        /// Expression with resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.schema")]
        public object Schema { get; set; }

        /// <summary>
        /// Gets or sets username for authentication. Type: string (or
        /// Expression with resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.username")]
        public object Username { get; set; }

        /// <summary>
        /// Gets or sets password for authentication.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.password")]
        public SecureString Password { get; set; }

        /// <summary>
        /// Gets or sets the encrypted credential used for authentication.
        /// Credentials are encrypted using the integration runtime credential
        /// manager. Type: string (or Expression with resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.encryptedCredential")]
        public object EncryptedCredential { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (Server == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Server");
            }
            if (Database == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Database");
            }
            if (Password != null)
            {
                Password.Validate();
            }
        }
    }
}