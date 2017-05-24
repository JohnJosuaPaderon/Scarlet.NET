using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Scarlet.Entities
{
    public class EntityCollection<T, TIdentifier> : ICollection<T>
        where T : IEntity<TIdentifier>
    {
        public EntityCollection()
        {
            Source = new Dictionary<TIdentifier, T>();
        }

        public EntityCollection(IEnumerable<T> initialContent)
        {
            Source = initialContent.ToDictionary(e => e.Id);
        }

        protected Dictionary<TIdentifier, T> Source { get; }

        public event EntityCollectionEventHandler<T, TIdentifier> Added;
        public event EntityCollectionEventHandler<T, TIdentifier> Removed;
        public event EntityCollectionEventHandler<T, TIdentifier> Updated;
        public event EntityCollectionEventHandler Cleared;

        public int Count => Source.Count;

        public bool IsReadOnly => false;

        public T this[TIdentifier id]
        {
            get
            {
                if (Source.ContainsKey(id))
                {
                    return Source[id];
                }
                else
                {
                    return default(T);
                }
            }
            set
            {
                if (!Equals(default(T), value))
                {
                    if (Source.ContainsKey(value.Id))
                    {
                        UnsafeUpdate(value);
                    }
                    else
                    {
                        UnsafeAdd(value);
                    }
                }
            }
        }

        public virtual void Add(T item)
        {
            if (!Equals(default(T), item) && !Source.ContainsKey(item.Id))
            {
                Source.Add(item.Id, item);
            }
        }

        public void Clear()
        {
            if (Source.Any())
            {
                Source.Clear();
                OnCleared();
            }
        }

        public bool Contains(T item)
        {
            if (!Equals(default(T), item))
            {
                return Source.ContainsKey(item.Id);
            }
            else
            {
                return false;
            }
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            Source.Values.CopyTo(array, arrayIndex);
        }

        public IEnumerator<T> GetEnumerator()
        {
            return Source.Values.GetEnumerator();
        }

        protected virtual void OnAdded(T data)
        {
            Added?.Invoke(this, new EntityCollectionEventArgs<T, TIdentifier>(EntityCollectionOperation.Add, data));
        }

        protected virtual void OnCleared()
        {
            Cleared?.Invoke(this, new EntityCollectionEventArgs(EntityCollectionOperation.Clear));
        }

        protected virtual void OnRemoved(T data)
        {
            Removed?.Invoke(this, new EntityCollectionEventArgs<T, TIdentifier>(EntityCollectionOperation.Remove, data));
        }

        protected virtual void OnUpdated(T data)
        {
            Updated?.Invoke(this, new EntityCollectionEventArgs<T, TIdentifier>(EntityCollectionOperation.Update, data));
        }

        public virtual bool Remove(T item)
        {
            if (!Equals(default(T), item) && Source.ContainsKey(item.Id))
            {
                return UnsafeRemove(item);
            }
            else
            {
                return false;
            }
        }

        public virtual void Update(T item)
        {
            if (!Equals(default(T), item) && Source.ContainsKey(item.Id))
            {
                UnsafeUpdate(item);
            }
        }

        protected void UnsafeAdd(T item)
        {
            Source.Add(item.Id, item);
            OnAdded(item);
        }

        protected bool UnsafeRemove(T item)
        {
            if (Source.Remove(item.Id))
            {
                OnRemoved(item);
                return true;
            }
            else
            {
                return false;
            }
        }

        protected void UnsafeUpdate(T item)
        {
            Source[item.Id] = item;
            OnUpdated(item);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
