using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PokemonCS.Models
{
    public class Pokemon
    {
        public int Id { get; set; }
        [Required]
        [Range(1,1000)]
        public int Hp { get; set; }
        [Required]
        [Range(1, 100)]
        public int Cp { get; set; }
        [Required]
        public string name { get; set; }
        [Required]
        public string picture { get; set; }
        [Required]
        public string color { get; set; }
        public List<PokemonType> PokemonTypes { get; set; }
        [Required]
        public DateTime CreatedDateTime { get; set; }
    }
}