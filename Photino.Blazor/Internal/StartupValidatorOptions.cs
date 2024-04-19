﻿#if NET6_0 || NET7_0

// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Microsoft.Extensions.Options;

internal sealed class StartupValidatorOptions
{
    // Maps each pair of a) options type and b) options name to a method that forces its evaluation, e.g. IOptionsMonitor<TOptions>.Get(name)
    public Dictionary<(Type, string), Action> _validators { get; } = new Dictionary<(Type, string), Action>();
}

#endif