using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeWork_20.Models
{
    public interface IPhoneBookRepository
    {
        IQueryable<PhoneBook> PhoneBooks { get; }
    }
}
