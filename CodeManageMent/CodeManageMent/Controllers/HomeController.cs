using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using CodeManageMent.Models;
using CodeManageMent.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CodeManageMent.Controllers
{ 
   
    public class HomeController : Controller
    {
        private readonly IStudentRepository _studentRepository;

        public HomeController(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }
      
        public IActionResult Index()
        {
          
            return View(_studentRepository.GetStudentsAll());
        }
        
        public IActionResult Details(int? id)
        {

            HomoDetailViewModel homeDetaliViewModel = new HomoDetailViewModel()
            {
                Student = _studentRepository.GetStudent(id??1),
                PageTitle = "学生详细信息"
            };
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                      
            return View(homeDetaliViewModel);
           
        }

        /// <summary>
        /// 创建学生信息
        /// </summary>
        /// <returns></returns>
        public IActionResult Create() 
        {
            return View();
        }
        
    }
}
