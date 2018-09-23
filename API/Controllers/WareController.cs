using System.Collections.Generic;
using Dealer.Logic.Models;
using Dealer.Logic.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Produces("application/json")]
    [Route("api/ware")]
    public class WareController : Controller
    {
        private IWareRepository _wareRepository { get; set; }

        public WareController (IWareRepository repository)
        {
            _wareRepository = repository;
        }

        [HttpGet]
        [ProducesResponseType(200, Type = typeof(List<Ware>))]
        [ProducesResponseType(404)]
        public IActionResult GetWare()
        {
            var wareRepository = _wareRepository.GetWares();
            return Ok(wareRepository);
        }

        [HttpPost]
        public IActionResult SetScore()
        {
            return NotFound();
        }
    }
}