namespace DesafioCdc.Domain.Entitites
{
    public class Entity
    {
        public Entity() => Id = Guid.NewGuid();
        public Entity(Guid id) => Id = id;

        public Guid Id { get; private set; }
    }
}
