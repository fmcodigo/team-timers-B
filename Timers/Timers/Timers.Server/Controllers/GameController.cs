using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Timers.Shared.Models;
using Timers.Shared.Repositories;
using Timers.Shared.Services;
using Timers.Shared.ViewModels;

namespace Timers.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GameController : ControllerBase
    {
        private readonly IRepository<Game> _gameRepository;

        public GameController(IRepository<Game> gameRepository)
        {
            _gameRepository = gameRepository ?? throw new ArgumentNullException(nameof(gameRepository));
        }

        // GET: api/Game
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Game/5
        [HttpGet("{id}")]
        [ProducesResponseType(404)]
        public async Task<ActionResult<Game>> GetAsync(string id)
        {
            var game = await _gameRepository.GetByIdAsync(new Guid(id));

            if (game == null)
            {
                return NotFound();
            }

            return game;
        }


    }
}
