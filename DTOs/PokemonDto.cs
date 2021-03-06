﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PokemonCS.DTOs
{
    public class PokemonDto
    {
        public int Id { get; set; }
        [Required]
        [Range(1, 1000)]
        public int hp { get; set; }
        [Required]
        [Range(1, 100)]
        public int cp { get; set; }
        [Required]
        public string name { get; set; }
        [Required]
        public string picture { get; set; }
        [Required]
        public string color { get; set; }
        public List<PokemonTypeDto> PokemonTypes { get; set; }
        [Required]
        public DateTime CreatedDateTime { get; set; }
    }
}