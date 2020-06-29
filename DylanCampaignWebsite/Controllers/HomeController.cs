using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using DylanCampaignWebsite.Models;

namespace DylanCampaignWebsite.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ICharacterRepository _characterRepository;

        public HomeController(ILogger<HomeController> logger, ICharacterRepository characterRepository)
        {
            _logger = logger;
            this._characterRepository = characterRepository;
        }

        public IActionResult Index()
        {
            var model = _characterRepository.GetCharacter(2);
            return View(model);
        }

        public IActionResult TheMap()
        {
            return View();
        }

        public IActionResult PlayerCharacters()
        {
            var model = _characterRepository;
            return View(model);
        }

        public IActionResult NPCharacters()
        {
            return View();
        }

        public IActionResult PlotSynopsis()
        {
            return View();
        }

        public IActionResult ThomasNotes()
        {
            return View();
        }

        public IActionResult WillNotes()
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
