namespace Scarlet.Entities
{
    public interface IEntity<TIdentifier>
    {
        TIdentifier Id { get; }
    }
}
