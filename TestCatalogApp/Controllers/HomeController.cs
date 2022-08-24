using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using TestCatalogApp.Interfaces;
using TestCatalogApp.Models;
using TestCatalogApp.Services;

namespace TestCatalogApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly IFolderServices _folderServices;
        public HomeController(ILogger<HomeController> logger, IFolderServices fs)
        {
            _logger = logger;
            _folderServices = fs;
        }

        public IActionResult GetAllFolder()
        {
            return View(_folderServices.GetAllFolders());
        }
        public IActionResult FolderForId(int id)
        {
            return View(_folderServices.GetFolder(id));
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
