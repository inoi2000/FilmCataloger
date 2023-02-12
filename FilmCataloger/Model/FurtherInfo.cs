using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmCataloger.Model
{
    public class FurtherInfo
    {
        [Key]
        [ForeignKey("Film")]
        public int Id { get; set; }
        public string Description { get; set; }
        public int AgeLimit { get; set; }
        public decimal Fees { get; set; }

        public Films Film { get; set; }
    }
}
