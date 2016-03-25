// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.14.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.RemoteApp.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// A list of virtual machine details
    /// </summary>
    public partial class VirtualMachineDetailsListResult
    {
        /// <summary>
        /// Initializes a new instance of the VirtualMachineDetailsListResult
        /// class.
        /// </summary>
        public VirtualMachineDetailsListResult() { }

        /// <summary>
        /// Initializes a new instance of the VirtualMachineDetailsListResult
        /// class.
        /// </summary>
        public VirtualMachineDetailsListResult(IList<VmDetails> value = default(IList<VmDetails>), string nextLink = default(string))
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary>
        /// A list of virtual machine details
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public IList<VmDetails> Value { get; set; }

        /// <summary>
        /// URL to use for request paging.
        /// </summary>
        [JsonProperty(PropertyName = "nextLink")]
        public string NextLink { get; set; }

    }
}
