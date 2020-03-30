using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace password_algos_mvc.Controllers
{
    [Route("")] // Make an action or controller default..
    [Route("[controller]")] // The route contains the controller name.
    public class PasswordController : Controller // Extends Controller
    {
       // CategoryService categoryService = new CategoryService();
        
        [Route("[action]")]
        public IActionResult Simple()
        {
            // Passing data to the view.
            return View("Views/Password/Generate.cshtml");
        }
        [Route("[action]")]
        public IActionResult Ascii()
        {
            // Passing data to the view.
            return View("Views/Password/Generate.cshtml");
        }
        [Route("[action]")]
        public IActionResult Shift()
        {
            // Passing data to the view.
            return View("Views/Password/Generate.cshtml");
        }

        // [HttpPost]
        // [ValidateAntiForgeryToken]
        // [Route("[action")]
        // public IActionResult GeneratePassword(PasswordViewModel password)
        // {
        //     string generated = app.run(password, algo);

        // }

}}