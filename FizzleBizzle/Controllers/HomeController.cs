using FizzleBizzle.Models;
using System;
using System.Web.Mvc;

namespace FizzleBizzle.Controllers
{
    public class HomeController : Controller
    {
        [HttpPost]
        public ActionResult Index(IndexViewModel model)
        {
            model.FizzBuzzArray = new string[0];

            if (!ModelState.IsValid 
                || model.Fizz == 0 
                || model.Buzz == 0
                || (model.IsBazzActive && model.Bazz == null)
                || (model.IsBazzActive && model.Predicate == 0))
            {
                if (model.Fizz == 0)
                    ModelState.AddModelError("Fizz", "Fizz can't be 0!");
                if (model.Buzz == 0)
                    ModelState.AddModelError("Buzz", "Buzz can't be 0!");
                if (model.IsBazzActive && model.Bazz == null)
                    ModelState.AddModelError("Bazz", "Bazz can't be empty if you're using it!");
                if (model.IsBazzActive && model.Predicate == 0)
                    ModelState.AddModelError("Predicate", "Please choose a predicate.");
                return View(model);
            }
            
            var fizzleBizzle = new Models.FizzleBizzle(model.Fizz, model.Buzz);

            if (model.IsBazzActive)
            {
                var bazz = ReturnPredicate(model.Predicate, (int)model.Bazz);
                model.FizzBuzzArray = fizzleBizzle.FizzBuzzBazz(model.Start, model.End, bazz);
            }
            else
            {
                model.FizzBuzzArray = fizzleBizzle.FizzBuzz(model.Start, model.End);
            }
            
            return View(model);
        }

        [HttpGet]
        public ActionResult Index()
        {           
            return View();
        }

        private Predicate<int> ReturnPredicate(Predicate predicateEnum, int bazz)
        {
            Predicate<int> predicate = delegate (int a) { return false; };
            switch (predicateEnum)
            {
                case Predicate.EqualTo:
                    predicate = delegate (int a) { return a == bazz; };
                    break;
                case Predicate.GreaterThan:
                    predicate = delegate (int a) { return a > bazz; };
                    break;
                case Predicate.GreaterThanOrEqualTo:
                    predicate = delegate (int a) { return a >= bazz; };
                    break;
                case Predicate.LessThan:
                    predicate = delegate (int a) { return a < bazz; };
                    break;
                case Predicate.LessThanOrEqualTo:
                    predicate = delegate (int a) { return a <= bazz; };
                    break;
                case Predicate.NotEqualTo:
                    predicate = delegate (int a) { return a != bazz; };
                    break;             
            }

            return predicate;                               
        }
    }
}