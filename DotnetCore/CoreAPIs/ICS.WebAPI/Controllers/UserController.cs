using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ICS.WebAPI.Controllers
{
    [ApiController]

    [Route("[controller]")]
    public class UserController : Controller
    {
        [HttpGet("Users")]
        // GET: UserController
        public IActionResult Index()
        {
            UserInputModel userInputModel = new UserInputModel();
            userInputModel.Firstname = "TestUser First Name";
            userInputModel.Lastname = "TestUser Last Name";
            List<UserInputModel> users = new List<UserInputModel>();
            users.Add(userInputModel);
            return Ok(users);
        }
        [HttpGet("Details")]
        // GET: UserController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        [HttpPost("Create")]
        // GET: UserController/Create
        public ActionResult Create()
        {
            return View();
        }

        //// POST: UserController/Create
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create(IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: UserController/Edit/5
        //public ActionResult Edit(int id)
        //{
        //    return View();
        //}

        //// POST: UserController/Edit/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: UserController/Delete/5
        //public ActionResult Delete(int id)
        //{
        //    return View();
        //}

        //// POST: UserController/Delete/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Delete(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
    }
}
