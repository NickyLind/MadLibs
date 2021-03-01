using Microsoft.AspNetCore.Mvc;
using MadLibs.Models;

namespace MadLibs.Controllers
{
  public class HomeController : Controller
  {
    [Route("/")]
    public ActionResult Form() {return View();}

    [Route("/madlib")]
      public ActionResult MadLib(string noun, string pluralNoun, string presentTenseVerb, string presentTenseVerbTwo, string partOfBody, string adjective, string pluralNounTwo, string adjectiveTwo)
      {
        MadLibsVariable myMadLibsVariable = new MadLibsVariable();
        myMadLibsVariable.Noun = noun;
        myMadLibsVariable.PluralNoun = pluralNoun;
        myMadLibsVariable.PresentTenseVerb = presentTenseVerb;
        myMadLibsVariable.PresentTenseVerbTwo = presentTenseVerbTwo;
        myMadLibsVariable.PartOfBody = partOfBody;
        myMadLibsVariable.Adjective = adjective;
        myMadLibsVariable.PluralNounTwo = pluralNounTwo;
        myMadLibsVariable.AdjectiveTwo = adjectiveTwo;
        return View(myMadLibsVariable);
      }
  }
}