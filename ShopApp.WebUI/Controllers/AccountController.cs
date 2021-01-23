using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ShopApp.Business.Abstract;
using ShopApp.WebUI.EmailServices;
using ShopApp.WebUI.Extensions;
using ShopApp.WebUI.Models;
using ShopApp.WebUI.Models.Identity;

namespace ShopApp.WebUI.Controllers
{
    [AutoValidateAntiforgeryToken]
    public class AccountController : Controller
    {
        private UserManager<ApplicationUser> _userManager;
        private SignInManager<ApplicationUser> _signInManager;
        private IEmailSender _emailSender;
        ICartService _cartService;
        public AccountController(ICartService cartService,UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, IEmailSender emailsender)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _emailSender = emailsender;
            _cartService = cartService;
        }
        public IActionResult Register()
        {
            return View(new RegisterModel());
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var user = new ApplicationUser
            {
                UserName = model.Username,
                Email = model.Email,
                FullName = model.FullName
            };

            var result = await _userManager.CreateAsync(user, model.Password);

            if (result.Succeeded)
            {
 
                // send email
                await _emailSender.SendEmailAsync(model.Email, "Welcome", $"Your account is confirm! \n\n thanks,");

                //Create Cart
                _cartService.InitializeCart(user.Id);
                TempData.Put("message", new ResultMessage()
                {
                    Title = "Account Confirmation",
                    Message = "Your account has been Created",
                    Css = "success"
                });
                return RedirectToAction("Login", "Account");
            }


            ModelState.AddModelError("", "Unknown error occurred, please try again");
            return View(model);
        }


        public IActionResult Login(string ReturnUrl = null)
        {
            return View(new LoginModel()
            {
                ReturnUrl = ReturnUrl
            });
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            var user = await _userManager.FindByEmailAsync(model.Email);

            if (user == null)
            {
                ModelState.AddModelError("", "an account has not been created with this email before.");
                return View(model);
            }


            var result = await _signInManager.PasswordSignInAsync(user, model.Password, true, false);

            if (result.Succeeded)
            {
                return Redirect(model.ReturnUrl ?? "~/");
            }

            ModelState.AddModelError("", "Email or password is incorrect");
            return View(model);
        }

        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            TempData.Put("message", new ResultMessage()
            {
                Title = "Sign Out",
                Message = "Sign Out Successfully.",
                Css = "warning"
            });
            return Redirect("~/");
        }

        public IActionResult ForgotPassword()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> ForgotPassword(string Email)
        {
            if (string.IsNullOrEmpty(Email))
            {
                TempData.Put("message", new ResultMessage()
                {
                    Title = "Forgot Password",
                    Message = "Your mail is incorrect",
                    Css = "danger"
                });
                return View();
            }

            var user = await _userManager.FindByEmailAsync(Email);

            if (user == null)
            {
                TempData.Put("message", new ResultMessage()
                {
                    Title = "Forgot Password",
                    Message = "Could not find users by email address",
                    Css = "danger"
                });
                return View();
            }

            var code = await _userManager.GeneratePasswordResetTokenAsync(user);

            var callbackUrl = Url.Action("ResetPassword", "Account", new
            {
                userId = user.Id,
                token = code
            });

            // send email
            await _emailSender.SendEmailAsync(Email, "Reset Password", $"Click on this <a href='http://localhost:49884{callbackUrl}'>link</a>");
            EmailModel model = new EmailModel()
            {
                email = Email
            };
            return RedirectToAction("ResetPassword", "Account",model);
        }


        public IActionResult ResetPassword(EmailModel model)
        {
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> ResetPassword(EmailModel model,int? a)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var user = await _userManager.FindByEmailAsync(model.email);
            if (user == null)
            {
                return RedirectToAction("Home", "Index");
            }
            var Token = await _userManager.GeneratePasswordResetTokenAsync(user);
            var result = await _userManager.ResetPasswordAsync(user,Token, model.Password);

            if (result.Succeeded)
            {
                return RedirectToAction("Login", "Account");
            }
            return View(model);
        }
        public IActionResult Accessdenied()
        {
            return View();
        }

    }
}