namespace MallIS
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Pavilion
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Pavilion()
        {
            Rents = new HashSet<Rent>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Pavilion_id { get; set; }

        public int Mall_id { get; set; }

        [Required]
        [StringLength(10)]
        public string Pavilion_number { get; set; }

        public byte Floor { get; set; }

        [Required]
        [StringLength(100)]
        public string Status { get; set; }

        public decimal? Area { get; set; }

        public decimal? Cost_per_square_meter { get; set; }

        public decimal? Added_value_ratio { get; set; }

        public virtual Mall Mall { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Rent> Rents { get; set; }
    }
}