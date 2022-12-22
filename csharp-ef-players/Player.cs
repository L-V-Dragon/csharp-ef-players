using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_ef_players
{
    [Table("Player")]
    [Index(nameof(Id), IsUnique = true)]
    public class Player
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        [Required]
        public string Surname { get; set; }
        public double score { get; set; }
        public int GamePlayed { get; set; }
        public int GameWon { get; set; }

        public Team Team { get; set; }
    }
}
