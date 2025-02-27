﻿// Copyright (c) 2019-2024 ReactiveUI Association Incorporated. All rights reserved.
// ReactiveUI Association Incorporated licenses this file to you under the MIT license.
// See the LICENSE file in the project root for full license information.

using System;
using System.Collections.Generic;

using NuGet.Packaging.Core;

namespace ReactiveMarbles.NuGet.Helpers;

internal class PackageIdentityNameComparer : IEqualityComparer<PackageIdentity>
{
    public static PackageIdentityNameComparer Default { get; } = new PackageIdentityNameComparer();

    /// <inheritdoc />
    public bool Equals(PackageIdentity x, PackageIdentity y) => x == y || StringComparer.OrdinalIgnoreCase.Equals(x?.Id, y?.Id);

    /// <inheritdoc />
    public int GetHashCode(PackageIdentity obj) => StringComparer.OrdinalIgnoreCase.GetHashCode(obj.Id);
}
