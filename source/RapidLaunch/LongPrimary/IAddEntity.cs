﻿// <copyright file="IAddEntity.cs" company="Michael Bradvica LLC">
// Copyright (c) Michael Bradvica LLC. All rights reserved.
// </copyright>

using ClearDomain.LongPrimary;
using RapidLaunch.Common;

namespace RapidLaunch.LongPrimary
{
    /// <inheritdoc />
    public interface IAddEntity<in TEntity> : IAddEntity<TEntity, long>
        where TEntity : IAggregateRoot
    {
    }
}
