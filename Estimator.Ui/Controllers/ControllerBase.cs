using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Estimator.Ui.Controllers
{
  [Authorize]
  public abstract class ControllerBase : Controller { }
}
