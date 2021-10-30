using HomeWork_20.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace HomeWork_20.Controllers
{
    public class PhoneBookController : Controller
    {
        private IPhoneBookRepository repository;

        public PhoneBookController(IPhoneBookRepository repo)
        {
            repository = repo;
        }

        public ViewResult Index() => View(repository.PhoneBooks);
    }
}
