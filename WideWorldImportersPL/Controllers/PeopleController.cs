using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WideWorldImporters.BLL.Services;

namespace WideWorldImporters.Controllers
{
    [Route("/people")]
    public class PeopleController : Controller
    {
        private readonly IPeopleService _people;

        public PeopleController(IPeopleService people)
        {
            _people = people;
        }

        [Route("search")]
        public IActionResult Search()
        {
            return View();
        }

        [Route("edit/{id}")]
        public IActionResult Edit(int id)
        {
            return View();
        }
    }
}