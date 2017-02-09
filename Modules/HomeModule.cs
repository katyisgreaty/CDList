using Nancy;
using Todo.Objects;
using System.Collections.Generic;

namespace CDList
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        return View["index.cshtml"];
      };
      
    }
  }
}
