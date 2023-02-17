using Microsoft.AspNetCore.Mvc;

using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Project_Helpdesk_Portal.Models;
using System.Data.SqlClient;

namespace Project_Helpdesk_Portal.Controllers
{

    public class AccessController : Controller
    {
        public IActionResult Login()
        {
            ClaimsPrincipal claimUser = HttpContext.User;

            if (claimUser.Identity.IsAuthenticated)
                return RedirectToAction("Index", "Tickets");


            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Login(User modelLogin)
        {

            string connString = "Server=(localdb)\\mssqllocaldb;Database=HelpdeskDb;Trusted_Connection=True;TrustServerCertificate=True;";
            string query = "SELECT COUNT(*) From (SELECT * FROM Users WHERE Email = @Email AND Password = @Password Union All SELECT * FROM Users WHERE Email = @Email AND Password = @Password And IsAdmin = 1)AS combined_results ";

            using (SqlConnection conn = new SqlConnection(connString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@Email", modelLogin.Email);
                cmd.Parameters.AddWithValue("@Password", modelLogin.Password);

                conn.Open();
                int count = (int)cmd.ExecuteScalar();

                if (count == 1)
                {
                    List<Claim> claims = new List<Claim>() {
                    new Claim(ClaimTypes.NameIdentifier, modelLogin.Email),
                    new Claim("OtherProperties","Example Role")

                };

                    ClaimsIdentity claimsIdentity = new ClaimsIdentity(claims,
                        CookieAuthenticationDefaults.AuthenticationScheme);

                    AuthenticationProperties properties = new AuthenticationProperties()
                    {

                        AllowRefresh = true,
                        IsPersistent = modelLogin.IsAdmin && modelLogin.IsHelpdeskStaff
                    };

                    await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme,
                        new ClaimsPrincipal(claimsIdentity), properties);

                    

                    return RedirectToAction("CreateTicketsUsers", "Tickets");
                }
                if (count == 2)
                {
                    List<Claim> claims = new List<Claim>() {
                    new Claim(ClaimTypes.NameIdentifier, modelLogin.Email),
                    new Claim("OtherProperties","Example Role")

                };

                    ClaimsIdentity claimsIdentity = new ClaimsIdentity(claims,
                        CookieAuthenticationDefaults.AuthenticationScheme);

                    AuthenticationProperties properties = new AuthenticationProperties()
                    {

                        AllowRefresh = true,
                        IsPersistent = modelLogin.IsAdmin && modelLogin.IsHelpdeskStaff
                    };

                    await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme,
                        new ClaimsPrincipal(claimsIdentity), properties);



                    return RedirectToAction("Index", "Tickets");
                }










                ViewData["ValidateMessage"] = "Hasło lub adres E-mail są niaprawidłowe";
                return View();
            }
        }
    }
}
