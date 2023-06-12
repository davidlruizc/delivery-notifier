namespace Utilities.Domain
{
    public abstract class BaseEntity
    {
        public Guid Id { get; set; }
        public DateTime Created { get; set; }

        public void InitializeBase()
        {
            Id = Guid.NewGuid();
            Created = DateTime.Now.ToUniversalTime();
        }
    }
}
