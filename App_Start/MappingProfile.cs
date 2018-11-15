using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using PokemonCS.DTOs;
using PokemonCS.Models;

namespace PokemonCS.App_Start
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            this.CreateMap<Pokemon, PokemonDto>();
            this.CreateMap<PokemonDto, Pokemon>();
            this.CreateMap<PokemonType, PokemonTypeDto>();
            this.CreateMap<PokemonTypeDto, PokemonType>();
        }
    }
}