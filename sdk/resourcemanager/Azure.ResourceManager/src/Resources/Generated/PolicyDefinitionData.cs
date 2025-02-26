// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Resources
{
    /// <summary> A class representing the PolicyDefinition data model. </summary>
    public partial class PolicyDefinitionData : ResourceData
    {
        /// <summary> Initializes a new instance of PolicyDefinitionData. </summary>
        public PolicyDefinitionData()
        {
            Parameters = new ChangeTrackingDictionary<string, ParameterDefinitionsValue>();
        }

        /// <summary> Initializes a new instance of PolicyDefinitionData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="policyType"> The type of policy definition. Possible values are NotSpecified, BuiltIn, Custom, and Static. </param>
        /// <param name="mode"> The policy definition mode. Some examples are All, Indexed, Microsoft.KeyVault.Data. </param>
        /// <param name="displayName"> The display name of the policy definition. </param>
        /// <param name="description"> The policy definition description. </param>
        /// <param name="policyRule"> The policy rule. </param>
        /// <param name="metadata"> The policy definition metadata.  Metadata is an open ended object and is typically a collection of key value pairs. </param>
        /// <param name="parameters"> The parameter definitions for parameters used in the policy rule. The keys are the parameter names. </param>
        internal PolicyDefinitionData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, PolicyType? policyType, string mode, string displayName, string description, BinaryData policyRule, BinaryData metadata, IDictionary<string, ParameterDefinitionsValue> parameters) : base(id, name, resourceType, systemData)
        {
            PolicyType = policyType;
            Mode = mode;
            DisplayName = displayName;
            Description = description;
            PolicyRule = policyRule;
            Metadata = metadata;
            Parameters = parameters;
        }

        /// <summary> The type of policy definition. Possible values are NotSpecified, BuiltIn, Custom, and Static. </summary>
        public PolicyType? PolicyType { get; set; }
        /// <summary> The policy definition mode. Some examples are All, Indexed, Microsoft.KeyVault.Data. </summary>
        public string Mode { get; set; }
        /// <summary> The display name of the policy definition. </summary>
        public string DisplayName { get; set; }
        /// <summary> The policy definition description. </summary>
        public string Description { get; set; }
        /// <summary> The policy rule. </summary>
        public BinaryData PolicyRule { get; set; }
        /// <summary> The policy definition metadata.  Metadata is an open ended object and is typically a collection of key value pairs. </summary>
        public BinaryData Metadata { get; set; }
        /// <summary> The parameter definitions for parameters used in the policy rule. The keys are the parameter names. </summary>
        public IDictionary<string, ParameterDefinitionsValue> Parameters { get; }
    }
}
