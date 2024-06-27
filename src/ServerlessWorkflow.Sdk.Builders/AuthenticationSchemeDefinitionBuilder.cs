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

namespace ServerlessWorkflow.Sdk.Builders;

/// <summary>
/// Represents the base class for all <see cref="IAuthenticationSchemeDefinitionBuilder"/> implementations
/// </summary>
/// <typeparam name="TDefinition">The type of the <see cref="AuthenticationSchemeDefinition"/> to build</typeparam>
public abstract class AuthenticationSchemeDefinitionBuilder<TDefinition>
    : IAuthenticationSchemeDefinitionBuilder<TDefinition>
    where TDefinition : AuthenticationSchemeDefinition
{

    /// <summary>
    /// Gets the name of the secret to load the authentication scheme definition from
    /// </summary>
    protected string? Secret { get; private set; }

    /// <inheritdoc/>
    public virtual void Use(string secret)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(secret);
        this.Secret = secret;
    }

    /// <inheritdoc/>
    public abstract TDefinition Build();

    AuthenticationSchemeDefinition IAuthenticationSchemeDefinitionBuilder.Build() => this.Build();

}
