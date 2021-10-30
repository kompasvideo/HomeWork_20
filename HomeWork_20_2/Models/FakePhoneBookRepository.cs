using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeWork_20.Models
{
    public class FakePhoneBookRepository : IPhoneBookRepository
    {
        public IQueryable<PhoneBook> PhoneBooks => new List<PhoneBook>
        {
            new PhoneBook
            {
                Id = 1,
                LastName = "Петров",
                FirstName = "Алексей",
                ThreeName = "Алексеевич",
                NumberPhone = "8-927-45-12-34",
                Address = "ул. Забелина 3с1 - 15",
                Description = "Директор"
            },
            new PhoneBook
            {
                Id = 2,
                LastName = "Иванов",
                FirstName = "Сергей",
                ThreeName = "Сергеевич",
                NumberPhone = "8-917-456-78-45",
                Address = "Колпачный пер. 6с4 - 21",
                Description = "Заместитель директора"
            },
            new PhoneBook
            {
                Id = 3,
                LastName = "Крылов",
                FirstName = "Никита",
                ThreeName = "Никитович",
                NumberPhone = "8-903-456-96-32",
                Address = "ул. Покровка 7/9-11к1 - 23",
                Description = "Начальник отдела"
            },
            new PhoneBook
            {
                Id = 4,
                LastName = "Юдина",
                FirstName = "Татьяна",
                ThreeName = "Ивановна",
                NumberPhone = "8-962-123-45-67",
                Address = "Покровский бульвар 4/17с1 - 54",
                Description = "Секретарь"
            }
        }.AsQueryable<PhoneBook>();
    }
}
