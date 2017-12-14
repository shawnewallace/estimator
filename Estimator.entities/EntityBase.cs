using System;

namespace Estimator.entities
{
  public abstract class EntityBase<TKey>
  {
    public TKey Id { get; set; }

    public DateTime WhenCreated { get; set; } = DateTime.UtcNow;

    public DateTime WhenLastModified { get; set; }
  }
}
