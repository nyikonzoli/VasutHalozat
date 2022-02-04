using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VasuthalozatCommonLibrary.Model
{
    class Railway
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        public City FromCity { get; set; }
        public City ToCity { get; set; }
        public int Distance { get; set; }
    }
}
