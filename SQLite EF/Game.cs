using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SQLite_EF
{
    [Table("Games")]
    public class Game
    {
        [Key]
        public int Id { get; set; }

        public String Title { get; set; }

        public int PlatformID { get; set; }
        [ForeignKey("PlatformID")]
        public Platform Platform { get; set; }
    }
}
