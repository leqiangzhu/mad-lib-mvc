using Microsoft.AspNetCore.Mvc;
using MabLibs.Models;

namespace MadLibForms.Controllers
{
    public class HomeController : Controller
    {
        [Route("/")]
        public ActionResult index()
       {
         return View();
       }

       [Route("/response")]
       public ActionResult response()
       {
         WordVar newWord = new WordVar();
         newWord.SetPerson1(Request.Query["person1"]);
         newWord.SetPerson2(Request.Query["person2"]);
         newWord.SetAnimal(Request.Query["animal"]);
         newWord.SetExclamation(Request.Query["exclamation"]);
         newWord.SetVerb(Request.Query["verb"]);
         newWord.SetFood(Request.Query["food"]);
         return View("response", newWord);
       }
    }
}
