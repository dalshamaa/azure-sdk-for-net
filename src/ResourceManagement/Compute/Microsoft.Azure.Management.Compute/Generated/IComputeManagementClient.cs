// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.15.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Compute
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;

    /// <summary>
    /// Composite Swagger for Compute Client
    /// </summary>
    public partial interface IComputeManagementClient : IDisposable
    {
        /// <summary>
        /// The base URI of the service.
        /// </summary>
        Uri BaseUri { get; set; }

        /// <summary>
        /// Gets or sets json serialization settings.
        /// </summary>
        JsonSerializerSettings SerializationSettings { get; }

        /// <summary>
        /// Gets or sets json deserialization settings.
        /// </summary>
        JsonSerializerSettings DeserializationSettings { get; }

        /// <summary>
        /// Gets Azure subscription credentials.
        /// </summary>
        ServiceClientCredentials Credentials { get; }

        /// <summary>
        /// Gets subscription credentials which uniquely identify Microsoft
        /// Azure subscription. The subscription ID forms part of the URI for
        /// every service call.
        /// </summary>
        string SubscriptionId { get; set; }

        /// <summary>
        /// Gets or sets the preferred language for the response.
        /// </summary>
        string AcceptLanguage { get; set; }

        /// <summary>
        /// Gets or sets the retry timeout in seconds for Long Running
        /// Operations. Default value is 30.
        /// </summary>
        int? LongRunningOperationRetryTimeout { get; set; }

        /// <summary>
        /// When set to true a unique x-ms-client-request-id value is
        /// generated and included in each request. Default is true.
        /// </summary>
        bool? GenerateClientRequestId { get; set; }


        /// <summary>
        /// Gets the IAvailabilitySetsOperations.
        /// </summary>
        IAvailabilitySetsOperations AvailabilitySets { get; }

        /// <summary>
        /// Gets the IVirtualMachineExtensionImagesOperations.
        /// </summary>
        IVirtualMachineExtensionImagesOperations VirtualMachineExtensionImages { get; }

        /// <summary>
        /// Gets the IVirtualMachineExtensionsOperations.
        /// </summary>
        IVirtualMachineExtensionsOperations VirtualMachineExtensions { get; }

        /// <summary>
        /// Gets the IVirtualMachineImagesOperations.
        /// </summary>
        IVirtualMachineImagesOperations VirtualMachineImages { get; }

        /// <summary>
        /// Gets the IUsageOperations.
        /// </summary>
        IUsageOperations Usage { get; }

        /// <summary>
        /// Gets the IVirtualMachineSizesOperations.
        /// </summary>
        IVirtualMachineSizesOperations VirtualMachineSizes { get; }

        /// <summary>
        /// Gets the IVirtualMachinesOperations.
        /// </summary>
        IVirtualMachinesOperations VirtualMachines { get; }

        /// <summary>
        /// Gets the IVirtualMachineScaleSetsOperations.
        /// </summary>
        IVirtualMachineScaleSetsOperations VirtualMachineScaleSets { get; }

        /// <summary>
        /// Gets the IVirtualMachineScaleSetVMsOperations.
        /// </summary>
        IVirtualMachineScaleSetVMsOperations VirtualMachineScaleSetVMs { get; }

    }
}
