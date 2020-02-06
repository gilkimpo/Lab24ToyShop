using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using ToyShop.Models;

namespace ToyShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            ShopDBContext db = new ShopDBContext();
            List<Users> user = new List<Users>();
            List<Items> item = new List<Items>();
           //CoffeeShopContextDB= new CoffeeShopContext();
            //grab user items and add to a list
          //  var userItems= db.UserItems.ToList();

            //loop thru userItems to build list of Users and Items
            //foreach(var item in userItems)
            //{
                
            //}
            return View();
        }
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Register(string passwordtwo,
            string firstname,
            string lastname,
            string phonenumber, string email, string password)
        {
            if (password == passwordtwo)
            {
                return View();
            }
            else
            {
                return PasswordError();
            }

        }
        public IActionResult PasswordError()
        {
            return View("PasswordError");
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(string username, string password)
        {
            using (var db = new ShopDBContext())
            {
                var user = db.Users.FirstOrDefault(u => u.UserName == username);
                if (user != null)
                {
                    //check password if user is not null
                    if (password == user.PassWord)
                    {
                        HttpContext.Session.SetString("session_username", user.UserName);

                        //TODO: CHANGE TO APPROPRIATE VIEW TO GO TO 
                        return View("RegisterSuccess");  //RegisterSuccess returned here originally
                    }
                    else
                    {
                        ViewBag.ErrorMessage = "Password is incorrect";
                        return View();
                    }
                }
                else // user was Null, not found in database
                {
                    ViewBag.ErrorMessage = "User not Found";
                    return View();
                }
            }
        }
           [HttpPost]
        public IActionResult MakeNewUser(Users u)
        {
            using (var db = new ShopDBContext())
            {
                var newUser = new Users
                {
                    Email = u.Email,
                    FirstName = u.FirstName,
                    LastName = u.LastName,
                    UserName = u.UserName,
                    PassWord = u.PassWord,
                    Funds = 100
                };

                db.Users.Add(newUser);
                if (db.SaveChanges() > 0)
                {
                   
                    return View("RegisterSuccess");
                }
                else
                {
                    
                    ViewBag.ErrorMessage("Was not successful.");
                    return View("Register");
                }
            }
        }

        public IActionResult Shop()
        {
            var model = new List<Items>();
            using (var db=new ShopDBContext())
            {
                model = db.Items.ToList();
            }
            return View(model);
        }
        [HttpPost]
        public IActionResult Shop(int ItemID)
        {
            using (var db = new ShopDBContext())
            {
                var item = db.Items.FirstOrDefault(i => i.Id == ItemID);
                var username = HttpContext.Session.GetString("session_username");
                if (!string.IsNullOrEmpty(username))
                {
                    var user = db.Users.FirstOrDefault(u => u.UserName == username);
                    {
                        if (user != null)
                        {
                            if (item != null)
                            {
                                var itemPrice = item.Price;
                                var userMoney = user.Funds;

                                if (userMoney > item.Price)
                                {
                                    user.Funds = user.Funds - itemPrice;
                                    item.Quantity = item.Quantity - 1;
                                    db.SaveChanges();
                                    return RedirectToAction("Shop", "Home");
                                }
                                else
                                {
                                    ViewBag.ErrorMessage = "You don't have enough money.";
                                    return View("Error");
                                }
                            }
                            else
                            {
                                ViewBag.ErrorMessage = "That is not a valid item.";
                                return View("Error");
                            }
                        }
                        else
                        {
                            ViewBag.ErrorMessage = "Please log in again.";
                            return View("Error");
                        }
                    }
                }
            }
            return View("Error");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
