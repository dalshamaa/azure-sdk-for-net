// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.11.0.0
// Changes may cause incorrect behavior and will be lost if the code is

namespace Microsoft.Azure.Management.Logic.Models
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// </summary>
    public partial class WorkflowRunFilter
    {
        /// <summary>
        /// Gets or sets the status of workflow run. Possible values for this
        /// property include: 'NotSpecified', 'Paused', 'Running', 'Waiting',
        /// 'Succeeded', 'Skipped', 'Suspended', 'Cancelled', 'Failed'
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public WorkflowStatus? Status { get; set; }

    }
}
