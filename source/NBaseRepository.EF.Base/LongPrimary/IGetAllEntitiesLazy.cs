﻿// <copyright file="IGetAllEntitiesLazy.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace NBaseRepository.EF.Base.LongPrimary
{
    using NBaseRepository.EF.Base.Common;
    using NBaseRepository.LongPrimary;

    /// <summary>
    /// An interface used to describe a class that can retrieve all entity of type <see cref="TEntity"/> lazily.
    /// </summary>
    /// <typeparam name="TEntity">The type of the entity.</typeparam>
    public interface IGetAllEntitiesLazy<TEntity> : IGetAllEntitiesLazy<TEntity, long>
        where TEntity : IEntity
    {
    }
}
