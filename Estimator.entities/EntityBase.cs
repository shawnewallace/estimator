using System;

namespace Estimator.entities
{
  public abstract class ApplicationEntity : EntityBase<Guid>
  {
    public ApplicationEntity() : base()
    {
      Id = Guid.NewGuid();
    }
  }

  public abstract class EntityBase<TKey>
  {
    public TKey Id { get; set; }

    public DateTime WhenCreated { get; set; } = DateTime.UtcNow;

    public DateTime WhenLastModified { get; set; }
  }
}
