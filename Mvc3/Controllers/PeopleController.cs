using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Mvc3.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Mvc3.Controllers
{
    public class PeopleController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            var temp = DataManager.GetAllPeople();
            return View(temp);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Person person)
        {
            if (!ModelState.IsValid)
                return View(person);

            //add person
            DataManager.AddPerson(person);
            return RedirectToAction(nameof(Index));

        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var temp = DataManager.GetOnePerson(id);
            return View(temp);
        }

        [HttpPost]
        public IActionResult Edit(Person person, int id)
        {
            if (!ModelState.IsValid)
                return View(person);

            //update person (person, id)
            DataManager.UpdatePerson(person, id);

            return RedirectToAction(nameof(Index));
        }

    }
}
