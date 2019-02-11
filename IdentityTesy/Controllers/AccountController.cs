using IdentityTest.BLL.DTO;
using IdentityTest.BLL.Infrastructure;
using IdentityTest.BLL.Interfaces;
using IdentityTesy.Models;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;
using System.Net.Mail;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using IdentityTest.DAL.Entities;

namespace IdentityTesy.Controllers
{
    public class AccountController : Controller
    {
        private bool ConfirmedEmail { get; set; }
        private IUserService UserService
        {
            get
            {
                return HttpContext.GetOwinContext().GetUserManager<IUserService>();
            }
        }

        private IAuthenticationManager AuthenticationManager
        {
            get
            {
                return HttpContext.GetOwinContext().Authentication;
            }
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Login(LoginModel model)
        {
            await SetInitialDataAsync();
            if (ModelState.IsValid)
            {
                UserDTO userDto = new UserDTO { Email = model.Email, Password = model.Password };
                ClaimsIdentity claim = await UserService.Authenticate(userDto);
                if (claim == null)
                {
                    ModelState.AddModelError("", "Неверный логин или пароль.");
                }
                else
                {
                    AuthenticationManager.SignOut();
                    AuthenticationManager.SignIn(new AuthenticationProperties
                    {
                        IsPersistent = true
                    }, claim);
                    return RedirectToAction("Index", "Home");
                }
            }
            return View(model);
        }

        public ActionResult Logout()
        {
            AuthenticationManager.SignOut();
            return RedirectToAction("Index", "Home");
        }

        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Register(RegisterModel model)
        {
            await SetInitialDataAsync();
            if (ModelState.IsValid)
            {
                UserDTO userDto = new UserDTO
                {
                    Email = model.Email,
                    Password = model.Password,
                    Address = model.Address,
                    Name = model.Name,
                    UserName = model.Name,
                    Role = "user"
                };
                OperationDetails operationDetails = await UserService.Create(userDto);
                if (operationDetails.Succedeed)
                {

                    // наш email с заголовком письма
                    MailAddress from = new MailAddress("alexander.lysenko2@gmail.com", "Web Registration");
                    // кому отправляем
                    MailAddress to = new MailAddress(userDto.Email);
                    // создаем объект сообщения
                    MailMessage m = new MailMessage(from, to);
                    // тема письма
                    m.Subject = "Email confirmation";
                    // текст письма - включаем в него ссылку
                    m.Body = string.Format("Для завершения регистрации перейдите по ссылке:" +
                                    "<a href=\"{0}\" title=\"Подтвердить регистрацию\">{0}</a>",
                        Url.Action("ConfirmEmail", "Account", new { Token = userDto.Id, Email = userDto.Email }, Request.Url.Scheme));
                    m.IsBodyHtml = true;

                    // адрес smtp-сервера, с которого мы и будем отправлять письмо
                    SmtpClient smtp = new System.Net.Mail.SmtpClient("smtp.gmail.com", 587);
                    // логин и пароль
                    smtp.Credentials = new System.Net.NetworkCredential("alexander.lysenko2@gmail.com", "47891017a  ");
                    smtp.EnableSsl = true;
                    smtp.Send(m);

                    return View("DisplayEmail");
                }
                else
                    ModelState.AddModelError(operationDetails.Property, operationDetails.Message);
            }

            return View(model);
        }

        private async Task SetInitialDataAsync()
        {
            await UserService.SetInitialData(new UserDTO
            {
                Email = "somemail@mail.ru",
                UserName = "somemail@mail.ru",
                Password = "ad46D_ewr3",
                Name = "Random Random Randomovith",
                Address = "ул. Спортивная, д.30, кв.75",
                Role = "admin",
            }, new List<string> { "user", "admin" });
        }
    }
}