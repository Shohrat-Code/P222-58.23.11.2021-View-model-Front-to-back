using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using ViewModel.Models;
using ViewModel.ViewModels;

namespace ViewModel.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //ViewBag
            //ViewData
            //TempData
            //ViewModel

            #region Student list
            Student student1 = new Student()
            {
                Id = 1,
                Name = "Rasim",
                Surname = "Quliyev",
                Age = 25,
                Email = "rasim@gmail.com",
                Phone = "6516316"
            };
            Student student2 = new Student()
            {
                Id = 2,
                Name = "Qasim",
                Surname = "Abbasov",
                Age = 25,
                Email = "qasim@gmail.com",
                Phone = "345316"
            };
            Student student3 = new Student()
            {
                Id = 3,
                Name = "Toofiq",
                Surname = "Quliyev",
                Age = 25,
                Email = "toofiq@gmail.com",
                Phone = "3567547"
            };

            List<Student> students = new List<Student>();
            students.Add(student1);
            students.Add(student2);
            students.Add(student3);
            #endregion

            #region Group list
            Group group1 = new Group() { Id = 1, Name = "P222", Room = "Titan", StudentCount = 9 };
            Group group2 = new Group() { Id = 2, Name = "P319", Room = "Titan", StudentCount = 15 };
            Group group3 = new Group() { Id = 3, Name = "P114", Room = "Yupiter", StudentCount = 16 };

            List<Group> groups = new List<Group>();
            groups.Add(group1);
            groups.Add(group2);
            groups.Add(group3);
            #endregion

            VmAcademy model = new VmAcademy();
            model.Students = students;
            model.Groups = groups;

            return View(model);
        }
    }
}
