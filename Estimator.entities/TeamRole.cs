using System;
using System.Collections.Generic;

namespace Estimator.entities
{
  public class TeamRole : ApplicationEntity
  {
    public string Name { get; set; }
    public double Rate { get; set; }
    public bool IsCore { get; set; } = false;
  }

  public class Estimate : ApplicationEntity
  {
    public string Title { get; set; }
    public string Client { get; set; }

    public DateTime ProjectStart { get; set; }
    public int LengthInDays { get; set; }

    public virtual List<FixedCost> FixedCosts { get; set; }

    public virtual List<TeamRole> TeamRoles { get; set; }
    public virtual List<Iteration> Iterations { get; set; }
  }

  public class FixedCost : ApplicationEntity
  {
    public string Purpose { get; set; }
    public double Value { get; set; }
  }

  public class Iteration : ApplicationEntity
  {
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }

    public string Label { get; set; }
    public int Hours { get; set; }
    public int TargetVelocity { get; set; }
    public int DisplayOrder { get; set; }

    public virtual List<TeamRole> IterationRoles { get; set; }
  }
} 