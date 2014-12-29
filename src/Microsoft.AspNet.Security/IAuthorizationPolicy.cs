// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Collections.Generic;

namespace Microsoft.AspNet.Security
{
    public interface IAuthorizationPolicy
    {
        IEnumerable<IAuthorizationRequirement> Requirements { get; }
    }
}
