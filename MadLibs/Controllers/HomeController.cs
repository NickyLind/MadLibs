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

    [Route("/schoolform")]
    public ActionResult SchoolForm() {return View();}

    [Route("/schoolmadlib")]
    public ActionResult SchoolMadLib(int number, string noun, string verb, string adjective, string firstName, string exclamation, string adjectiveTwo, string typeOfContainer, string letterOfAlphabet, string personInRoom, string verbTwo, string articleOfClothing, string sillyWord, string adjectiveThree, string verbThree, string partOfBody, string vehicle, string animal)
    {
      SchoolVariable mySchoolVariable = new SchoolVariable();
      mySchoolVariable.Number = number;
      mySchoolVariable.Noun = noun;
      mySchoolVariable.Verb = verb;
      mySchoolVariable.Adjective = adjective;
      mySchoolVariable.FirstName = firstName;
      mySchoolVariable.Exclamation = exclamation;
      mySchoolVariable.AdjectiveTwo = adjectiveTwo;
      mySchoolVariable.TypeOfContainer = typeOfContainer;
      mySchoolVariable.LetterOfAlphabet = letterOfAlphabet;
      mySchoolVariable.PersonInRoom = personInRoom;
      mySchoolVariable.VerbTwo= verbTwo;
      mySchoolVariable.ArticleOfClothing = articleOfClothing;
      mySchoolVariable.SillyWord = sillyWord;
      mySchoolVariable.AdjectiveThree = adjectiveThree;
      mySchoolVariable.VerbThree = verbThree;
      mySchoolVariable.PartOfBody = partOfBody;
      mySchoolVariable.Vehicle = vehicle;
      mySchoolVariable.Animal = animal;
      return View(mySchoolVariable);
    }
  }
}