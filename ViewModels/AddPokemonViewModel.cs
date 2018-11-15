using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;
using PokemonCS.DTOs;

namespace PokemonCS.ViewModels
{
    public class AddPokemonViewModel: View
    {
        public PokemonDto PokemonDto { get; set; }
        public IEnumerable<PokemonTypeDto> PokemonTypeDtos { get; set; }
    }
}