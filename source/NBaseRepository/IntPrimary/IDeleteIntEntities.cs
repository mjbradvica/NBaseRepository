﻿namespace NBaseRepository.IntPrimary
{
    using Common;

    /// <summary>
    /// An interface used to describe a class that can delete multiple entities of type <see cref="TEntity"/>.
    /// </summary>
    /// <typeparam name="TEntity">The type of the entity.</typeparam>
    public interface IDeleteIntEntities<in TEntity> : IDeleteEntities<TEntity, int>
        where TEntity : IIntEntity
    {
    }
}