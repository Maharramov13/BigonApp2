using BigonApp2.Models.Entities.Common;

namespace BigonApp2.Models.Entities
{
    public abstract class BaseEntity<TKey>:AudiTableEntity
        where TKey : struct
    {
        public int Id { get; set; }
    }
}
