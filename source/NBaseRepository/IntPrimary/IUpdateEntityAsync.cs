﻿// <copyright file="IUpdateEntityAsync.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace NBaseRepository.IntPrimary
{
    using NBaseRepository.Common;

    /// <summary>
    /// An interface used to describe a class that can update an entity of type <see cref="TEntity"/>.
    /// </summary>
    /// <typeparam name="TEntity">The type of the entity.</typeparam>
    public interface IUpdateEntityAsync<in TEntity> : IUpdateEntityAsync<TEntity, int>
        where TEntity : IEntity
    {
    }
}
