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
/// Represents the default implementation of the <see cref="IAuthenticationPolicyDefinitionBuilder"/> interface
/// </summary>
public class AuthenticationPolicyDefinitionBuilder
    : IAuthenticationPolicyDefinitionBuilder
{

    /// <summary>
    /// Gets/sets the <see cref="AuthenticationSchemeDefinition"/> to use
    /// </summary>
    protected IAuthenticationSchemeDefinitionBuilder? SchemeBuilder { get; set; }

    /// <inheritdoc/>
    public virtual IBasicAuthenticationSchemeDefinitionBuilder Basic()
    {
        var builder = new BasicAuthenticationSchemeDefinitionBuilder();
        this.SchemeBuilder = builder;
        return builder;
    }

    /// <inheritdoc/>
    public virtual IBearerAuthenticationSchemeDefinitionBuilder Bearer()
    {
        var builder = new BearerAuthenticationSchemeDefinitionBuilder();
        this.SchemeBuilder = builder;
        return builder;
    }

    /// <inheritdoc/>
    public virtual IOAuth2AuthenticationSchemeDefinitionBuilder OAuth2()
    {
        var builder = new OAuth2AuthenticationSchemeDefinitionBuilder();
        this.SchemeBuilder = builder;
        return builder;
    }

    /// <inheritdoc/>
    public virtual AuthenticationPolicyDefinition Build()
    {
        if (this.SchemeBuilder == null) throw new NullReferenceException("The authentication scheme must be set");
        var scheme = this.SchemeBuilder.Build();
        return new()
        {
            Basic = scheme is BasicAuthenticationSchemeDefinition basic ? basic : null,
            Bearer = scheme is BearerAuthenticationSchemeDefinition bearer ? bearer : null,
            OAuth2 = scheme is OAuth2AuthenticationSchemeDefinition oauth2 ? oauth2 : null,
        };
    }

}
