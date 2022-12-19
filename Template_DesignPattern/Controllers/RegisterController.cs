using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Template_DesignPattern.DAL.Entities;
using Template_DesignPattern.Models;

namespace Template_DesignPattern.Controllers
{
    public class RegisterController : Controller
    {

        private readonly UserManager<AppUser> _userManager;

        public RegisterController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(UserRegisterViewModel p)
        {
            AppUser appUser = new AppUser()
            {
                Name = p.Name,
                Surname = p.Surname,
                Email = p.Mail,
                UserName = p.Username
            };
            var result = await _userManager.CreateAsync(appUser, p.Password);
            if (result.Succeeded)
            {
                return RedirectToAction("Index", "Login");
            }
            else
            {
                return View();
            }
        }
    }
}
