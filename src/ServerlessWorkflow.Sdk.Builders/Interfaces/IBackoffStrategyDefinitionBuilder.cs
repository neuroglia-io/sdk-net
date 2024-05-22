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
/// Defines the fundamentals of a service used to build <see cref="BackoffStrategyDefinition"/>s
/// </summary>
public interface IBackoffStrategyDefinitionBuilder
{

    /// <summary>
    /// Configures a constant backoff strategy
    /// </summary>
    /// <returns>A new <see cref="IConstantBackoffDefinitionBuilder"/></returns>
    IConstantBackoffDefinitionBuilder Constant();

    /// <summary>
    /// Configures an exponential backoff strategy
    /// </summary>
    /// <returns>A new <see cref="IConstantBackoffDefinitionBuilder"/></returns>
    IExponentialBackoffDefinitionBuilder Exponential();

    /// <summary>
    /// Configures a linear backoff strategy
    /// </summary>
    /// <returns>A new <see cref="IConstantBackoffDefinitionBuilder"/></returns>
    ILinearBackoffDefinitionBuilder Linear(Duration? increment = null);

    /// <summary>
    /// Builds the configured <see cref="BackoffStrategyDefinition"/>
    /// </summary>
    /// <returns>A new <see cref="BackoffStrategyDefinition"/></returns>
    BackoffStrategyDefinition Build();

}
