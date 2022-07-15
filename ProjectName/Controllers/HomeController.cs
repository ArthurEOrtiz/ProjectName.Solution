using Microsoft.AspNetCore.Mvc;
using ProjectName.Models;

namespace ProjectName.Controllers
{
  public class HomeController : Controller
  {
    [Route("/test")]
    public string Test() { return "Test 1, go for launch!"; }

    [Route("/")]
    public ActionResult Index() 
    { 
      TestVariable myTestThreeVariable = new TestVariable();
      myTestThreeVariable.TestThree = "Test 3, go for launch!";
      return View(myTestThreeVariable);

    }
  }
}