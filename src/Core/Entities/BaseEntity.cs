namespace SteelDonkey.Core.Entities
{
    public class BaseEntity<T> where T : struct
    {
        public T Id { get; protected set; }
        public int CreatedById { get; protected set; }
        public DateTime CreatedAt { get; protected set; }
        public int? UpdatedById { get; protected set; }
        public DateTime? UpdatedAt { get; protected set; }
        public int? DeletedById { get; protected set; }
        public DateTime? DeletedAt { get; protected set; }
    }
}
