using Microsoft.AspNetCore.Mvc;
using MadLibs.Models;

namespace MadLibs.Controllers
{
  public class HomeController : Controller
  {
    [Route("/")]
    public ActionResult HomePage() {return View();}

    [Route("/computerform")]
    public ActionResult ComputerForm() {return View();}

    [Route("/computermadlib")]
      public ActionResult ComputerMadLib(string noun, string pluralNoun, string presentTenseVerb, string presentTenseVerbTwo, string partOfBody, string adjective, string pluralNounTwo, string adjectiveTwo)
      {
        ComputerVariable myComputerVariable = new ComputerVariable();
        myComputerVariable.Noun = noun;
        myComputerVariable.PluralNoun = pluralNoun;
        myComputerVariable.PresentTenseVerb = presentTenseVerb;
        myComputerVariable.PresentTenseVerbTwo = presentTenseVerbTwo;
        myComputerVariable.PartOfBody = partOfBody;
        myComputerVariable.Adjective = adjective;
        myComputerVariable.PluralNounTwo = pluralNounTwo;
        myComputerVariable.AdjectiveTwo = adjectiveTwo;
        return View(myComputerVariable);
      }
  }
}