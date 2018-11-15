using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PokemonCS.Models
{
    public class PokemonType
    {
        public int Id { get; set; }
        [Required]
        public string name { get; set; }
        public List<Pokemon> Pokemons { get; set; }
    }
}