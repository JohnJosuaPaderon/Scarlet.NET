namespace Scarlet.Entities
{
    public abstract class Entity<TIdentifier> : IEntity<TIdentifier>
    {
        public TIdentifier Id { get; }
        
        public static bool operator ==(Entity<TIdentifier> left, Entity<TIdentifier> right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Entity<TIdentifier> left, Entity<TIdentifier> right)
        {
            return !(left == right);
        }

        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (GetType() != obj.GetType()) return false;

            var entity = obj as Entity<TIdentifier>;
            return Id.Equals(entity.Id);
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
    }
}
