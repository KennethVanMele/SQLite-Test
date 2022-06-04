using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SQLite_EF
{
    [Table("Consoles")]
    public class Platform
    {
        [Key]
        public int PlatformID { get; set; }
        public String PlatformName { get; set; }
    }
}
