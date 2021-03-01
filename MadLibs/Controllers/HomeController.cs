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
    
    [Route("/djform")]
    public ActionResult DJForm() {return View();}

    [Route("/djmadlib")]
    public ActionResult DJMadlib(string genre, string genreTwo, string food, string instrument, int number, string adjective, string onomatopeia, string noun)
    {
      DJVariable myDJVariable = new DJVariable();
      myDJVariable.Genre = genre;
      myDJVariable.GenreTwo = genreTwo;
      myDJVariable.Food = food;
      myDJVariable.Instrument = instrument;
      myDJVariable.Number = number;
      myDJVariable.Adjective = adjective;
      myDJVariable.Onomatopeia = onomatopeia;
      myDJVariable.Noun = noun;
      return View(myDJVariable);
    }
  }
}