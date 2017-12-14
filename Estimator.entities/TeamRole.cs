using System;
using System.Collections.Generic;

namespace Estimator.entities
{
  public class TeamRole : EntityBase<Guid>
  {
    public string Name { get; set; }
    public double Rate { get; set; }
  }

  public class Estimate : EntityBase<Guid>
  {
    public string Title { get; set; }
    public string Client { get; set; }

    public virtual List<TeamRole> TeamRoles { get; set; }
    public virtual List<Iteration> Iterations { get; set; }
  }

  public class Iteration : EntityBase<Guid>
  {
    public string Label { get; set; }
    public int Hours { get; set; }
    public int TargetVelocity { get; set; }
    public int DisplayOrder { get; set; }

    public virtual List<TeamRole> IterationRoles { get; set; }
  }
}
