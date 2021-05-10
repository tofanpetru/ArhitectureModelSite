using Application.Interfaces;
using BookSharing.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using X.PagedList;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace BookSharing.Controllers
{
    public class HomeController : Controller
    {
        private readonly IBookManager _bookManager;

        public HomeController(IBookManager bookManager)
        {
            _bookManager = bookManager;
        }

        public IActionResult Index(int? page)
        {
            var pageNumber = page ?? 1;
            int pageSize = 12;

            var books = _bookManager.GetAll().ToPagedList(pageNumber,
                                                          pageSize);
            return View(books);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
