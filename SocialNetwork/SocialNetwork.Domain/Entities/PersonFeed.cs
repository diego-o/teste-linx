namespace SocialNetwork.Domain.Entities
{
    public class PersonFeed
    {
        public int Id { get; private set; }
        public int IdPerson { get; private set; }
        public string Message { get; private set; }

        public Person Person { get; private set; }

        public PersonFeed() { }
    }
}
