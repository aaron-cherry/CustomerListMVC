using CustomerListMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CustomerListMVC.Controllers
{
    public class HomeController : Controller
    {
        #region
        //All emails are fake
        public static List<CustomerModel> Customers = new List<CustomerModel>
        {
            new CustomerModel {LastName = "Plodder", FirstName = "Paul", Email = "PaulPlodder@student.swic.edu", State = "MO"},
            new CustomerModel {LastName = "Arfuss", FirstName = "George", Email = "GeorgeArfuss@student.swic.edu", State = "MO"},
            new CustomerModel {LastName = "Turtle", FirstName = "Tom", Email = "TomTurtle@student.swic.edu", State = "MO"},
            new CustomerModel {LastName = "Jones", FirstName = "William", Email = "WilliamJones@student.swic.edu", State = "MO"},
            new CustomerModel {LastName = "Jones", FirstName = "John", Email = "JohnJones@student.swic.edu", State = "MO"},
            new CustomerModel {LastName = "Jones", FirstName = "Anthony", Email = "AnthonyJones@student.swic.edu", State = "MO"},
            new CustomerModel {LastName = "Jones", FirstName = "Kyle", Email = "KyleJones@student.swic.edu", State = "MO"},
            new CustomerModel {LastName = "Berty", FirstName = "Kelley", Email = "KelleyBerty@student.swic.edu", State = "MO"},
            new CustomerModel {LastName = "MacElroy", FirstName = "George", Email = "GeorgeMacElroy@student.swic.edu", State = "IL"},
            new CustomerModel {LastName = "McDunnel", FirstName = "James", Email = "JamesMcDunnel@student.swic.edu", State = "MO"},
            new CustomerModel {LastName = "McDunnel", FirstName = "Thomas", Email = "ThomasMcDunnel@student.swic.edu", State = "MO"},
            new CustomerModel {LastName = "Smith", FirstName = "Thomas", Email = "ThomasSmith@student.swic.edu", State = "MO"},
            new CustomerModel {LastName = "Jukes", FirstName = "Martin", Email = "MartinJukes@student.swic.edu", State = "MO"},
            new CustomerModel {LastName = "Smith", FirstName = "August", Email = "AugustSmith@student.swic.edu", State = "MO"},
            new CustomerModel {LastName = "Arfuss", FirstName = "Richard", Email = "RichardArfuss@student.swic.edu", State = "IL"},
            new CustomerModel {LastName = "Arfuss", FirstName = "Sean", Email = "SeanArfuss@student.swic.edu", State = "MO"},
            new CustomerModel {LastName = "Mueller", FirstName = "Arthur", Email = "ArthurMueller@student.swic.edu", State = "MO"},
            new CustomerModel {LastName = "Miller", FirstName = "James", Email = "JamesMiller@student.swic.edu", State = "MO"},
            new CustomerModel {LastName = "Mueller", FirstName = "Daniel", Email = "DanielMueller@student.swic.edu", State = "MO"},
            new CustomerModel {LastName = "Milkwagin", FirstName = "Michael", Email = "MichaelMilkwagin@student.swic.edu", State = "MO"},
            new CustomerModel {LastName = "Neuner", FirstName = "Michael", Email = "MichaelNeuner@student.swic.edu", State = "MO"},
            new CustomerModel {LastName = "Ortega", FirstName = "Kenn", Email = "KennOrtega@student.swic.edu", State = "IL"},
            new CustomerModel {LastName = "Will", FirstName = "Phil", Email = "PhilWill@student.swic.edu", State = "MO"},
            new CustomerModel {LastName = "Sellum", FirstName = "Sally", Email = "SallySellum@student.swic.edu", State = "MO"},
            new CustomerModel {LastName = "Varfuss", FirstName = "Barney", Email = "BarneyVarfuss@student.swic.edu", State = "MO"},
            new CustomerModel {LastName = "Tummyfill", FirstName = "Joseph", Email = "JosephTummyfill@student.swic.edu", State = "Mo"},
            new CustomerModel {LastName = "Rockford", FirstName = "Steve", Email = "SteveRockford@student.swic.edu", State = "IL"},
            new CustomerModel {LastName = "Daly", FirstName = "Daniel", Email = "DanielDaly@student.swic.edu", State = "MO"},
            new CustomerModel {LastName = "Malt", FirstName = "Salvatore", Email = "SalvatoreMalt@student.swic.edu", State = "MO"},
            new CustomerModel {LastName = "Smith", FirstName = "Thomas", Email = "ThomasSmith@student.swic.edu", State = "MO"},
            new CustomerModel {LastName = "Smythe", FirstName = "Richard", Email = "RichardSmythe@student.swic.edu", State = "MO"},
            new CustomerModel {LastName = "Smiley", FirstName = "Thomas", Email = "ThomasSmiley@student.swic.edu", State = "IL"},
            new CustomerModel {LastName = "Rockford", FirstName = "George", Email = "GeorgeRockford@student.swic.edu", State = "MO"},
            new CustomerModel {LastName = "Fawlty", FirstName = "Jeffrey", Email = "JeffreyFawlty@student.swic.edu", State = "MO"},
            new CustomerModel {LastName = "Steadman", FirstName = "Daniel", Email = "DanielSteadman@student.swic.edu", State = "MO"},
            new CustomerModel {LastName = "Jones", FirstName = "Gregory", Email = "GregoryJones@student.swic.edu", State = "MO"},
            new CustomerModel {LastName = "Eliot", FirstName = "Gregory", Email = "GregoryEliot@student.swic.edu", State = "MO"},
            new CustomerModel {LastName = "Willow", FirstName = "Jeffrey", Email = "JeffreyWillow@student.swic.edu", State = "MO"},
            new CustomerModel {LastName = "Stiner", FirstName = "Robert", Email = "RobertStiner@student.swic.edu", State = "MO"},
            new CustomerModel {LastName = "Nessman", FirstName = "Lawrence", Email = "LawrenceNessman@student.swic.edu", State = "MO"},
            new CustomerModel {LastName = "Sulley", FirstName = "Robert", Email = "RobertSulley@student.swic.edu", State = "MO"},
            new CustomerModel {LastName = "Birdwall", FirstName = "Leonard", Email = "LeonardBirdwall@student.swic.edu", State = "MO"},
            new CustomerModel {LastName = "Kubick", FirstName = "Terry", Email = "TerryKubick@student.swic.edu", State = "IL"},
            new CustomerModel {LastName = "Webster", FirstName = "James", Email = "JamesWebster@student.swic.edu", State = "MO"},
            new CustomerModel {LastName = "Waffles", FirstName = "Arthur", Email = "ArthurWaffles@student.swic.edu", State = "MO"},
            new CustomerModel {LastName = "Varfuss", FirstName = "Merrell", Email = "MerrellVarfuss@student.swic.edu", State = "MO"},
            new CustomerModel {LastName = "Williams", FirstName = "James", Email = "JamesWilliams@student.swic.edu", State = "MO"},
            new CustomerModel {LastName = "Walleye", FirstName = "Robert", Email = "RobertWalleye@student.swic.edu", State = "MO"},
            new CustomerModel {LastName = "Feltz", FirstName = "Kenny", Email = "KennyFeltz@student.swic.edu", State = "MO"},
            new CustomerModel {LastName = "Varfuss", FirstName = "Andrew", Email = "AndrewVarfuss@student.swic.edu", State = "MO"},
            new CustomerModel {LastName = "Fitzgerald", FirstName = "Terry", Email = "TerryFitzgerald@student.swic.edu", State = "MO"},
            new CustomerModel {LastName = "Winer", FirstName = "Lawrence", Email = "LawrenceWiner@student.swic.edu", State = "MO"},
            new CustomerModel {LastName = "Maverick", FirstName = "Steve", Email = "SteveMaverick@student.swic.edu", State = "IL"},
            new CustomerModel {LastName = "Kong", FirstName = "Karl", Email = "KarlKong@student.swic.edu", State = "MO"},
            new CustomerModel {LastName = "Wiliams", FirstName = "Joseph", Email = "JosephWiliams@student.swic.edu", State = "MO"},
            new CustomerModel {LastName = "Billiard", FirstName = "Jules", Email = "JulesBilliard@student.swic.edu", State = "MO"},
            new CustomerModel {LastName = "Smith", FirstName = "Michael", Email = "MichaelSmith@student.swic.edu", State = "IL"},
            new CustomerModel {LastName = "Jones", FirstName = "Joseph", Email = "JosephJones@student.swic.edu", State = "MO"},
            new CustomerModel {LastName = "Caline", FirstName = "James", Email = "JamesCaline@student.swic.edu", State = "MO"},
            new CustomerModel {LastName = "Plodder", FirstName = "Kevin", Email = "KevinPlodder@student.swic.edu", State = "MO"},
            new CustomerModel {LastName = "Taylor", FirstName = "Kim", Email = "KimTaylor@student.swic.edu", State = "MO"},
        };
        #endregion
        public string? searchTerm;
        public IActionResult Index()
        {
            //Make list available to view
            ViewBag.Customers = Customers;
            return View("CustomerList");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CustomerList()
        {
            //Post method to filter data from user input
            string searchTerm = Request.Form["searchInput"];
            ViewBag.Customers = Customers;
            if (searchTerm != "")
            {
                ViewBag.Customers = Customers.Where(customer => customer.State == searchTerm.ToUpper());
            }
            return View();
        }
    }
}