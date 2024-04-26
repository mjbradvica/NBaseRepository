﻿// <copyright file="RapidLaunchPublisherRepository.cs" company="Simplex Software LLC">
// Copyright (c) Simplex Software LLC. All rights reserved.
// </copyright>

using System;
using System.Data.SqlClient;
using ClearDomain.LongPrimary;
using RapidLaunch.ADO.Common;
using RapidLaunch.Common;

namespace RapidLaunch.ADO.LongPrimary
{
    /// <inheritdoc />
    public abstract class RapidLaunchPublisherRepository<TEntity> : RapidLaunchPublisherRepository<TEntity, long>
        where TEntity : class, IAggregateRoot
    {
        /// <inheritdoc />
        protected RapidLaunchPublisherRepository(SqlConnection sqlConnection, SqlBuilder<TEntity, long> sqlBuilder, IPublishingBus publishingBus, Func<SqlDataReader, TEntity> conversionFunc)
            : base(sqlConnection, sqlBuilder, publishingBus, conversionFunc)
        {
        }
    }
}
