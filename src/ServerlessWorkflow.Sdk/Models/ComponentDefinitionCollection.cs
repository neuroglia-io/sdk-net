﻿// Copyright © 2024-Present The Serverless Workflow Specification Authors
//
// Licensed under the Apache License, Version 2.0 (the "License"),
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

namespace ServerlessWorkflow.Sdk.Models;

/// <summary>
/// Represents a collection of workflow components
/// </summary>
[DataContract]
public record ComponentDefinitionCollection
{

    /// <summary>
    /// Gets/sets a name/value mapping of the workflow's reusable authentication policies
    /// </summary>
    [DataMember(Name = "authentications", Order = 1), JsonPropertyName("authentications"), JsonPropertyOrder(1), YamlMember(Alias = "authentications", Order = 1)]
    public virtual EquatableDictionary<string, AuthenticationPolicyDefinition>? Authentications { get; set; }

    /// <summary>
    /// Gets/sets a name/value mapping of the catalogs, if any, from which to import reusable components used within the workflow
    /// </summary>
    [DataMember(Name = "catalogs", Order = 2), JsonPropertyName("catalogs"), JsonPropertyOrder(2), YamlMember(Alias = "catalogs", Order = 2)]
    public virtual EquatableDictionary<string, CatalogDefinition>? Catalogs { get; set; }

    /// <summary>
    /// Gets/sets a name/value mapping of the workflow's errors, if any
    /// </summary>
    [DataMember(Name = "errors", Order = 3), JsonPropertyName("errors"), JsonPropertyOrder(3), YamlMember(Alias = "errors", Order = 3)]
    public virtual EquatableDictionary<string, ErrorDefinition>? Errors { get; set; }

    /// <summary>
    /// Gets/sets a name/value mapping of the workflow's extensions, if any
    /// </summary>
    [DataMember(Name = "extensions", Order = 4), JsonPropertyName("extensions"), JsonPropertyOrder(4), YamlMember(Alias = "extensions", Order = 4)]
    public virtual EquatableDictionary<string, ExtensionDefinition>? Extensions { get; set; }

    /// <summary>
    /// Gets/sets a name/value mapping of the workflow's reusable functions
    /// </summary>
    [DataMember(Name = "functions", Order = 5), JsonPropertyName("functions"), JsonPropertyOrder(5), YamlMember(Alias = "functions", Order = 5)]
    public virtual EquatableDictionary<string, TaskDefinition>? Functions { get; set; }

    /// <summary>
    /// Gets/sets a name/value mapping of the workflow's reusable retry policies
    /// </summary>
    [DataMember(Name = "retries", Order = 6), JsonPropertyName("retries"), JsonPropertyOrder(6), YamlMember(Alias = "retries", Order = 6)]
    public virtual EquatableDictionary<string, RetryPolicyDefinition>? Retries { get; set; }

    /// <summary>
    /// Gets/sets a list containing the workflow's secrets
    /// </summary>
    [DataMember(Name = "secrets", Order = 7), JsonPropertyName("secrets"), JsonPropertyOrder(7), YamlMember(Alias = "secrets", Order = 7)]
    public virtual EquatableList<string>? Secrets { get; set; }

    /// <summary>
    /// Gets/sets a name/value mapping of the workflow's reusable timeouts
    /// </summary>
    [DataMember(Name = "timeouts", Order = 7), JsonPropertyName("timeouts"), JsonPropertyOrder(8), YamlMember(Alias = "timeouts", Order = 8)]
    public virtual EquatableDictionary<string, TimeoutDefinition>? Timeouts { get; set; }

}
