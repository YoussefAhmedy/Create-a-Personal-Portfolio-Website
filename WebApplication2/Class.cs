using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;

namespace WebApplication2
{

    using Microsoft.AspNetCore.Mvc;
    using System.Collections.Generic;

    public class HomeController : Controller
    {
        // Renders the homepage (Index view)
        public IActionResult Index()
        {
            return View();
        }

        // Renders the About page with sample data
        public IActionResult About()
        {
            var about = new About
            {
                Name = "Your Name",
                Bio = "This is a brief introduction about you.",
                ProfilePictureUrl = "/images/profile.jpg" // Ensure this file exists in wwwroot/images
            };
            return View(about);
        }

        // Renders the Projects page with a list of sample projects
        public IActionResult Projects()
        {
            var projects = new List<Project>
        {
            new Project
            {
                Title = "Project 1",
                Description = "Description for project 1",
                Link = "https://example.com/project1"
            },
            new Project
            {
                Title = "Project 2",
                Description = "Description for project 2",
                Link = "https://example.com/project2"
            }
        };
            return View(projects);
        }

        // Renders the Contact form
        public IActionResult Contact()
        {
            return View();
        }

        // Handles the Contact form submission
        [HttpPost]
        public IActionResult Contact(Contact contact)
        {
            if (ModelState.IsValid)
            {
                // Example: Log or process the contact form data here (e.g., save to database or send an email)
                ViewBag.Message = "Thank you for your message!";
            }
            else
            {
                // If validation fails, render the view with validation messages
                ViewBag.Message = "Please correct the errors in the form.";
            }
            return View(contact);
        }
    }


}
