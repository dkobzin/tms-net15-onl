using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqSamples
{

    [Table("penguins")]
    public class Pinguin
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("species")]
        public string? Species { get; set; }
        
        [Column("island")]
        public string? Island { get; set; }
        
        [Column("bill_length_mm")]
        public float? BillLengthMm { get; set; }
        
        [Column("bill_depth_mm")]
        public float? BillDepthMm { get; set; }
        
        [Column("flipper_length_mm")]
        public float? FlipperLengthMm { get; set; }
        
        [Column("body_mass_g")]
        public float? BodyMassG { get; set; }

        [Column("sex")]
        public string? Sex { get; set; }
        /*public int? ChildrenId { get; set; }
        public LittlePinguin Children { get; set; }*/
    }
}
