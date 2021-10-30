using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HomeWork_20.Models;

namespace HomeWork_20.Controllers
{
    public class RecordController : Controller
    {
        private IPhoneBookRepository repository;
        public RecordController(IPhoneBookRepository repo)
        {
            repository = repo;
        }
        public ViewResult Index(PhoneBook phoneBook)
        {
           return View(phoneBook);
        }

        public RedirectToActionResult ViewRecord(int id)
        {
            PhoneBook phoneBook = repository.PhoneBooks
                .FirstOrDefault(p => p.Id == id);
            return RedirectToAction("Index", phoneBook);
        }
    }
}
