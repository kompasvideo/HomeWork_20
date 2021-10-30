using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using HomeWork_20.Models;

namespace HomeWork_20.Controllers
{
    public class PhoneBookController : Controller
    {
        private IPhoneBookRepository repository;

        public PhoneBookController(IPhoneBookRepository repo)
        {
            repository = repo;
        }

        public IActionResult Index()
        {
            return View(repository.PhoneBooks);
        }
    }
}
