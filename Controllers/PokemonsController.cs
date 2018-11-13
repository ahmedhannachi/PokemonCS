using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PokemonCS.DTOs;
using PokemonCS.Models;

namespace PokemonCS.Controllers
{
    public class PokemonsController : Controller
    {
        private ApplicationDbContext _context;

        public PokemonsController()
        {
            _context = new ApplicationDbContext();
        }

        [Route("")]
        public ActionResult Index()
        {
            List<Pokemon> pokemons = _context.Pokemons.Include(p=>p.PokemonTypes).ToList();

            return View(pokemons);
        }

        [HttpPost]
        public ActionResult Create(PokemonDto pokemonDto)
        {
            if (!ModelState.IsValid)
                return View("Index");

            _context.Pokemons.Add(pokemonDto);

            return View(pokemonDto);

        }
    }
}