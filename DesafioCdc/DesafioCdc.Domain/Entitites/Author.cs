namespace DesafioCdc.Domain.Entitites
{
    public class Author : Entity
    {
        public Author(string name, string email, string description)
        {
            Name = name;
            Email = email;
            Description = description;
            DateOn = DateTime.Now;
        }

        public Author(Guid id, string name, string email, string description, DateTime dateOn)
            : base(id)
        {
            Name = name;
            Email = email;
            Description = description;
            DateOn = dateOn;
        }

        public string Name { get; private set; }
        public string Email { get; private set; }
        public string Description { get; private set; }
        public DateTime DateOn { get; private set; }
    }
}
