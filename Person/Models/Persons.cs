namespace Person.Models
{
    public class Persons
    {
        public Persons(string name)
        {
            Name = name;
            Active = true;
            Id = Guid.NewGuid();
        }

        public Guid Id { get; init; }
        public string Name { get; private set; }
        public bool Active { get; private set; }

        public void ChangeName(string name)
        {
            Name = name;
        }

        public void SetInactive()
        {
            Active = false;
        }

        public void SetActive()
        {
            Active = true;
        }
    }
}
