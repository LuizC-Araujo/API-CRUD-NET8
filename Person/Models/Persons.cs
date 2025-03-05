namespace Person.Models
{
    public class Persons
    {
        public Persons(string name)
        {
            Name = name;
            Id = Guid.NewGuid();
        }

        public Guid Id { get; init; }
        public string Name { get; private set; }
    }
}
