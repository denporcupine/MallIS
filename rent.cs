namespace MallIS
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Rent
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Rent_id { get; set; }

        public int Renter_id { get; set; }

        public int Mall_id { get; set; }

        public int? Employee_id { get; set; }

        public int Pavilion_id { get; set; }

        [Required]
        [StringLength(100)]
        public string Status { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Start_of_rent { get; set; }

        [Column(TypeName = "date")]
        public DateTime? End_of_rent { get; set; }

        public virtual Employee Employee { get; set; }

        public virtual Mall Mall { get; set; }

        public virtual Pavilion Pavilion { get; set; }

        public virtual Renter Renter { get; set; }
    }
}
