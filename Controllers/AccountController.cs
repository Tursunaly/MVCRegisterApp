using Microsoft.AspNetCore.Mvc;
using MvcRegisterApp.Models;
using MvcRegisterApp.Data;

namespace MvcRegisterApp.Controllers
{
    public class AccountController : Controller
    {
        private readonly AppDbContext _context;

        public AccountController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
    // В методе Register
[HttpPost]
public IActionResult Register(User user)
{
    if (ModelState.IsValid)
    {
        // Все эти свойства должны использоваться
        var newUser = new User {
            Username = user.Username,
            Email = user.Email,
            Password = user.Password // В реальном проекте пароль нужно хэшировать!
        };
        _context.Users.Add(newUser);
        _context.SaveChanges();
        return RedirectToAction("Login");
    }
    return View(user);
}

        // 👉 Вот сюда вставляй
        public IActionResult Users()
        {
            var users = _context.Users.ToList();
            return View(users);
        }
    }
}



