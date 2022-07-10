﻿namespace NBaseRepository.GuidPrimary
{
    using Common;

    /// <summary>
    /// An interface that describe a class that represents a query object for type <see cref="IGuidEntity"/>.
    /// </summary>
    /// <typeparam name="TEntity">The type of the entity.</typeparam>
    public interface IGuidQuery<TEntity> : IQuery<TEntity>
        where TEntity : IGuidEntity
    {
    }
}
