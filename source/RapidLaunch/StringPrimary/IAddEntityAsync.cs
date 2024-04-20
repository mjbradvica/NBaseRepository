﻿// <copyright file="IAddEntityAsync.cs" company="Michael Bradvica LLC">
// Copyright (c) Michael Bradvica LLC. All rights reserved.
// </copyright>

using ClearDomain.StringPrimary;
using RapidLaunch.Common;

namespace RapidLaunch.StringPrimary
{
    /// <inheritdoc />
    public interface IAddEntityAsync<in TEntity> : IAddEntityAsync<TEntity, string>
        where TEntity : IAggregateRoot
    {
    }
}
