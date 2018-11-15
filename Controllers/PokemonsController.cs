using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using AutoMapper;
using PokemonCS.DTOs;
using PokemonCS.Models;
using PokemonCS.ViewModels;

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
            if (ModelState.IsValid)
                return View("Index");

            _context.Pokemons.Add(Mapper.Map<PokemonDto, Pokemon>(pokemonDto));

            return View(pokemonDto);

        }

        public ActionResult Add(PokemonDto pokemonDto)
        {
            View viewModel = new AddPokemonViewModel()
            {
                PokemonDto = pokemonDto,
                PokemonTypeDtos = _context.PokemonTypes.ToList().Select(Mapper.Map<PokemonType, PokemonTypeDto>)
            };

            return View(viewModel);

        }
    }
}