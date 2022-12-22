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
    [Table("Teams")]
    [Index(nameof(NameTeam), IsUnique = true)]
    public class Team
    {
        [Key]
        public string NameTeam { get; set; }

        [Required]
        public string City { get; set; }
        [Required]
        public string Coach { get; set; }
        [Required]
        public string Colors { get; set; }

        public List<Player> Players { get; set; }
    }
}
