﻿using System;

namespace Scarlet.Entities
{
    public delegate void EntityCollectionEventHandler(object sender, EntityCollectionEventArgs e);
    public delegate void EntityCollectionEventHandler<T, TIdentifier>(object sender, EntityCollectionEventArgs<T, TIdentifier> e) where T : IEntity<TIdentifier>;

    public class EntityCollectionEventArgs : EventArgs
    {
        public EntityCollectionEventArgs(EntityCollectionOperation operation)
        {
            Operation = operation;
        }

        public EntityCollectionOperation Operation { get; }
    }

    public class EntityCollectionEventArgs<T, TIdentifier> : EntityCollectionEventArgs
        where T : IEntity<TIdentifier>
    {
        public EntityCollectionEventArgs(EntityCollectionOperation operation) : base(operation)
        {
        }

        public EntityCollectionEventArgs(EntityCollectionOperation operation, T data) : base(operation)
        {
            Data = data;
        }

        public T Data { get; }
    }
}