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

namespace ServerlessWorkflow.Sdk.IO;

/// <summary>
/// Enumerates all types of reference resolution modes for relative <see cref="Uri"/>s
/// </summary>
public static class RelativeUriReferenceResolutionMode
{

    /// <summary>
    /// Indicates that relative uri instances should be converted to an absolute one by combining them to a specified base uri
    /// </summary>
    public const string ConvertToAbsolute = "convertToAbsolute";

    /// <summary>
    /// Indicates that relative uri instances should be converted to a file path relative to a specified base directory
    /// </summary>
    public const string ConvertToRelativeFilePath = "convertToRelativeFilePath";

    /// <summary>
    /// Indicates that relative uri instances should not be resolved
    /// </summary>
    public const string None = "none";

}