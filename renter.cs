namespace MallIS
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("renter")]
    public partial class Renter
    {
        public Renter()
        {
            Rents = new HashSet<Rent>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Renter_id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Required]
        [StringLength(18)]
        public string Phone { get; set; }

        [Required]
        [StringLength(100)]
        public string Adress { get; set; }

        public virtual ICollection<Rent> Rents { get; set; }
    }
}
